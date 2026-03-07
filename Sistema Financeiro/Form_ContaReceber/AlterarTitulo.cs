using Newtonsoft.Json;
using Sistema_Financeiro.Conexao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Financeiro.Form_ContaReceber
{
    public partial class AlterarTitulo : Form
    {
        public AlterarTitulo()
        {
            InitializeComponent();
        }

        private void Txt_IDTitulo_MouseLeave(object sender, EventArgs e)
        {
            ContaReceber contaReceber = new ContaReceber();

            if (!string.IsNullOrWhiteSpace(Txt_IDTitulo.Text)) // Verificar se o campo de ID não está vazio
            {
                if (int.TryParse(Txt_IDTitulo.Text, out int idBusca)) // Tentar converter o texto para um número inteiro
                {

                    if (System.IO.File.Exists(contaReceber.caminhoArquivoContaReceber)) // Verificar se o arquivo existe antes de tentar ler
                    {
                        string jsonLido = System.IO.File.ReadAllText(contaReceber.caminhoArquivoContaReceber); // Ler o conteúdo do arquivo JSON
                        var listaParaBusca = JsonConvert.DeserializeObject<List<ContaReceber>>(jsonLido); // Corrigido: usar JsonConvert para desserializar a partir de string


                        var tituloEncontrado = listaParaBusca.FirstOrDefault(a => a.IdTitulo == idBusca); // Procurar o aluno com o ID correspondente usando LINQ

                        if (tituloEncontrado != null) // Verificar se um aluno foi encontrado e, em caso afirmativo, preencher os campos de nome e CPF com as informações do aluno encontrado
                        {
                            Txt_IdCliente.Text = tituloEncontrado.IdCliente.ToString();
                            Lbl_Cliente.Text = tituloEncontrado.NomeCliente;
                            Txt_ValorAReceber.Text = tituloEncontrado.ValorAReceber.ToString("F2");
                            Dtp_DataEmissao.Value = tituloEncontrado.DataEmissao;
                            Dtp_DataVencimento.Value = tituloEncontrado.DataVencimento;
                        }
                        else
                        {
                            MessageBox.Show("Titulo não encontrado no arquivo.");
                        }
                    }
                }
            }
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            // Validar se os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(Txt_IDTitulo.Text) ||
                string.IsNullOrWhiteSpace(Txt_IdCliente.Text) ||
                string.IsNullOrWhiteSpace(Lbl_Cliente.Text) ||
                string.IsNullOrWhiteSpace(Txt_ValorAReceber.Text) ||
                string.IsNullOrWhiteSpace(Dtp_DataEmissao.Text) ||
                string.IsNullOrWhiteSpace(Dtp_DataVencimento.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de editar.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ContaReceber receber = new ContaReceber();

            if (!int.TryParse(Txt_IDTitulo.Text, out int idEditar))
            {
                MessageBox.Show("ID inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!System.IO.File.Exists(receber.caminhoArquivoContaReceber))
            {
                MessageBox.Show("Arquivo de titulos não encontrado.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ler a lista existente
            string jsonLido = System.IO.File.ReadAllText(receber.caminhoArquivoContaReceber);
            var lista = JsonConvert.DeserializeObject<List<ContaReceber>>(jsonLido);

            // Buscar o título pelo ID
            var TituloParaEditar = lista.FirstOrDefault(c => c.IdTitulo == idEditar);

            if (TituloParaEditar == null)
            {
                MessageBox.Show("Titulo não encontrado.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ✅ Atualizar os dados do título encontrado na lista
            TituloParaEditar.IdCliente = int.Parse(Txt_IdCliente.Text);
            TituloParaEditar.NomeCliente = Lbl_Cliente.Text;
            TituloParaEditar.ValorAReceber = decimal.Parse(Txt_ValorAReceber.Text,
                System.Globalization.NumberStyles.Currency,
                new System.Globalization.CultureInfo("pt-BR"));
            TituloParaEditar.DataEmissao = Dtp_DataEmissao.Value;
            TituloParaEditar.DataVencimento = Dtp_DataVencimento.Value;

            // Salvar a lista atualizada no arquivo
            string jsonAtualizado = JsonConvert.SerializeObject(lista, Formatting.Indented);
            System.IO.File.WriteAllText(receber.caminhoArquivoContaReceber, jsonAtualizado);

            MessageBox.Show("Titulo editado com sucesso!",
                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpar os campos após editar
            Txt_IDTitulo.Clear();
            Txt_IdCliente.Clear();
            Lbl_Cliente.Text = string.Empty;
            Txt_ValorAReceber.Clear();
            Dtp_DataEmissao.Value = DateTime.Now;
            Dtp_DataVencimento.Value = DateTime.Now;
        }

        private void Txt_IdCliente_MouseLeave(object sender, EventArgs e)
        {

            Cliente cliente = new Cliente();

            if (!string.IsNullOrWhiteSpace(Txt_IdCliente.Text)) // Verificar se o campo de ID não está vazio
            {
                if (int.TryParse(Txt_IdCliente.Text, out int idBusca)) // Tentar converter o texto para um número inteiro
                {

                    if (System.IO.File.Exists(cliente.caminhoArquivoCliente)) // Verificar se o arquivo existe antes de tentar ler
                    {
                        string jsonLido = System.IO.File.ReadAllText(cliente.caminhoArquivoCliente); // Ler o conteúdo do arquivo JSON
                        var listaParaBusca = JsonConvert.DeserializeObject<List<Cliente>>(jsonLido); // Corrigido: usar JsonConvert para desserializar a partir de string


                        var clienteEncontrado = listaParaBusca.FirstOrDefault(a => a.Id == idBusca); // Procurar o aluno com o ID correspondente usando LINQ

                        if (clienteEncontrado != null) // Verificar se um aluno foi encontrado e, em caso afirmativo, preencher os campos de nome e CPF com as informações do aluno encontrado
                        {

                            Lbl_Cliente.Text = clienteEncontrado.NomeCompleto;
                        }
                        else
                        {
                            MessageBox.Show("Cliente não encontrado no arquivo.");
                        }
                    }
                }
            }
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
