using Newtonsoft.Json;
using Sistema_Financeiro.Conexao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Financeiro.Form_ContaReceber
{
    public partial class LancarTitulo : Form
    {
        public LancarTitulo()
        {
            InitializeComponent();
            Dtp_DataEmissao.Value = DateTime.Today;
        }

        private void LancarTitulo_Load(object sender, EventArgs e)
        {

        }

        private void Txt_IdCliente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Txt_IdCliente_MouseLeave(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            if (!string.IsNullOrWhiteSpace(Txt_IdCliente.Text))
            {
                if (int.TryParse(Txt_IdCliente.Text, out int idBusca))
                {
                    if (File.Exists(cliente.caminhoArquivoCliente))
                    {
                        string json = File.ReadAllText(cliente.caminhoArquivoCliente);
                        var lista = JsonConvert.DeserializeObject<List<Cliente>>(json);
                        var clienteEncontrado = lista.FirstOrDefault(c => c.Id == idBusca);

                        if (clienteEncontrado != null)
                            Lbl_NomeCliente.Text = clienteEncontrado.NomeCompleto;
                        else
                            MessageBox.Show("Cliente não encontrado.", "Atenção",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void LimparCampos()
        {
            Txt_IdCliente.Clear();
            Lbl_NomeCliente.Text = "";
            Txt_ValorAReceber.Clear();
            Dtp_DataEmissao.Value = DateTime.Today;
            Dtp_DataVencimento.Value = DateTime.Today;
        }

        private void Btn_Criar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_IdCliente.Text) ||
                string.IsNullOrWhiteSpace(Lbl_NomeCliente.Text) ||
                string.IsNullOrWhiteSpace(Txt_ValorAReceber.Text))
            {
                MessageBox.Show("Preencha todos os campos.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(Txt_ValorAReceber.Text, out decimal valor))
            {
                MessageBox.Show("Valor inválido.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ContaReceber conta = new ContaReceber();

            // Carregar lista existente ou criar nova
            List<ContaReceber> lista = new List<ContaReceber>();
            if (File.Exists(conta.caminhoArquivoContaReceber))
            {
                string jsonLido = File.ReadAllText(conta.caminhoArquivoContaReceber);
                lista = JsonConvert.DeserializeObject<List<ContaReceber>>(jsonLido)
                        ?? new List<ContaReceber>();
            }

            // Montar novo registro
            ContaReceber nova = new ContaReceber
            {
                IdTitulo = conta.GerarProximoId(lista),
                IdCliente = int.Parse(Txt_IdCliente.Text),
                NomeCliente = Lbl_NomeCliente.Text,
                DataEmissao = Dtp_DataEmissao.Value,
                DataVencimento = Dtp_DataVencimento.Value,
                ValorAReceber = valor
            };

            lista.Add(nova);

            // Garantir que o diretório existe
            Directory.CreateDirectory(Path.GetDirectoryName(conta.caminhoArquivoContaReceber));

            // Salvar
            string jsonSalvo = JsonConvert.SerializeObject(lista, Formatting.Indented);
            File.WriteAllText(conta.caminhoArquivoContaReceber, jsonSalvo);

            MessageBox.Show($"Conta a receber cadastrada! ID Título: {nova.IdTitulo}",
                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparCampos();
        }

        private void Txt_ValorAReceber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas dígitos e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Txt_ValorAReceber_TextChanged(object sender, EventArgs e)
        {
            // Evita loop recursivo
            Txt_ValorAReceber.TextChanged -= Txt_ValorAReceber_TextChanged;

            // Remove tudo que não for dígito
            string apenasDigitos = new string(Txt_ValorAReceber.Text.Where(char.IsDigit).ToArray());

            if (apenasDigitos.Length > 0)
            {
                // Trata como centavos
                decimal valor = decimal.Parse(apenasDigitos) / 100m;
                Txt_ValorAReceber.Text = valor.ToString("N2", new System.Globalization.CultureInfo("pt-BR"));
                Txt_ValorAReceber.SelectionStart = Txt_ValorAReceber.Text.Length; // cursor no final
            }
            else
            {
                Txt_ValorAReceber.Text = "";
            }

            Txt_ValorAReceber.TextChanged += Txt_ValorAReceber_TextChanged;
        }
    }
}
