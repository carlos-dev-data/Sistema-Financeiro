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
    public partial class EstornarTitulo : Form
    {
        private List<ContaReceber> _lista = new List<ContaReceber>();
        private ContaReceber _tituloAtual = null;
        private readonly CultureInfo _ptBR = new CultureInfo("pt-BR");
        private readonly string _caminho = new ContaReceber().caminhoArquivoContaReceber;

        public EstornarTitulo()
        {
            InitializeComponent();
        }

        private void EstornarTitulo_Load(object sender, EventArgs e) { }

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

            if (_tituloAtual.Status == "Aberto")
            {
                Mostrar("Este título está com status 'Aberto' e não possui\npagamentos registrados para estornar.",
                    "Atenção", MessageBoxIcon.Warning);
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
            Txt_AReceber.Text = _tituloAtual.ValorAReceber.ToString("N2", _ptBR);
            Txt_Recebido.Text = _tituloAtual.ValorRecebido.ToString("N2", _ptBR);
            Txt_Saldo.Text = _tituloAtual.Diferenca.ToString("N2", _ptBR);

            // Status com cor
            Txt_Status.Text = _tituloAtual.Status;
            if (_tituloAtual.Status == "Pago")
                Txt_Status.ForeColor = Color.FromArgb(22, 101, 52);
            else if (_tituloAtual.Status == "Pago Parcial")
                Txt_Status.ForeColor = Color.FromArgb(29, 78, 216);
            else
                Txt_Status.ForeColor = Color.FromArgb(146, 64, 14);

            // Sugere estorno total como padrão
            Txt_ValorEstorno.Text = _tituloAtual.ValorRecebido.ToString("N2", _ptBR);
            Btn_Estornar.Enabled = true;
            Btn_Estornar.BackColor = Color.FromArgb(220, 38, 38);
        }

        // ── Confirmar estorno ─────────────────────────────────────────
        private void Btn_Estornar_Click(object sender, EventArgs e)
        {
            if (_tituloAtual == null)
            {
                Mostrar("Busque um título primeiro.", "Atenção", MessageBoxIcon.Warning);
                return;
            }

            decimal valorEstorno = _tituloAtual.ValorRecebido; // estorno total por padrão

            if (!string.IsNullOrWhiteSpace(Txt_ValorEstorno.Text))
            {
                if (!decimal.TryParse(Txt_ValorEstorno.Text, NumberStyles.Currency, _ptBR, out valorEstorno) || valorEstorno <= 0)
                {
                    Mostrar("Valor de estorno inválido.", "Erro", MessageBoxIcon.Error);
                    return;
                }
            }

            // Confirmação obrigatória
            string tipoEstorno = valorEstorno == _tituloAtual.ValorRecebido ? "TOTAL" : "PARCIAL";
            DialogResult confirm = MessageBox.Show(
                $"Confirma o estorno {tipoEstorno} do título #{_tituloAtual.IdTitulo}?\n\n" +
                $"Cliente:          {_tituloAtual.NomeCliente}\n" +
                $"Valor a estornar: R$ {valorEstorno:N2}\n" +
                $"Situação após:    {(valorEstorno == _tituloAtual.ValorRecebido ? "Aberto" : "Pago Parcial")}\n\n" +
                "Esta operação não pode ser desfeita.",
                "Confirmar Estorno",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            string resultado = _tituloAtual.EstornarPagamento(valorEstorno);

            if (resultado != "OK")
            {
                Mostrar(resultado, "Atenção", MessageBoxIcon.Warning);
                return;
            }

            File.WriteAllText(_caminho,
                JsonConvert.SerializeObject(_lista, Formatting.Indented));

            Mostrar(
                $"Estorno realizado com sucesso!\n\n" +
                $"Título:    #{_tituloAtual.IdTitulo}\n" +
                $"Estornado: R$ {valorEstorno:N2}\n" +
                $"Recebido:  R$ {_tituloAtual.ValorRecebido:N2}\n" +
                $"Status:    {_tituloAtual.Status}",
                "Estorno Concluído", MessageBoxIcon.Information);

            LimparCampos();
        }

        // ── Máscara monetária ─────────────────────────────────────────
        private void Txt_ValorEstorno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void Txt_ValorEstorno_TextChanged(object sender, EventArgs e)
        {
            Txt_ValorEstorno.TextChanged -= Txt_ValorEstorno_TextChanged;
            string digits = new string(Txt_ValorEstorno.Text.Where(char.IsDigit).ToArray());
            Txt_ValorEstorno.Text = digits.Length > 0
                ? (decimal.Parse(digits) / 100m).ToString("N2", _ptBR)
                : "";
            Txt_ValorEstorno.SelectionStart = Txt_ValorEstorno.Text.Length;
            Txt_ValorEstorno.TextChanged += Txt_ValorEstorno_TextChanged;
        }

        // ── Limpar ────────────────────────────────────────────────────
        private void Btn_Limpar_Click(object sender, EventArgs e) => LimparCampos();

        private void LimparCampos()
        {
            _tituloAtual = null;
            Txt_IdTitulo.Clear();
            Txt_Cliente.Clear();
            Txt_Emissao.Clear();
            Txt_Vencimento.Clear();
            Txt_Status.Text = "";
            Txt_Status.ForeColor = Color.FromArgb(30, 41, 59);
            Txt_AReceber.Clear();
            Txt_Recebido.Clear();
            Txt_Saldo.Clear();
            Txt_ValorEstorno.Clear();
            Btn_Estornar.Enabled = true;
            Btn_Estornar.BackColor = Color.FromArgb(220, 38, 38);
            Txt_IdTitulo.Focus();
        }

        private void Mostrar(string msg, string titulo, MessageBoxIcon icone) =>
            MessageBox.Show(msg, titulo, MessageBoxButtons.OK, icone);
    }
}