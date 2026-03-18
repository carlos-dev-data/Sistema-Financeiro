namespace Sistema_Financeiro
{
    partial class Financeiro
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepCad = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lançarTituloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarTituloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receberTituloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estornarTituloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.títulosAReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caminhoBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlStatusBar = new System.Windows.Forms.Panel();
            this.lblStatusInfo = new System.Windows.Forms.Label();
            this.lblStatusVersao = new System.Windows.Forms.Label();

            this.menuStrip1.SuspendLayout();
            this.pnlStatusBar.SuspendLayout();
            this.SuspendLayout();

            // ── menuStrip1 ───────────────────────────────────────────
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.menuStrip1.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Height = 38;
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.cadastrosToolStripMenuItem,
                this.titToolStripMenuItem,
                this.relatorioToolStripMenuItem,
                this.configuraçãoToolStripMenuItem
            });

            // ── Cadastros ─────────────────────────────────────────────
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cadastrosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.cadastrosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.cadastrosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(95, 38);
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.clienteToolStripMenuItem,
                this.editarClienteToolStripMenuItem,
                this.sepCad,
                this.sairToolStripMenuItem
            });

            this.clienteToolStripMenuItem.Text = "  Cadastrar Cliente";
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.clienteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.clienteToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.clienteToolStripMenuItem.Padding = new System.Windows.Forms.Padding(12, 4, 20, 4);
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);

            this.editarClienteToolStripMenuItem.Text = "  Editar Cliente";
            this.editarClienteToolStripMenuItem.Name = "editarClienteToolStripMenuItem";
            this.editarClienteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.editarClienteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.editarClienteToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.editarClienteToolStripMenuItem.Padding = new System.Windows.Forms.Padding(12, 4, 20, 4);
            this.editarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarClienteToolStripMenuItem.Click += new System.EventHandler(this.editarClienteToolStripMenuItem_Click);

            this.sepCad.Name = "sepCad";

            this.sairToolStripMenuItem.Text = "  Sair do Sistema";
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.sairToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.sairToolStripMenuItem.Padding = new System.Windows.Forms.Padding(12, 4, 20, 4);
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);

            // ── Contas a Receber ──────────────────────────────────────
            this.titToolStripMenuItem.Text = "Contas a Receber";
            this.titToolStripMenuItem.Name = "titToolStripMenuItem";
            this.titToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.titToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.titToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.titToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.titToolStripMenuItem.Size = new System.Drawing.Size(160, 38);
            this.titToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.lançarTituloToolStripMenuItem,
                this.alterarTituloToolStripMenuItem,
                this.receberTituloToolStripMenuItem,
                this.estornarTituloToolStripMenuItem
            });

            this.lançarTituloToolStripMenuItem.Text = "  Lançar Título";
            this.lançarTituloToolStripMenuItem.Name = "lançarTituloToolStripMenuItem";
            this.lançarTituloToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lançarTituloToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lançarTituloToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.lançarTituloToolStripMenuItem.Padding = new System.Windows.Forms.Padding(12, 4, 20, 4);
            this.lançarTituloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lançarTituloToolStripMenuItem.Click += new System.EventHandler(this.lançarTituloToolStripMenuItem_Click);

            this.alterarTituloToolStripMenuItem.Text = "  Alterar Título";
            this.alterarTituloToolStripMenuItem.Name = "alterarTituloToolStripMenuItem";
            this.alterarTituloToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.alterarTituloToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.alterarTituloToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.alterarTituloToolStripMenuItem.Padding = new System.Windows.Forms.Padding(12, 4, 20, 4);
            this.alterarTituloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alterarTituloToolStripMenuItem.Click += new System.EventHandler(this.alterarTituloToolStripMenuItem_Click);

            this.receberTituloToolStripMenuItem.Text = "  Receber Título";
            this.receberTituloToolStripMenuItem.Name = "receberTituloToolStripMenuItem";
            this.receberTituloToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.receberTituloToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(21, 128, 61);
            this.receberTituloToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.receberTituloToolStripMenuItem.Padding = new System.Windows.Forms.Padding(12, 4, 20, 4);
            this.receberTituloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.receberTituloToolStripMenuItem.Click += new System.EventHandler(this.receberTituloToolStripMenuItem_Click);

            this.estornarTituloToolStripMenuItem.Text = "  Estornar Pagamento";
            this.estornarTituloToolStripMenuItem.Name = "estornarTituloToolStripMenuItem";
            this.estornarTituloToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.estornarTituloToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.estornarTituloToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.estornarTituloToolStripMenuItem.Padding = new System.Windows.Forms.Padding(12, 4, 20, 4);
            this.estornarTituloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estornarTituloToolStripMenuItem.Click += new System.EventHandler(this.estornarTituloToolStripMenuItem_Click);

            // ── Relatórios ────────────────────────────────────────────
            this.relatorioToolStripMenuItem.Text = "Relatórios";
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.relatorioToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.relatorioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.relatorioToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(95, 38);
            this.relatorioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.clientesToolStripMenuItem,
                this.títulosAReceberToolStripMenuItem
            });

            this.clientesToolStripMenuItem.Text = "  Clientes";
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.clientesToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.clientesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(12, 4, 20, 4);
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);

            this.títulosAReceberToolStripMenuItem.Text = "  Títulos a Receber";
            this.títulosAReceberToolStripMenuItem.Name = "títulosAReceberToolStripMenuItem";
            this.títulosAReceberToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.títulosAReceberToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.títulosAReceberToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.títulosAReceberToolStripMenuItem.Padding = new System.Windows.Forms.Padding(12, 4, 20, 4);
            this.títulosAReceberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.títulosAReceberToolStripMenuItem.Click += new System.EventHandler(this.títulosAReceberToolStripMenuItem_Click);

            // ── Configurações ─────────────────────────────────────────
            this.configuraçãoToolStripMenuItem.Text = "Configurações";
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.configuraçãoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.configuraçãoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.configuraçãoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(115, 38);
            this.configuraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.caminhoBaseToolStripMenuItem
            });

            this.caminhoBaseToolStripMenuItem.Text = "  Caminho da Base";
            this.caminhoBaseToolStripMenuItem.Name = "caminhoBaseToolStripMenuItem";
            this.caminhoBaseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.caminhoBaseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.caminhoBaseToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.caminhoBaseToolStripMenuItem.Padding = new System.Windows.Forms.Padding(12, 4, 20, 4);
            this.caminhoBaseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.caminhoBaseToolStripMenuItem.Click += new System.EventHandler(this.caminhoBaseToolStripMenuItem_Click);

            // ── pnlStatusBar ──────────────────────────────────────────
            this.pnlStatusBar.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.pnlStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatusBar.Height = 28;
            this.pnlStatusBar.Name = "pnlStatusBar";
            this.pnlStatusBar.Controls.Add(this.lblStatusVersao);
            this.pnlStatusBar.Controls.Add(this.lblStatusInfo);

            this.lblStatusInfo.AutoSize = true;
            this.lblStatusInfo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStatusInfo.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblStatusInfo.Location = new System.Drawing.Point(12, 7);
            this.lblStatusInfo.Name = "lblStatusInfo";
            this.lblStatusInfo.Text = "Sistema Financeiro";

            this.lblStatusVersao.AutoSize = true;
            this.lblStatusVersao.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStatusVersao.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblStatusVersao.Location = new System.Drawing.Point(940, 7);
            this.lblStatusVersao.Name = "lblStatusVersao";
            this.lblStatusVersao.Text = "v2.0";
            this.lblStatusVersao.Anchor = System.Windows.Forms.AnchorStyles.Right |
                                             System.Windows.Forms.AnchorStyles.Bottom;

            // ── Form ──────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Financeiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Financeiro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlStatusBar);

            this.Load += new System.EventHandler(this.Financeiro_Load);

            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlStatusBar.ResumeLayout(false);
            this.pnlStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator sepCad;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lançarTituloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarTituloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receberTituloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estornarTituloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem títulosAReceberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caminhoBaseToolStripMenuItem;
        private System.Windows.Forms.Panel pnlStatusBar;
        private System.Windows.Forms.Label lblStatusInfo;
        private System.Windows.Forms.Label lblStatusVersao;
    }
}