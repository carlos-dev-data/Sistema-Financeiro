using Sistema_Financeiro.Conexao;
using Sistema_Financeiro.Form_Cadastros;
using Sistema_Financeiro.Form_ContaReceber;
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
            cadastroCliente.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Relatorios.Rel_Clientes relClientes = new Form_Relatorios.Rel_Clientes();
            relClientes.Show();
        }

        private void editarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarCliente editarCliente = new EditarCliente();
            editarCliente.Show();
        }

        private void lançarTituloToolStripMenuItem_Click(object sender, EventArgs e)
        {
          LancarTitulo lancarTitulo = new LancarTitulo();
            lancarTitulo.Show();


        }

        private void alterarTituloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarTitulo alterarTitulo = new AlterarTitulo();
            alterarTitulo.Show();
        }

        private void receberTituloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LancarTituloRecebido lancarTituloRecebido = new LancarTituloRecebido();
            lancarTituloRecebido.Show();
        }
    }
}
