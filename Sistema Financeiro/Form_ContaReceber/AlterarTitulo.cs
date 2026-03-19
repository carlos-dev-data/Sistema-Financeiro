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
    public partial class AlterarTitulo : Form
    {
        private readonly CultureInfo _ptBR = new CultureInfo("pt-BR");

        public AlterarTitulo()
        {
            InitializeComponent();
            Dtp_DataEmissao.Value = DateTime.Today;
            Dtp_DataVencimento.Value = DateTime.Today;
        }

        private void AlterarTitulo_Load(object sender, EventArgs e) { }

        public void PreCarregarTitulo(int idTitulo)
        {
            Txt_IDTitulo.Text = idTitulo.ToString();
            BuscarTitulo();
        }

        // ── Busca título pelo ID ──────────────────────────────────────
        private void Txt_IDTitulo_MouseLeave(object sender, EventArgs e) => BuscarTitulo();

        private void BuscarTitulo()
        {
            if (string.IsNullOrWhiteSpace(Txt_IDTitulo.Text)) return;
            if (!int.TryParse(Txt_IDTitulo.Text, out int idBusca)) return;

            var conta = new ContaReceber();
            if (!File.Exists(conta.caminhoArquivoContaReceber)) return;

            var lista = JsonConvert.DeserializeObject<List<ContaReceber>>(
                            File.ReadAllText(conta.caminhoArquivoContaReceber));

            var titulo = lista?.FirstOrDefault(t => t.IdTitulo == idBusca);

            if (titulo != null)
            {
                Txt_IdCliente.Text = titulo.IdCliente.ToString();
                Lbl_Cliente.Text = titulo.NomeCliente;
                Lbl_Cliente.ForeColor = Color.FromArgb(30, 41, 59);
                Txt_ValorAReceber.Text = titulo.ValorAReceber.ToString("N2", _ptBR);
                Dtp_DataEmissao.Value = titulo.DataEmissao;
                Dtp_DataVencimento.Value = titulo.DataVencimento;

                // Feedback visual no card ID
                pnlIDTitulo.BackColor = Color.FromArgb(240, 253, 244); // verde muito claro
                lblIDTitulo.ForeColor = Color.FromArgb(21, 128, 61);
                Txt_IDTitulo.ForeColor = Color.FromArgb(21, 128, 61);
            }
            else
            {
                Mostrar("Título não encontrado.", "Atenção", MessageBoxIcon.Warning);
                LimparCampos();
            }
        }

        // ── Busca cliente pelo código ─────────────────────────────────
        private void Txt_IdCliente_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_IdCliente.Text)) return;
            if (!int.TryParse(Txt_IdCliente.Text, out int id)) return;

            var cliente = new Cliente();
            if (!File.Exists(cliente.caminhoArquivoCliente)) return;

            var lista = JsonConvert.DeserializeObject<List<Cliente>>(
                            File.ReadAllText(cliente.caminhoArquivoCliente));

            var encontrado = lista?.FirstOrDefault(c => c.Id == id);

            if (encontrado != null)
            {
                Lbl_Cliente.Text = encontrado.NomeCompleto;
                Lbl_Cliente.ForeColor = Color.FromArgb(30, 41, 59);
            }
            else
            {
                Lbl_Cliente.Text = "Cliente não encontrado";
                Lbl_Cliente.ForeColor = Color.FromArgb(185, 28, 28);
            }
        }

        // ── Máscara monetária ─────────────────────────────────────────
        private void Txt_ValorAReceber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void Txt_ValorAReceber_TextChanged(object sender, EventArgs e)
        {
            Txt_ValorAReceber.TextChanged -= Txt_ValorAReceber_TextChanged;

            string digits = new string(Txt_ValorAReceber.Text.Where(char.IsDigit).ToArray());
            if (digits.Length > 0)
            {
                decimal valor = decimal.Parse(digits) / 100m;
                Txt_ValorAReceber.Text = valor.ToString("N2", _ptBR);
                Txt_ValorAReceber.SelectionStart = Txt_ValorAReceber.Text.Length;
            }
            else
            {
                Txt_ValorAReceber.Text = "";
            }

            Txt_ValorAReceber.TextChanged += Txt_ValorAReceber_TextChanged;
        }

        // ── Salvar alteração ──────────────────────────────────────────
        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_IDTitulo.Text) ||
                string.IsNullOrWhiteSpace(Txt_IdCliente.Text) ||
                string.IsNullOrWhiteSpace(Lbl_Cliente.Text) || Lbl_Cliente.Text == "—" ||
                string.IsNullOrWhiteSpace(Txt_ValorAReceber.Text))
            {
                Mostrar("Preencha todos os campos antes de salvar.", "Atenção",
                    MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(Txt_IDTitulo.Text, out int idEditar))
            {
                Mostrar("ID do título inválido.", "Erro", MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(Txt_ValorAReceber.Text,
                    NumberStyles.Currency, _ptBR, out decimal valor) || valor <= 0)
            {
                Mostrar("Valor inválido. Digite um valor maior que zero.", "Erro",
                    MessageBoxIcon.Error);
                return;
            }

            if (Dtp_DataVencimento.Value.Date < Dtp_DataEmissao.Value.Date)
            {
                Mostrar("A data de vencimento não pode ser anterior à emissão.", "Atenção",
                    MessageBoxIcon.Warning);
                return;
            }

            var receber = new ContaReceber();
            if (!File.Exists(receber.caminhoArquivoContaReceber))
            {
                Mostrar("Arquivo de títulos não encontrado.", "Erro", MessageBoxIcon.Error);
                return;
            }

            var lista = JsonConvert.DeserializeObject<List<ContaReceber>>(
                            File.ReadAllText(receber.caminhoArquivoContaReceber));

            var titulo = lista?.FirstOrDefault(t => t.IdTitulo == idEditar);
            if (titulo == null)
            {
                Mostrar("Título não encontrado.", "Erro", MessageBoxIcon.Error);
                return;
            }

            titulo.IdCliente = int.Parse(Txt_IdCliente.Text);
            titulo.NomeCliente = Lbl_Cliente.Text;
            titulo.ValorAReceber = valor;
            titulo.DataEmissao = Dtp_DataEmissao.Value.Date;
            titulo.DataVencimento = Dtp_DataVencimento.Value.Date;

            File.WriteAllText(receber.caminhoArquivoContaReceber,
                JsonConvert.SerializeObject(lista, Formatting.Indented));

            Mostrar(
                $"Título #{idEditar} atualizado com sucesso!\n\n" +
                $"Cliente:     {titulo.NomeCliente}\n" +
                $"Valor:       {titulo.ValorAReceber:C2}\n" +
                $"Vencimento:  {titulo.DataVencimento:dd/MM/yyyy}",
                "Alteração Salva", MessageBoxIcon.Information);

            LimparCampos();
        }

        // ── Limpar ────────────────────────────────────────────────────
        private void Btn_Cancelar_Click(object sender, EventArgs e) => LimparCampos();

        private void LimparCampos()
        {
            Txt_IDTitulo.Clear();
            Txt_IdCliente.Clear();
            Txt_ValorAReceber.Clear();
            Lbl_Cliente.Text = "—";
            Lbl_Cliente.ForeColor = Color.FromArgb(30, 41, 59);
            Dtp_DataEmissao.Value = DateTime.Today;
            Dtp_DataVencimento.Value = DateTime.Today;

            // Reseta visual do card ID
            pnlIDTitulo.BackColor = Color.FromArgb(255, 251, 235);
            lblIDTitulo.ForeColor = Color.FromArgb(146, 64, 14);
            Txt_IDTitulo.ForeColor = Color.FromArgb(146, 64, 14);

            Txt_IDTitulo.Focus();
        }

        private void Mostrar(string msg, string titulo, MessageBoxIcon icone) =>
            MessageBox.Show(msg, titulo, MessageBoxButtons.OK, icone);
    }
}