using Newtonsoft.Json;
using Sistema_Financeiro.Conexao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void LancarTituloRecebido_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Txt_IdTitulo.Text, out int id))
            {
                MessageBox.Show("Informe um ID válido.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!File.Exists(_caminho))
            {
                MessageBox.Show("Arquivo de títulos não encontrado.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string json = File.ReadAllText(_caminho);
            _lista = JsonConvert.DeserializeObject<List<ContaReceber>>(json)
                     ?? new List<ContaReceber>();

            _tituloAtual = _lista.FirstOrDefault(t => t.IdTitulo == id);

            if (_tituloAtual == null)
            {
                MessageBox.Show("Título não encontrado.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimparCampos();
                return;
            }

            PreencherCampos();
        }

        private void PreencherCampos()
        {
            // Dados do título
            Txt_Cliente.Text = _tituloAtual.NomeCliente;
            Txt_Emissao.Text = _tituloAtual.DataEmissao.ToString("dd/MM/yyyy");
            Txt_Vencimento.Text = _tituloAtual.DataVencimento.ToString("dd/MM/yyyy");
            Txt_Receber.Text = _tituloAtual.ValorAReceber.ToString("N2", _ptBR);

            // Situação financeira
            Txt_Recebido.Text = _tituloAtual.ValorRecebido.ToString("N2", _ptBR);
            Txt_Diferenca.Text = _tituloAtual.Diferenca.ToString("N2", _ptBR);
            Txt_DataUltPag.Text = _tituloAtual.DataPagamento.HasValue
                                    ? _tituloAtual.DataPagamento.Value.ToString("dd/MM/yyyy")
                                    : "-";

            // Status com cor (corrigido)
            Txt_Status.Text = _tituloAtual.Status;
            if (_tituloAtual.Status == "Pago")
                Txt_Status.ForeColor = Color.DarkGreen;
            else if (_tituloAtual.Status == "Pago Parcial")
                Txt_Status.ForeColor = Color.DarkBlue;
            else
                Txt_Status.ForeColor = Color.DarkGoldenrod;

            // Sugere o valor restante no campo de pagamento
            Txt_APagar.Text = _tituloAtual.Diferenca.ToString("N2", _ptBR);
            Dtp_Pagamento.Value = DateTime.Now;

            // Bloqueia campos se já estiver pago
            bool bloqueado = _tituloAtual.Status == "Pago";
            Txt_APagar.Enabled = !bloqueado;
            Dtp_Pagamento.Enabled = !bloqueado;
            Btn_Registrar.Enabled = !bloqueado;
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            if (_tituloAtual == null)
            {
                MessageBox.Show("Busque um título primeiro.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(Txt_APagar.Text))
            {
                MessageBox.Show("Informe o valor do pagamento.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(Txt_APagar.Text,
                    NumberStyles.Currency, _ptBR, out decimal valorPagamento))
            {
                MessageBox.Show("Valor inválido.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string resultado = _tituloAtual.RegistrarPagamento(valorPagamento, Dtp_Pagamento.Value);

            if (resultado != "OK")
            {
                MessageBox.Show(resultado, "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Salvar no JSON
            string jsonAtualizado = JsonConvert.SerializeObject(_lista, Formatting.Indented);
            File.WriteAllText(_caminho, jsonAtualizado);

            MessageBox.Show(
                $"Pagamento registrado!\n" +
                $"Valor Pago:  R$ {_tituloAtual.ValorRecebido:N2}\n" +
                $"Restante:    R$ {_tituloAtual.Diferenca:N2}\n" +
                $"Status:      {_tituloAtual.Status}",
                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            PreencherCampos();
        }

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

        private void LimparCampos()
        {
            _tituloAtual = null;
            Txt_IdTitulo.Clear();
            Txt_Cliente.Clear();
            Txt_Emissao.Clear();
            Txt_Vencimento.Clear();
            Txt_Receber.Clear();
            Txt_Recebido.Clear();
            Txt_Diferenca.Clear();
            Txt_DataUltPag.Clear();
            Txt_APagar.Clear();
            Txt_Status.Text = string.Empty;
            Txt_Status.ForeColor = Color.Black;
            Dtp_Pagamento.Value = DateTime.Now;
        }
    }
}
