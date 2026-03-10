namespace Sistema_Financeiro
{
    partial class Financeiro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Financeiro));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lançarTituloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarTituloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receberTituloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caminhoBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.titToolStripMenuItem,
            this.relatorioToolStripMenuItem,
            this.configuraçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(10, 50, 0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(800, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.BackColor = System.Drawing.Color.Blue;
            this.cadastrosToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cadastrosToolStripMenuItem.BackgroundImage")));
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.editarClienteToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cadastrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrosToolStripMenuItem.Image")));
            this.cadastrosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cadastrosToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(142, 28);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.clienteToolStripMenuItem.Text = "Cadastrar Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // editarClienteToolStripMenuItem
            // 
            this.editarClienteToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarClienteToolStripMenuItem.Name = "editarClienteToolStripMenuItem";
            this.editarClienteToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.editarClienteToolStripMenuItem.Text = "Editar Cliente";
            this.editarClienteToolStripMenuItem.Click += new System.EventHandler(this.editarClienteToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // titToolStripMenuItem
            // 
            this.titToolStripMenuItem.BackColor = System.Drawing.Color.Blue;
            this.titToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lançarTituloToolStripMenuItem,
            this.alterarTituloToolStripMenuItem,
            this.receberTituloToolStripMenuItem});
            this.titToolStripMenuItem.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.titToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("titToolStripMenuItem.Image")));
            this.titToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.titToolStripMenuItem.Name = "titToolStripMenuItem";
            this.titToolStripMenuItem.Size = new System.Drawing.Size(218, 28);
            this.titToolStripMenuItem.Text = "Contas a Receber";
            // 
            // lançarTituloToolStripMenuItem
            // 
            this.lançarTituloToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lançarTituloToolStripMenuItem.Name = "lançarTituloToolStripMenuItem";
            this.lançarTituloToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.lançarTituloToolStripMenuItem.Text = "Lançar Titulo";
            this.lançarTituloToolStripMenuItem.Click += new System.EventHandler(this.lançarTituloToolStripMenuItem_Click);
            // 
            // alterarTituloToolStripMenuItem
            // 
            this.alterarTituloToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarTituloToolStripMenuItem.Name = "alterarTituloToolStripMenuItem";
            this.alterarTituloToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.alterarTituloToolStripMenuItem.Text = "Alterar Titulo";
            this.alterarTituloToolStripMenuItem.Click += new System.EventHandler(this.alterarTituloToolStripMenuItem_Click);
            // 
            // receberTituloToolStripMenuItem
            // 
            this.receberTituloToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receberTituloToolStripMenuItem.Name = "receberTituloToolStripMenuItem";
            this.receberTituloToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.receberTituloToolStripMenuItem.Text = "Receber Titulo";
            this.receberTituloToolStripMenuItem.Click += new System.EventHandler(this.receberTituloToolStripMenuItem_Click);
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.BackColor = System.Drawing.Color.Blue;
            this.relatorioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.relatorioToolStripMenuItem.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatorioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.relatorioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("relatorioToolStripMenuItem.Image")));
            this.relatorioToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.relatorioToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(128, 28);
            this.relatorioToolStripMenuItem.Text = "Relatorio";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caminhoBaseToolStripMenuItem});
            this.configuraçãoToolStripMenuItem.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuraçãoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(158, 28);
            this.configuraçãoToolStripMenuItem.Text = "Configuração";
            // 
            // caminhoBaseToolStripMenuItem
            // 
            this.caminhoBaseToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caminhoBaseToolStripMenuItem.Name = "caminhoBaseToolStripMenuItem";
            this.caminhoBaseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.caminhoBaseToolStripMenuItem.Text = "Caminho Base";
            this.caminhoBaseToolStripMenuItem.Click += new System.EventHandler(this.caminhoBaseToolStripMenuItem_Click);
            // 
            // Financeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Financeiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Financeiro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Financeiro_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lançarTituloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receberTituloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarTituloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caminhoBaseToolStripMenuItem;
    }
}

