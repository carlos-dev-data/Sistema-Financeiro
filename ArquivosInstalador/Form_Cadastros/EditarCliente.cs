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

namespace Sistema_Financeiro.Form_Cadastros
{
    public partial class EditarCliente : Form
    {
        public EditarCliente()
        {
            InitializeComponent();
        }

        private void Txt_Id_MouseLeave(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            if (!string.IsNullOrWhiteSpace(Txt_Id.Text)) // Verificar se o campo de ID não está vazio
            {
                if (int.TryParse(Txt_Id.Text, out int idBusca)) // Tentar converter o texto para um número inteiro
                {

                    if (System.IO.File.Exists(cliente.caminhoArquivoCliente)) // Verificar se o arquivo existe antes de tentar ler
                    {
                        string jsonLido = System.IO.File.ReadAllText(cliente.caminhoArquivoCliente); // Ler o conteúdo do arquivo JSON
                        var listaParaBusca = JsonConvert.DeserializeObject<List<Cliente>>(jsonLido); // Corrigido: usar JsonConvert para desserializar a partir de string


                        var clienteEncontrado = listaParaBusca.FirstOrDefault(a => a.Id == idBusca); // Procurar o aluno com o ID correspondente usando LINQ

                        if (clienteEncontrado != null) // Verificar se um aluno foi encontrado e, em caso afirmativo, preencher os campos de nome e CPF com as informações do aluno encontrado
                        {

                            Txt_NomeCompleto.Text = clienteEncontrado.NomeCompleto;
                            Msk_Telefone.Text = clienteEncontrado.Telefone;
                        }
                        else
                        {
                            MessageBox.Show("Cliente não encontrado no arquivo.");
                        }
                    }
                }
            }
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            // Validar se os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(Txt_Id.Text) ||
                string.IsNullOrWhiteSpace(Txt_NomeCompleto.Text) ||
                string.IsNullOrWhiteSpace(Msk_Telefone.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de editar.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente cliente = new Cliente();

            if (!int.TryParse(Txt_Id.Text, out int idEditar))
            {
                MessageBox.Show("ID inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!System.IO.File.Exists(cliente.caminhoArquivoCliente))
            {
                MessageBox.Show("Arquivo de clientes não encontrado.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ler a lista existente
            string jsonLido = System.IO.File.ReadAllText(cliente.caminhoArquivoCliente);
            var lista = JsonConvert.DeserializeObject<List<Cliente>>(jsonLido);

            // Buscar o cliente pelo ID
            var clienteParaEditar = lista.FirstOrDefault(c => c.Id == idEditar);

            if (clienteParaEditar == null)
            {
                MessageBox.Show("Cliente não encontrado.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Atualizar os dados
            clienteParaEditar.NomeCompleto = Txt_NomeCompleto.Text;
            clienteParaEditar.Telefone = Msk_Telefone.Text;

            // Salvar a lista atualizada no arquivo
            string jsonAtualizado = JsonConvert.SerializeObject(lista, Formatting.Indented);
            System.IO.File.WriteAllText(cliente.caminhoArquivoCliente, jsonAtualizado);

            MessageBox.Show("Cliente editado com sucesso!",
                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpar os campos após editar
            Txt_Id.Clear();
            Txt_NomeCompleto.Clear();
            Msk_Telefone.Clear();
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
