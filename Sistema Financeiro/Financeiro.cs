using Sistema_Financeiro.Configuracao;
using Sistema_Financeiro.Form_Cadastros;
using Sistema_Financeiro.Form_ContaReceber;
using Sistema_Financeiro.Form_Relatorios;
using Sistema_Financeiro.Formularios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema_Financeiro
{
    public partial class Financeiro : Form
    {
        public Financeiro()
        {
            InitializeComponent();
        }

        private void Financeiro_Load(object sender, EventArgs e)
        {
            lblStatusInfo.Text = "Sistema Financeiro  •  " + DateTime.Now.ToString("dd/MM/yyyy");

            // Hover nos itens do menu principal
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.MouseEnter += MenuItem_MouseEnter;
                item.MouseLeave += MenuItem_MouseLeave;
            }

            // Abre o Dashboard ao iniciar maximizado
            Dashboard dashboard = new Dashboard();
            dashboard.MdiParent = this;
            dashboard.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            dashboard.Show();
        }

        private void MenuItem_MouseEnter(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).ForeColor = Color.White;
        }

        private void MenuItem_MouseLeave(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).ForeColor = Color.FromArgb(203, 213, 225);
        }

        // ── Cadastros ─────────────────────────────────────────────────
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirMdi(new Cadastro_de_Cliente());
        }

        private void editarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirMdi(new EditarCliente());
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do sistema?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        // ── Contas a Receber ──────────────────────────────────────────
        private void lançarTituloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirMdi(new LancarTitulo());
        }

        private void alterarTituloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirMdi(new AlterarTitulo());
        }

        private void receberTituloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirMdi(new LancarTituloRecebido());
        }

        private void estornarTituloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirMdi(new EstornarTitulo());
        }

        // ── Relatórios ────────────────────────────────────────────────
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirMdi(new Rel_Clientes());
        }

        private void títulosAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirMdi(new TitulosAReceber());
        }

        // ── Configurações ─────────────────────────────────────────────
        private void caminhoBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirMdi(new Formconfiguracoes());
        }

        // ── Helper — abre como janela flutuante independente ──────────
        private void AbrirMdi(Form form)
        {
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.Show();
        }
    }
}