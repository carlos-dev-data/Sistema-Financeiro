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
            this.SuspendLayout();
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nome.ForeColor = System.Drawing.Color.White;
            this.Lbl_Nome.Location = new System.Drawing.Point(5, 65);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(54, 19);
            this.Lbl_Nome.TabIndex = 0;
            this.Lbl_Nome.Text = "Nome";
            // 
            // Txt_NomeCompleto
            // 
            this.Txt_NomeCompleto.Location = new System.Drawing.Point(79, 65);
            this.Txt_NomeCompleto.Name = "Txt_NomeCompleto";
            this.Txt_NomeCompleto.Size = new System.Drawing.Size(313, 20);
            this.Txt_NomeCompleto.TabIndex = 1;
            // 
            // Lbl_Telefone
            // 
            this.Lbl_Telefone.AutoSize = true;
            this.Lbl_Telefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Telefone.ForeColor = System.Drawing.Color.White;
            this.Lbl_Telefone.Location = new System.Drawing.Point(5, 116);
            this.Lbl_Telefone.Name = "Lbl_Telefone";
            this.Lbl_Telefone.Size = new System.Drawing.Size(74, 19);
            this.Lbl_Telefone.TabIndex = 2;
            this.Lbl_Telefone.Text = "Telefone";
            // 
            // Msk_Telefone
            // 
            this.Msk_Telefone.Location = new System.Drawing.Point(81, 114);
            this.Msk_Telefone.Mask = "(00) 00000-0000";
            this.Msk_Telefone.Name = "Msk_Telefone";
            this.Msk_Telefone.Size = new System.Drawing.Size(103, 20);
            this.Msk_Telefone.TabIndex = 3;
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.BackColor = System.Drawing.Color.Yellow;
            this.Btn_Salvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salvar.Location = new System.Drawing.Point(146, 198);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(116, 35);
            this.Btn_Salvar.TabIndex = 4;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = false;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Cadastro_de_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(414, 245);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.Msk_Telefone);
            this.Controls.Add(this.Lbl_Telefone);
            this.Controls.Add(this.Txt_NomeCompleto);
            this.Controls.Add(this.Lbl_Nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Cadastro_de_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.Cadastro_de_Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.TextBox Txt_NomeCompleto;
        private System.Windows.Forms.Label Lbl_Telefone;
        private System.Windows.Forms.MaskedTextBox Msk_Telefone;
        private System.Windows.Forms.Button Btn_Salvar;
    }
}