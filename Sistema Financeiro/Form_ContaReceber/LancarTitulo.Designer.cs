namespace Sistema_Financeiro.Form_ContaReceber
{
    partial class LancarTitulo
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_IdCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_NomeCliente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_ValorAReceber = new System.Windows.Forms.TextBox();
            this.Dtp_DataEmissao = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Dtp_DataVencimento = new System.Windows.Forms.DateTimePicker();
            this.Btn_Criar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // Txt_IdCliente
            // 
            this.Txt_IdCliente.Location = new System.Drawing.Point(103, 26);
            this.Txt_IdCliente.Name = "Txt_IdCliente";
            this.Txt_IdCliente.Size = new System.Drawing.Size(100, 20);
            this.Txt_IdCliente.TabIndex = 3;
            this.Txt_IdCliente.TextChanged += new System.EventHandler(this.Txt_IdCliente_TextChanged);
            this.Txt_IdCliente.MouseLeave += new System.EventHandler(this.Txt_IdCliente_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cod Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cliente";
            // 
            // Lbl_NomeCliente
            // 
            this.Lbl_NomeCliente.AutoSize = true;
            this.Lbl_NomeCliente.Location = new System.Drawing.Point(100, 73);
            this.Lbl_NomeCliente.Name = "Lbl_NomeCliente";
            this.Lbl_NomeCliente.Size = new System.Drawing.Size(0, 13);
            this.Lbl_NomeCliente.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "A Receber";
            // 
            // Txt_ValorAReceber
            // 
            this.Txt_ValorAReceber.Location = new System.Drawing.Point(103, 111);
            this.Txt_ValorAReceber.Name = "Txt_ValorAReceber";
            this.Txt_ValorAReceber.Size = new System.Drawing.Size(132, 20);
            this.Txt_ValorAReceber.TabIndex = 7;
            this.Txt_ValorAReceber.TextChanged += new System.EventHandler(this.Txt_ValorAReceber_TextChanged);
            this.Txt_ValorAReceber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_ValorAReceber_KeyPress);
            // 
            // Dtp_DataEmissao
            // 
            this.Dtp_DataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_DataEmissao.Location = new System.Drawing.Point(103, 152);
            this.Dtp_DataEmissao.Name = "Dtp_DataEmissao";
            this.Dtp_DataEmissao.Size = new System.Drawing.Size(96, 20);
            this.Dtp_DataEmissao.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Emissão";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Vencimento";
            // 
            // Dtp_DataVencimento
            // 
            this.Dtp_DataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_DataVencimento.Location = new System.Drawing.Point(103, 191);
            this.Dtp_DataVencimento.Name = "Dtp_DataVencimento";
            this.Dtp_DataVencimento.Size = new System.Drawing.Size(96, 20);
            this.Dtp_DataVencimento.TabIndex = 11;
            // 
            // Btn_Criar
            // 
            this.Btn_Criar.Location = new System.Drawing.Point(250, 194);
            this.Btn_Criar.Name = "Btn_Criar";
            this.Btn_Criar.Size = new System.Drawing.Size(110, 37);
            this.Btn_Criar.TabIndex = 12;
            this.Btn_Criar.Text = "Gerar";
            this.Btn_Criar.UseVisualStyleBackColor = true;
            this.Btn_Criar.Click += new System.EventHandler(this.Btn_Criar_Click);
            // 
            // LancarTitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 245);
            this.Controls.Add(this.Btn_Criar);
            this.Controls.Add(this.Dtp_DataVencimento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Dtp_DataEmissao);
            this.Controls.Add(this.Txt_ValorAReceber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lbl_NomeCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_IdCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LancarTitulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LancarTitulo";
            this.Load += new System.EventHandler(this.LancarTitulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_IdCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_NomeCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_ValorAReceber;
        private System.Windows.Forms.DateTimePicker Dtp_DataEmissao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Dtp_DataVencimento;
        private System.Windows.Forms.Button Btn_Criar;
    }
}