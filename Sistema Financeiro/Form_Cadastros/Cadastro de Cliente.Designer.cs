namespace Sistema_Financeiro.Formularios
{
    partial class Cadastro_de_Cliente
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
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Txt_NomeCompleto = new System.Windows.Forms.TextBox();
            this.Lbl_Telefone = new System.Windows.Forms.Label();
            this.Msk_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHeaderTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.BackColor = System.Drawing.Color.White;
            this.Lbl_Nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nome.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Nome.Location = new System.Drawing.Point(25, 88);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(50, 18);
            this.Lbl_Nome.TabIndex = 0;
            this.Lbl_Nome.Text = "Nome";
            // 
            // Txt_NomeCompleto
            // 
            this.Txt_NomeCompleto.Location = new System.Drawing.Point(82, 88);
            this.Txt_NomeCompleto.Name = "Txt_NomeCompleto";
            this.Txt_NomeCompleto.Size = new System.Drawing.Size(313, 20);
            this.Txt_NomeCompleto.TabIndex = 1;
            // 
            // Lbl_Telefone
            // 
            this.Lbl_Telefone.AutoSize = true;
            this.Lbl_Telefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Telefone.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Telefone.Location = new System.Drawing.Point(13, 71);
            this.Lbl_Telefone.Name = "Lbl_Telefone";
            this.Lbl_Telefone.Size = new System.Drawing.Size(66, 18);
            this.Lbl_Telefone.TabIndex = 2;
            this.Lbl_Telefone.Text = "Telefone";
            // 
            // Msk_Telefone
            // 
            this.Msk_Telefone.Location = new System.Drawing.Point(93, 71);
            this.Msk_Telefone.Mask = "(00) 00000-0000";
            this.Msk_Telefone.Name = "Msk_Telefone";
            this.Msk_Telefone.Size = new System.Drawing.Size(103, 22);
            this.Msk_Telefone.TabIndex = 3;
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.BackColor = System.Drawing.Color.RoyalBlue;
            this.Btn_Salvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salvar.ForeColor = System.Drawing.Color.White;
            this.Btn_Salvar.Location = new System.Drawing.Point(286, 183);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(116, 35);
            this.Btn_Salvar.TabIndex = 4;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = false;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblHeaderTitulo);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 39);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.Msk_Telefone);
            this.groupBox1.Controls.Add(this.Lbl_Telefone);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 124);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // lblHeaderTitulo
            // 
            this.lblHeaderTitulo.AutoSize = true;
            this.lblHeaderTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTitulo.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitulo.Location = new System.Drawing.Point(24, 9);
            this.lblHeaderTitulo.Name = "lblHeaderTitulo";
            this.lblHeaderTitulo.Size = new System.Drawing.Size(159, 19);
            this.lblHeaderTitulo.TabIndex = 7;
            this.lblHeaderTitulo.Text = "Cadastro de Cliente";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(375, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(26, 20);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel3.Location = new System.Drawing.Point(343, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(26, 20);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(311, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(26, 20);
            this.panel4.TabIndex = 9;
            // 
            // Cadastro_de_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(414, 228);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.Txt_NomeCompleto);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Cadastro_de_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.Cadastro_de_Cliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.TextBox Txt_NomeCompleto;
        private System.Windows.Forms.Label Lbl_Telefone;
        private System.Windows.Forms.MaskedTextBox Msk_Telefone;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHeaderTitulo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}