namespace Sistema_Financeiro.Form_Cadastros
{
    partial class EditarCliente
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
            this.Msk_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Telefone = new System.Windows.Forms.Label();
            this.Txt_NomeCompleto = new System.Windows.Forms.TextBox();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Msk_Telefone
            // 
            this.Msk_Telefone.Location = new System.Drawing.Point(88, 127);
            this.Msk_Telefone.Mask = "(00) 00000-0000";
            this.Msk_Telefone.Name = "Msk_Telefone";
            this.Msk_Telefone.Size = new System.Drawing.Size(103, 20);
            this.Msk_Telefone.TabIndex = 7;
            // 
            // Lbl_Telefone
            // 
            this.Lbl_Telefone.AutoSize = true;
            this.Lbl_Telefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Telefone.ForeColor = System.Drawing.Color.White;
            this.Lbl_Telefone.Location = new System.Drawing.Point(10, 129);
            this.Lbl_Telefone.Name = "Lbl_Telefone";
            this.Lbl_Telefone.Size = new System.Drawing.Size(74, 19);
            this.Lbl_Telefone.TabIndex = 6;
            this.Lbl_Telefone.Text = "Telefone";
            // 
            // Txt_NomeCompleto
            // 
            this.Txt_NomeCompleto.Location = new System.Drawing.Point(87, 78);
            this.Txt_NomeCompleto.Name = "Txt_NomeCompleto";
            this.Txt_NomeCompleto.Size = new System.Drawing.Size(325, 20);
            this.Txt_NomeCompleto.TabIndex = 5;
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nome.ForeColor = System.Drawing.Color.White;
            this.Lbl_Nome.Location = new System.Drawing.Point(10, 78);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(54, 19);
            this.Lbl_Nome.TabIndex = 4;
            this.Lbl_Nome.Text = "Nome";
            // 
            // Lbl_Id
            // 
            this.Lbl_Id.AutoSize = true;
            this.Lbl_Id.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id.ForeColor = System.Drawing.Color.White;
            this.Lbl_Id.Location = new System.Drawing.Point(12, 32);
            this.Lbl_Id.Name = "Lbl_Id";
            this.Lbl_Id.Size = new System.Drawing.Size(65, 19);
            this.Lbl_Id.TabIndex = 8;
            this.Lbl_Id.Text = "Codigo";
            // 
            // Txt_Id
            // 
            this.Txt_Id.Location = new System.Drawing.Point(87, 33);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Size = new System.Drawing.Size(103, 20);
            this.Txt_Id.TabIndex = 9;
            this.Txt_Id.MouseLeave += new System.EventHandler(this.Txt_Id_MouseLeave);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.BackColor = System.Drawing.Color.Yellow;
            this.Btn_Editar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Editar.Location = new System.Drawing.Point(146, 178);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(116, 35);
            this.Btn_Editar.TabIndex = 10;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.UseVisualStyleBackColor = false;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // EditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(417, 225);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Txt_Id);
            this.Controls.Add(this.Lbl_Id);
            this.Controls.Add(this.Msk_Telefone);
            this.Controls.Add(this.Lbl_Telefone);
            this.Controls.Add(this.Txt_NomeCompleto);
            this.Controls.Add(this.Lbl_Nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Cliente";
            this.Load += new System.EventHandler(this.EditarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Msk_Telefone;
        private System.Windows.Forms.Label Lbl_Telefone;
        private System.Windows.Forms.TextBox Txt_NomeCompleto;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Label Lbl_Id;
        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.Button Btn_Editar;
    }
}