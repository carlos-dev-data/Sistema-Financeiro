namespace Sistema_Financeiro.Form_ContaReceber
{
    partial class AlterarTitulo
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
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Dtp_DataVencimento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Dtp_DataEmissao = new System.Windows.Forms.DateTimePicker();
            this.Txt_ValorAReceber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_IdCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_IDTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Cliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.BackColor = System.Drawing.Color.Yellow;
            this.Btn_Editar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Editar.Location = new System.Drawing.Point(258, 228);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(110, 37);
            this.Btn_Editar.TabIndex = 22;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.UseVisualStyleBackColor = false;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // Dtp_DataVencimento
            // 
            this.Dtp_DataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_DataVencimento.Location = new System.Drawing.Point(117, 225);
            this.Dtp_DataVencimento.Name = "Dtp_DataVencimento";
            this.Dtp_DataVencimento.Size = new System.Drawing.Size(96, 20);
            this.Dtp_DataVencimento.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(31, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Vencimento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(31, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Emissão";
            // 
            // Dtp_DataEmissao
            // 
            this.Dtp_DataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_DataEmissao.Location = new System.Drawing.Point(117, 186);
            this.Dtp_DataEmissao.Name = "Dtp_DataEmissao";
            this.Dtp_DataEmissao.Size = new System.Drawing.Size(96, 20);
            this.Dtp_DataEmissao.TabIndex = 18;
            // 
            // Txt_ValorAReceber
            // 
            this.Txt_ValorAReceber.Location = new System.Drawing.Point(118, 145);
            this.Txt_ValorAReceber.Name = "Txt_ValorAReceber";
            this.Txt_ValorAReceber.Size = new System.Drawing.Size(132, 20);
            this.Txt_ValorAReceber.TabIndex = 17;
            this.Txt_ValorAReceber.TextChanged += new System.EventHandler(this.Txt_ValorAReceber_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(31, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "A Receber";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cliente";
            // 
            // Txt_IdCliente
            // 
            this.Txt_IdCliente.Location = new System.Drawing.Point(118, 60);
            this.Txt_IdCliente.Name = "Txt_IdCliente";
            this.Txt_IdCliente.Size = new System.Drawing.Size(100, 20);
            this.Txt_IdCliente.TabIndex = 14;
            this.Txt_IdCliente.MouseLeave += new System.EventHandler(this.Txt_IdCliente_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cod Cliente";
            // 
            // Txt_IDTitulo
            // 
            this.Txt_IDTitulo.Location = new System.Drawing.Point(117, 22);
            this.Txt_IDTitulo.Name = "Txt_IDTitulo";
            this.Txt_IDTitulo.Size = new System.Drawing.Size(100, 20);
            this.Txt_IDTitulo.TabIndex = 24;
            this.Txt_IDTitulo.MouseLeave += new System.EventHandler(this.Txt_IDTitulo_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "IDTitulo";
            // 
            // Lbl_Cliente
            // 
            this.Lbl_Cliente.AutoSize = true;
            this.Lbl_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Lbl_Cliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cliente.ForeColor = System.Drawing.Color.Transparent;
            this.Lbl_Cliente.Location = new System.Drawing.Point(111, 106);
            this.Lbl_Cliente.Name = "Lbl_Cliente";
            this.Lbl_Cliente.Size = new System.Drawing.Size(113, 16);
            this.Lbl_Cliente.TabIndex = 25;
            this.Lbl_Cliente.Text = "Nome do Cliente";
            // 
            // AlterarTitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(397, 289);
            this.Controls.Add(this.Lbl_Cliente);
            this.Controls.Add(this.Txt_IDTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Dtp_DataVencimento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Dtp_DataEmissao);
            this.Controls.Add(this.Txt_ValorAReceber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_IdCliente);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AlterarTitulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Titulo";
            this.Load += new System.EventHandler(this.AlterarTitulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.DateTimePicker Dtp_DataVencimento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Dtp_DataEmissao;
        private System.Windows.Forms.TextBox Txt_ValorAReceber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_IdCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_IDTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Cliente;
    }
}