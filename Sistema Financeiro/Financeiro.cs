using Sistema_Financeiro.Conexao;
using Sistema_Financeiro.Configuracao;
using Sistema_Financeiro.Form_Cadastros;
using Sistema_Financeiro.Form_ContaReceber;
using Sistema_Financeiro.Form_Relatorios;
using Sistema_Financeiro.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Financeiro
{
    public partial class Financeiro : Form
    {
        public Financeiro()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_de_Cliente cadastroCliente = new Cadastro_de_Cliente();
            cadastroCliente.MdiParent = this;
            cadastroCliente.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Relatorios.Rel_Clientes relClientes = new Form_Relatorios.Rel_Clientes();
            relClientes.MdiParent = this;
            relClientes.Show();
        }

        private void editarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarCliente editarCliente = new EditarCliente();
            editarCliente.MdiParent = this;
            editarCliente.Show();
        }

        private void lançarTituloToolStripMenuItem_Click(object sender, EventArgs e)
        {
          LancarTitulo lancarTitulo = new LancarTitulo();
            lancarTitulo.MdiParent = this;
            lancarTitulo.Show();


        }

        private void alterarTituloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarTitulo alterarTitulo = new AlterarTitulo();
            alterarTitulo.MdiParent = this;
            alterarTitulo.Show();
        }

        private void receberTituloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LancarTituloRecebido lancarTituloRecebido = new LancarTituloRecebido();
            lancarTituloRecebido.MdiParent = this;
            lancarTituloRecebido.Show();
        }

        private void Financeiro_Load(object sender, EventArgs e)
        {

        }

        private void caminhoBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formconfiguracoes formconfiguracoes = new Formconfiguracoes();
            formconfiguracoes.MdiParent = this;
            formconfiguracoes.Show();
        }

        private void títulosAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TitulosAReceber titulosAReceber = new TitulosAReceber();
            titulosAReceber.MdiParent = this;
            titulosAReceber.Show();
        }
    }
}
