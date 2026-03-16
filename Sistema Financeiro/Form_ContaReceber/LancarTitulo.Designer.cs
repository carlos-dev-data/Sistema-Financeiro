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
            this.Txt_ValorAReceber = new System.Windows.Forms.TextBox();
            this.Dtp_DataEmissao = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Dtp_DataVencimento = new System.Windows.Forms.DateTimePicker();
            this.Btn_Criar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHeaderTitulo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
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
            this.Txt_IdCliente.Location = new System.Drawing.Point(11, 28);
            this.Txt_IdCliente.Name = "Txt_IdCliente";
            this.Txt_IdCliente.Size = new System.Drawing.Size(155, 20);
            this.Txt_IdCliente.TabIndex = 3;
            this.Txt_IdCliente.TextChanged += new System.EventHandler(this.Txt_IdCliente_TextChanged);
            this.Txt_IdCliente.MouseLeave += new System.EventHandler(this.Txt_IdCliente_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cod Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cliente Selecionado";
            // 
            // Lbl_NomeCliente
            // 
            this.Lbl_NomeCliente.AutoSize = true;
            this.Lbl_NomeCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NomeCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_NomeCliente.Location = new System.Drawing.Point(19, 29);
            this.Lbl_NomeCliente.Name = "Lbl_NomeCliente";
            this.Lbl_NomeCliente.Size = new System.Drawing.Size(113, 16);
            this.Lbl_NomeCliente.TabIndex = 5;
            this.Lbl_NomeCliente.Text = "Nome do Cliente";
            // 
            // Txt_ValorAReceber
            // 
            this.Txt_ValorAReceber.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ValorAReceber.Location = new System.Drawing.Point(16, 31);
            this.Txt_ValorAReceber.Name = "Txt_ValorAReceber";
            this.Txt_ValorAReceber.Size = new System.Drawing.Size(132, 22);
            this.Txt_ValorAReceber.TabIndex = 7;
            this.Txt_ValorAReceber.TextChanged += new System.EventHandler(this.Txt_ValorAReceber_TextChanged);
            this.Txt_ValorAReceber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_ValorAReceber_KeyPress);
            // 
            // Dtp_DataEmissao
            // 
            this.Dtp_DataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_DataEmissao.Location = new System.Drawing.Point(11, 31);
            this.Dtp_DataEmissao.Name = "Dtp_DataEmissao";
            this.Dtp_DataEmissao.Size = new System.Drawing.Size(96, 20);
            this.Dtp_DataEmissao.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Emissão";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(11, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Vencimento";
            // 
            // Dtp_DataVencimento
            // 
            this.Dtp_DataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_DataVencimento.Location = new System.Drawing.Point(8, 31);
            this.Dtp_DataVencimento.Name = "Dtp_DataVencimento";
            this.Dtp_DataVencimento.Size = new System.Drawing.Size(96, 20);
            this.Dtp_DataVencimento.TabIndex = 11;
            this.Dtp_DataVencimento.ValueChanged += new System.EventHandler(this.Dtp_DataVencimento_ValueChanged);
            // 
            // Btn_Criar
            // 
            this.Btn_Criar.BackColor = System.Drawing.Color.RoyalBlue;
            this.Btn_Criar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Criar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Criar.Location = new System.Drawing.Point(309, 8);
            this.Btn_Criar.Name = "Btn_Criar";
            this.Btn_Criar.Size = new System.Drawing.Size(148, 37);
            this.Btn_Criar.TabIndex = 12;
            this.Btn_Criar.Text = "Gerar Título";
            this.Btn_Criar.UseVisualStyleBackColor = false;
            this.Btn_Criar.Click += new System.EventHandler(this.Btn_Criar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblHeaderTitulo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 55);
            this.panel1.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(368, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(26, 20);
            this.panel4.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel3.Location = new System.Drawing.Point(400, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(26, 20);
            this.panel3.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(432, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(26, 20);
            this.panel2.TabIndex = 7;
            // 
            // lblHeaderTitulo
            // 
            this.lblHeaderTitulo.AutoSize = true;
            this.lblHeaderTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTitulo.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitulo.Location = new System.Drawing.Point(24, 7);
            this.lblHeaderTitulo.Name = "lblHeaderTitulo";
            this.lblHeaderTitulo.Size = new System.Drawing.Size(109, 19);
            this.lblHeaderTitulo.TabIndex = 7;
            this.lblHeaderTitulo.Text = "Lançar Titulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contas a Receber - Novo Registro";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.Txt_IdCliente);
            this.panel5.Location = new System.Drawing.Point(22, 71);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(426, 58);
            this.panel5.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.Lbl_NomeCliente);
            this.panel6.Location = new System.Drawing.Point(22, 135);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(426, 58);
            this.panel6.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.Txt_ValorAReceber);
            this.panel7.Location = new System.Drawing.Point(22, 199);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(426, 58);
            this.panel7.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Valor A Receber";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.Dtp_DataEmissao);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(22, 263);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(206, 58);
            this.panel8.TabIndex = 17;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.Dtp_DataVencimento);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Location = new System.Drawing.Point(242, 263);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(206, 58);
            this.panel9.TabIndex = 18;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.Btn_Criar);
            this.panel10.Location = new System.Drawing.Point(0, 354);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(474, 58);
            this.panel10.TabIndex = 15;
            // 
            // LancarTitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(473, 411);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LancarTitulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LancarTitulo";
            this.Load += new System.EventHandler(this.LancarTitulo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_IdCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_NomeCliente;
        private System.Windows.Forms.TextBox Txt_ValorAReceber;
        private System.Windows.Forms.DateTimePicker Dtp_DataEmissao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Dtp_DataVencimento;
        private System.Windows.Forms.Button Btn_Criar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHeaderTitulo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
    }
}