namespace Sistema_Financeiro.Configuracao
{
    partial class Formconfiguracoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.paneltopo = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelCorpo = new System.Windows.Forms.Panel();
            this.grpContaReceber = new System.Windows.Forms.GroupBox();
            this.lblStatusContaReceber = new System.Windows.Forms.Label();
            this.btnCriarContaReceber = new System.Windows.Forms.Button();
            this.btnProcurarContaReceber = new System.Windows.Forms.Button();
            this.lblCaminhoContaReceber = new System.Windows.Forms.Label();
            this.txtCaminhoContaReceber = new System.Windows.Forms.TextBox();
            this.grpClientes = new System.Windows.Forms.GroupBox();
            this.lblStatusClientes = new System.Windows.Forms.Label();
            this.btnCriarClientes = new System.Windows.Forms.Button();
            this.btnProcurarClientes = new System.Windows.Forms.Button();
            this.lblCaminhoClientes = new System.Windows.Forms.Label();
            this.txtCaminhoClientes = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.paneltopo.SuspendLayout();
            this.panelCorpo.SuspendLayout();
            this.grpContaReceber.SuspendLayout();
            this.grpClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltopo
            // 
            this.paneltopo.BackColor = System.Drawing.Color.RoyalBlue;
            this.paneltopo.Controls.Add(this.lblSubtitulo);
            this.paneltopo.Controls.Add(this.lblTitulo);
            this.paneltopo.Location = new System.Drawing.Point(1, 1);
            this.paneltopo.Name = "paneltopo";
            this.paneltopo.Size = new System.Drawing.Size(799, 68);
            this.paneltopo.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubtitulo.Location = new System.Drawing.Point(13, 39);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(312, 15);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Defina os caminhos dos arquivos de dados do sistema";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(11, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(320, 27);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "🔧 Configurações do Sistema";
            // 
            // panelCorpo
            // 
            this.panelCorpo.BackColor = System.Drawing.Color.White;
            this.panelCorpo.Controls.Add(this.grpContaReceber);
            this.panelCorpo.Controls.Add(this.grpClientes);
            this.panelCorpo.Location = new System.Drawing.Point(1, 70);
            this.panelCorpo.Name = "panelCorpo";
            this.panelCorpo.Size = new System.Drawing.Size(799, 309);
            this.panelCorpo.TabIndex = 1;
            // 
            // grpContaReceber
            // 
            this.grpContaReceber.Controls.Add(this.lblStatusContaReceber);
            this.grpContaReceber.Controls.Add(this.btnCriarContaReceber);
            this.grpContaReceber.Controls.Add(this.btnProcurarContaReceber);
            this.grpContaReceber.Controls.Add(this.lblCaminhoContaReceber);
            this.grpContaReceber.Controls.Add(this.txtCaminhoContaReceber);
            this.grpContaReceber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContaReceber.ForeColor = System.Drawing.Color.RoyalBlue;
            this.grpContaReceber.Location = new System.Drawing.Point(16, 160);
            this.grpContaReceber.Name = "grpContaReceber";
            this.grpContaReceber.Size = new System.Drawing.Size(757, 128);
            this.grpContaReceber.TabIndex = 1;
            this.grpContaReceber.TabStop = false;
            this.grpContaReceber.Text = "🗂️ Arquivo de Contas a Receber";
            // 
            // lblStatusContaReceber
            // 
            this.lblStatusContaReceber.AutoSize = true;
            this.lblStatusContaReceber.Location = new System.Drawing.Point(6, 106);
            this.lblStatusContaReceber.Name = "lblStatusContaReceber";
            this.lblStatusContaReceber.Size = new System.Drawing.Size(0, 16);
            this.lblStatusContaReceber.TabIndex = 8;
            // 
            // btnCriarContaReceber
            // 
            this.btnCriarContaReceber.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCriarContaReceber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarContaReceber.ForeColor = System.Drawing.Color.White;
            this.btnCriarContaReceber.Location = new System.Drawing.Point(641, 75);
            this.btnCriarContaReceber.Name = "btnCriarContaReceber";
            this.btnCriarContaReceber.Size = new System.Drawing.Size(105, 40);
            this.btnCriarContaReceber.TabIndex = 7;
            this.btnCriarContaReceber.Text = "Criar Arquivo";
            this.btnCriarContaReceber.UseVisualStyleBackColor = false;
            this.btnCriarContaReceber.Click += new System.EventHandler(this.btnCriarContaReceber_Click);
            // 
            // btnProcurarContaReceber
            // 
            this.btnProcurarContaReceber.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnProcurarContaReceber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurarContaReceber.ForeColor = System.Drawing.Color.White;
            this.btnProcurarContaReceber.Location = new System.Drawing.Point(641, 29);
            this.btnProcurarContaReceber.Name = "btnProcurarContaReceber";
            this.btnProcurarContaReceber.Size = new System.Drawing.Size(105, 40);
            this.btnProcurarContaReceber.TabIndex = 6;
            this.btnProcurarContaReceber.Text = "Procurar";
            this.btnProcurarContaReceber.UseVisualStyleBackColor = false;
            this.btnProcurarContaReceber.Click += new System.EventHandler(this.btnProcurarContaReceber_Click);
            // 
            // lblCaminhoContaReceber
            // 
            this.lblCaminhoContaReceber.AutoSize = true;
            this.lblCaminhoContaReceber.ForeColor = System.Drawing.Color.SlateGray;
            this.lblCaminhoContaReceber.Location = new System.Drawing.Point(16, 41);
            this.lblCaminhoContaReceber.Name = "lblCaminhoContaReceber";
            this.lblCaminhoContaReceber.Size = new System.Drawing.Size(263, 16);
            this.lblCaminhoContaReceber.TabIndex = 2;
            this.lblCaminhoContaReceber.Text = "Caminho do arquivo ContaReceber.json:";
            // 
            // txtCaminhoContaReceber
            // 
            this.txtCaminhoContaReceber.Location = new System.Drawing.Point(19, 60);
            this.txtCaminhoContaReceber.Name = "txtCaminhoContaReceber";
            this.txtCaminhoContaReceber.Size = new System.Drawing.Size(616, 22);
            this.txtCaminhoContaReceber.TabIndex = 1;
            this.txtCaminhoContaReceber.TextChanged += new System.EventHandler(this.txtCaminhoContaReceber_TextChanged);
            // 
            // grpClientes
            // 
            this.grpClientes.Controls.Add(this.lblStatusClientes);
            this.grpClientes.Controls.Add(this.btnCriarClientes);
            this.grpClientes.Controls.Add(this.btnProcurarClientes);
            this.grpClientes.Controls.Add(this.lblCaminhoClientes);
            this.grpClientes.Controls.Add(this.txtCaminhoClientes);
            this.grpClientes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpClientes.ForeColor = System.Drawing.Color.RoyalBlue;
            this.grpClientes.Location = new System.Drawing.Point(16, 16);
            this.grpClientes.Name = "grpClientes";
            this.grpClientes.Size = new System.Drawing.Size(757, 128);
            this.grpClientes.TabIndex = 0;
            this.grpClientes.TabStop = false;
            this.grpClientes.Text = "🗂️ Arquivo de Clientes";
            // 
            // lblStatusClientes
            // 
            this.lblStatusClientes.AutoSize = true;
            this.lblStatusClientes.Location = new System.Drawing.Point(6, 105);
            this.lblStatusClientes.Name = "lblStatusClientes";
            this.lblStatusClientes.Size = new System.Drawing.Size(0, 16);
            this.lblStatusClientes.TabIndex = 6;
            // 
            // btnCriarClientes
            // 
            this.btnCriarClientes.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCriarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarClientes.ForeColor = System.Drawing.Color.White;
            this.btnCriarClientes.Location = new System.Drawing.Point(641, 80);
            this.btnCriarClientes.Name = "btnCriarClientes";
            this.btnCriarClientes.Size = new System.Drawing.Size(105, 40);
            this.btnCriarClientes.TabIndex = 5;
            this.btnCriarClientes.Text = "Criar Arquivo";
            this.btnCriarClientes.UseVisualStyleBackColor = false;
            this.btnCriarClientes.Click += new System.EventHandler(this.btnCriarClientes_Click);
            // 
            // btnProcurarClientes
            // 
            this.btnProcurarClientes.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnProcurarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurarClientes.ForeColor = System.Drawing.Color.White;
            this.btnProcurarClientes.Location = new System.Drawing.Point(641, 34);
            this.btnProcurarClientes.Name = "btnProcurarClientes";
            this.btnProcurarClientes.Size = new System.Drawing.Size(105, 40);
            this.btnProcurarClientes.TabIndex = 4;
            this.btnProcurarClientes.Text = "Procurar";
            this.btnProcurarClientes.UseVisualStyleBackColor = false;
            this.btnProcurarClientes.Click += new System.EventHandler(this.btnProcurarClientes_Click);
            // 
            // lblCaminhoClientes
            // 
            this.lblCaminhoClientes.AutoSize = true;
            this.lblCaminhoClientes.ForeColor = System.Drawing.Color.SlateGray;
            this.lblCaminhoClientes.Location = new System.Drawing.Point(16, 34);
            this.lblCaminhoClientes.Name = "lblCaminhoClientes";
            this.lblCaminhoClientes.Size = new System.Drawing.Size(219, 16);
            this.lblCaminhoClientes.TabIndex = 1;
            this.lblCaminhoClientes.Text = "Caminho do arquivo Cliente.json:";
            // 
            // txtCaminhoClientes
            // 
            this.txtCaminhoClientes.Location = new System.Drawing.Point(19, 53);
            this.txtCaminhoClientes.Name = "txtCaminhoClientes";
            this.txtCaminhoClientes.Size = new System.Drawing.Size(616, 22);
            this.txtCaminhoClientes.TabIndex = 0;
            this.txtCaminhoClientes.TextChanged += new System.EventHandler(this.txtCaminhoClientes_TextChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(678, 397);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 41);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "✅ Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(542, 397);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 41);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "❌ Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Formconfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.panelCorpo);
            this.Controls.Add(this.paneltopo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Formconfiguracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações - Sistema Financeiro";
            this.Load += new System.EventHandler(this.Formconfiguracoes_Load);
            this.paneltopo.ResumeLayout(false);
            this.paneltopo.PerformLayout();
            this.panelCorpo.ResumeLayout(false);
            this.grpContaReceber.ResumeLayout(false);
            this.grpContaReceber.PerformLayout();
            this.grpClientes.ResumeLayout(false);
            this.grpClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel panelCorpo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpContaReceber;
        private System.Windows.Forms.GroupBox grpClientes;
        private System.Windows.Forms.TextBox txtCaminhoClientes;
        private System.Windows.Forms.TextBox txtCaminhoContaReceber;
        private System.Windows.Forms.Label lblCaminhoContaReceber;
        private System.Windows.Forms.Label lblCaminhoClientes;
        private System.Windows.Forms.Label lblStatusContaReceber;
        private System.Windows.Forms.Button btnCriarContaReceber;
        private System.Windows.Forms.Button btnProcurarContaReceber;
        private System.Windows.Forms.Label lblStatusClientes;
        private System.Windows.Forms.Button btnCriarClientes;
        private System.Windows.Forms.Button btnProcurarClientes;
    }
}