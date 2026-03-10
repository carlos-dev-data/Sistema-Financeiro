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

namespace Sistema_Financeiro.Formularios
{
    public partial class Cadastro_de_Cliente : Form
    {
        Cliente clie = new Cliente();
        // Corrigido: inicialização do campo usando o construtor, não diretamente
        public readonly string caminhoArquivoCliente;

        public Cadastro_de_Cliente()
        {
            InitializeComponent();
            caminhoArquivoCliente = clie.caminhoArquivoCliente;
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_NomeCompleto.Text) || string.IsNullOrWhiteSpace(Msk_Telefone.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            List<Cliente> listaCliente = Uteis.CarregarDoJson<Cliente>(caminhoArquivoCliente);

            Cliente novoCliente = new Cliente
            {
                Id = listaCliente.Count + 1,
                NomeCompleto = Txt_NomeCompleto.Text,
                Telefone = Msk_Telefone.Text
            };

            Uteis.SalvarNoJson(caminhoArquivoCliente, novoCliente);
            MessageBox.Show("Cliente salvo com sucesso em ' + caminhoArquivoCliente + !");

            Txt_NomeCompleto.Text = "";
            Msk_Telefone.Text = "";
        }

        private void Cadastro_de_Cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
