using Newtonsoft.Json;
using Sistema_Financeiro.Conexao;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_Financeiro.Form_ContaReceber
{
    public partial class LancarTituloRecebido : Form
    {
        private List<ContaReceber> _lista = new List<ContaReceber>();
        private ContaReceber _tituloAtual = null;
        private readonly CultureInfo _ptBR = new CultureInfo("pt-BR");
        private readonly string _caminho = new ContaReceber().caminhoArquivoContaReceber;

        public LancarTituloRecebido()
        {
            InitializeComponent();
        }

        private void LancarTituloRecebido_Load(object sender, EventArgs e) { }

        public void PreCarregarTitulo(int idTitulo)
        {
            Txt_IdTitulo.Text = idTitulo.ToString();
            Btn_Buscar_Click(null, EventArgs.Empty);
        }

        // ── Buscar título ─────────────────────────────────────────────
        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Txt_IdTitulo.Text, out int id))
            {
                Mostrar("Informe um ID de título válido.", "Atenção", MessageBoxIcon.Warning);
                return;
            }

            if (!File.Exists(_caminho))
            {
                Mostrar("Arquivo de títulos não encontrado.", "Erro", MessageBoxIcon.Error);
                return;
            }

            _lista = JsonConvert.DeserializeObject<List<ContaReceber>>(
                         File.ReadAllText(_caminho)) ?? new List<ContaReceber>();

            _tituloAtual = _lista.FirstOrDefault(t => t.IdTitulo == id);

            if (_tituloAtual == null)
            {
                Mostrar("Título não encontrado.", "Atenção", MessageBoxIcon.Warning);
                LimparCampos();
                return;
            }

            PreencherCampos();
        }

        // ── Preencher campos ──────────────────────────────────────────
        private void PreencherCampos()
        {
            Txt_Cliente.Text = _tituloAtual.NomeCliente;
            Txt_Emissao.Text = _tituloAtual.DataEmissao.ToString("dd/MM/yyyy");
            Txt_Vencimento.Text = _tituloAtual.DataVencimento.ToString("dd/MM/yyyy");
            Txt_Receber.Text = _tituloAtual.ValorAReceber.ToString("N2", _ptBR);
            Txt_Recebido.Text = _tituloAtual.ValorRecebido.ToString("N2", _ptBR);
            Txt_Diferenca.Text = _tituloAtual.Diferenca.ToString("N2", _ptBR);
            Txt_DataUltPag.Text = _tituloAtual.DataPagamento.HasValue
                                    ? _tituloAtual.DataPagamento.Value.ToString("dd/MM/yyyy")
                                    : "—";

            // Status com cor
            bool vencido = _tituloAtual.Status != "Pago" &&
                           _tituloAtual.DataVencimento.Date < DateTime.Today;

            string statusExibir = vencido ? "Vencido" : _tituloAtual.Status;
            Txt_Status.Text = statusExibir;
            if (statusExibir == "Pago")
                Txt_Status.ForeColor = Color.FromArgb(22, 101, 52);
            else if (statusExibir == "Pago Parcial")
                Txt_Status.ForeColor = Color.FromArgb(29, 78, 216);
            else if (statusExibir == "Vencido")
                Txt_Status.ForeColor = Color.FromArgb(185, 28, 28);
            else
                Txt_Status.ForeColor = Color.FromArgb(146, 64, 14);

            // Saldo vermelho se tem saldo
            Txt_Diferenca.ForeColor = _tituloAtual.Diferenca > 0
                ? Color.FromArgb(185, 28, 28)
                : Color.FromArgb(22, 101, 52);

            // Campo pagamento
            Txt_APagar.Text = _tituloAtual.Diferenca.ToString("N2", _ptBR);
            Dtp_Pagamento.Value = DateTime.Today;

            bool bloqueado = _tituloAtual.Status == "Pago";
            Txt_APagar.Enabled = !bloqueado;
            Dtp_Pagamento.Enabled = !bloqueado;
            Btn_Registrar.Enabled = !bloqueado;
            Btn_Registrar.BackColor = bloqueado
                ? Color.FromArgb(148, 163, 184)
                : Color.FromArgb(22, 163, 74);
        }

        // ── Registrar pagamento ───────────────────────────────────────
        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            if (_tituloAtual == null)
            {
                Mostrar("Busque um título primeiro.", "Atenção", MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(Txt_APagar.Text))
            {
                Mostrar("Informe o valor do pagamento.", "Atenção", MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(Txt_APagar.Text, NumberStyles.Currency, _ptBR, out decimal valor))
            {
                Mostrar("Valor inválido.", "Erro", MessageBoxIcon.Error);
                return;
            }

            string resultado = _tituloAtual.RegistrarPagamento(valor, Dtp_Pagamento.Value);

            if (resultado != "OK")
            {
                Mostrar(resultado, "Atenção", MessageBoxIcon.Warning);
                return;
            }

            File.WriteAllText(_caminho,
                JsonConvert.SerializeObject(_lista, Formatting.Indented));

            Mostrar(
                $"Pagamento registrado com sucesso!\n\n" +
                $"Valor pago:   R$ {_tituloAtual.ValorRecebido:N2}\n" +
                $"Saldo restante:  R$ {_tituloAtual.Diferenca:N2}\n" +
                $"Status:       {_tituloAtual.Status}",
                "Pagamento Registrado", MessageBoxIcon.Information);

            PreencherCampos();
        }

        // ── Máscara monetária ─────────────────────────────────────────
        private void Txt_APagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void Txt_APagar_TextChanged(object sender, EventArgs e)
        {
            Txt_APagar.TextChanged -= Txt_APagar_TextChanged;
            string digits = new string(Txt_APagar.Text.Where(char.IsDigit).ToArray());
            Txt_APagar.Text = digits.Length > 0
                ? (decimal.Parse(digits) / 100m).ToString("N2", _ptBR)
                : "";
            Txt_APagar.SelectionStart = Txt_APagar.Text.Length;
            Txt_APagar.TextChanged += Txt_APagar_TextChanged;
        }

        // ── Limpar ────────────────────────────────────────────────────
        private void Btn_Limpar_Click(object sender, EventArgs e) => LimparCampos();

        private void LimparCampos()
        {
            _tituloAtual = null;
            Txt_IdTitulo.Clear();
            Txt_Cliente.Text = "";
            Txt_Emissao.Clear(); Txt_Vencimento.Clear();
            Txt_Status.Text = ""; Txt_Status.ForeColor = Color.FromArgb(30, 41, 59);
            Txt_Receber.Clear(); Txt_Recebido.Clear(); Txt_Diferenca.Clear();
            Txt_DataUltPag.Clear(); Txt_APagar.Clear();
            Txt_Diferenca.ForeColor = Color.FromArgb(185, 28, 28);
            Dtp_Pagamento.Value = DateTime.Today;
            Txt_APagar.Enabled = true; Dtp_Pagamento.Enabled = true;
            Btn_Registrar.Enabled = true;
            Btn_Registrar.BackColor = Color.FromArgb(22, 163, 74);
            Txt_IdTitulo.Focus();
        }

        private void Mostrar(string msg, string titulo, MessageBoxIcon icone) =>
            MessageBox.Show(msg, titulo, MessageBoxButtons.OK, icone);
    }
}