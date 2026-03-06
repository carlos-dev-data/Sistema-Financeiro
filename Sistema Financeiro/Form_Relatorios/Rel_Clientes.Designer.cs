namespace Sistema_Financeiro.Form_Relatorios
{
    partial class Rel_Clientes
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
            this.Dtw_Tabela = new System.Windows.Forms.DataGridView();
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Lbl_Telefone = new System.Windows.Forms.Label();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.Txt_NomeCliente = new System.Windows.Forms.TextBox();
            this.Msk_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dtw_Tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // Dtw_Tabela
            // 
            this.Dtw_Tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtw_Tabela.Location = new System.Drawing.Point(2, 114);
            this.Dtw_Tabela.Name = "Dtw_Tabela";
            this.Dtw_Tabela.Size = new System.Drawing.Size(480, 334);
            this.Dtw_Tabela.TabIndex = 0;
            // 
            // Lbl_Id
            // 
            this.Lbl_Id.AutoSize = true;
            this.Lbl_Id.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Id.Name = "Lbl_Id";
            this.Lbl_Id.Size = new System.Drawing.Size(89, 15);
            this.Lbl_Id.TabIndex = 1;
            this.Lbl_Id.Text = "Codigo Interno";
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nome.Location = new System.Drawing.Point(12, 44);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(99, 15);
            this.Lbl_Nome.TabIndex = 2;
            this.Lbl_Nome.Text = "Nome do Cliente";
            // 
            // Lbl_Telefone
            // 
            this.Lbl_Telefone.AutoSize = true;
            this.Lbl_Telefone.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Telefone.Location = new System.Drawing.Point(12, 81);
            this.Lbl_Telefone.Name = "Lbl_Telefone";
            this.Lbl_Telefone.Size = new System.Drawing.Size(55, 15);
            this.Lbl_Telefone.TabIndex = 3;
            this.Lbl_Telefone.Text = "Telefone";
            // 
            // Txt_Id
            // 
            this.Txt_Id.Location = new System.Drawing.Point(119, 7);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Size = new System.Drawing.Size(91, 20);
            this.Txt_Id.TabIndex = 4;
            // 
            // Txt_NomeCliente
            // 
            this.Txt_NomeCliente.Location = new System.Drawing.Point(119, 39);
            this.Txt_NomeCliente.Name = "Txt_NomeCliente";
            this.Txt_NomeCliente.Size = new System.Drawing.Size(181, 20);
            this.Txt_NomeCliente.TabIndex = 5;
            // 
            // Msk_Telefone
            // 
            this.Msk_Telefone.Location = new System.Drawing.Point(119, 81);
            this.Msk_Telefone.Mask = "(00) 00000-0000";
            this.Msk_Telefone.Name = "Msk_Telefone";
            this.Msk_Telefone.Size = new System.Drawing.Size(103, 20);
            this.Msk_Telefone.TabIndex = 6;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.Location = new System.Drawing.Point(358, 37);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(109, 39);
            this.Btn_Buscar.TabIndex = 7;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Rel_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Msk_Telefone);
            this.Controls.Add(this.Txt_NomeCliente);
            this.Controls.Add(this.Txt_Id);
            this.Controls.Add(this.Lbl_Telefone);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.Lbl_Id);
            this.Controls.Add(this.Dtw_Tabela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Rel_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.Dtw_Tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dtw_Tabela;
        private System.Windows.Forms.Label Lbl_Id;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Label Lbl_Telefone;
        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.TextBox Txt_NomeCliente;
        private System.Windows.Forms.MaskedTextBox Msk_Telefone;
        private System.Windows.Forms.Button Btn_Buscar;
    }
}