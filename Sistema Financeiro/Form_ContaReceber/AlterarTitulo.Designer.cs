namespace Sistema_Financeiro.Form_ContaReceber
{
    partial class AlterarTitulo
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlDatas = new System.Windows.Forms.Panel();
            this.pnlVencimento = new System.Windows.Forms.Panel();
            this.Dtp_DataVencimento = new System.Windows.Forms.DateTimePicker();
            this.lblVencHint = new System.Windows.Forms.Label();
            this.lblVenc = new System.Windows.Forms.Label();
            this.pnlEmissao = new System.Windows.Forms.Panel();
            this.Dtp_DataEmissao = new System.Windows.Forms.DateTimePicker();
            this.lblEmissaoHint = new System.Windows.Forms.Label();
            this.lblEmissao = new System.Windows.Forms.Label();
            this.pnlValor = new System.Windows.Forms.Panel();
            this.Txt_ValorAReceber = new System.Windows.Forms.TextBox();
            this.lblValorHint = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.pnlNome = new System.Windows.Forms.Panel();
            this.lblNomeHint = new System.Windows.Forms.Label();
            this.Lbl_Cliente = new System.Windows.Forms.Label();
            this.pnlCodCliente = new System.Windows.Forms.Panel();
            this.Txt_IdCliente = new System.Windows.Forms.TextBox();
            this.lblCodClienteHint = new System.Windows.Forms.Label();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.pnlIDTitulo = new System.Windows.Forms.Panel();
            this.Txt_IDTitulo = new System.Windows.Forms.TextBox();
            this.lblIDTituloHint = new System.Windows.Forms.Label();
            this.lblIDTitulo = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.pnlAccent = new System.Windows.Forms.Panel();
            this.pnlSep = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlDatas.SuspendLayout();
            this.pnlVencimento.SuspendLayout();
            this.pnlEmissao.SuspendLayout();
            this.pnlValor.SuspendLayout();
            this.pnlNome.SuspendLayout();
            this.pnlCodCliente.SuspendLayout();
            this.pnlIDTitulo.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(5, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(415, 72);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubtitulo.Location = new System.Drawing.Point(26, 46);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(188, 13);
            this.lblSubtitulo.TabIndex = 0;
            this.lblSubtitulo.Text = "Contas a Receber  •  Editar Registro";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(24, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(130, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Alterar Título";
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.pnlBody.Controls.Add(this.pnlDatas);
            this.pnlBody.Controls.Add(this.pnlValor);
            this.pnlBody.Controls.Add(this.pnlNome);
            this.pnlBody.Controls.Add(this.pnlCodCliente);
            this.pnlBody.Controls.Add(this.pnlIDTitulo);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(5, 72);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(20, 14, 20, 0);
            this.pnlBody.Size = new System.Drawing.Size(415, 375);
            this.pnlBody.TabIndex = 0;
            // 
            // pnlDatas
            // 
            this.pnlDatas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.pnlDatas.Controls.Add(this.pnlVencimento);
            this.pnlDatas.Controls.Add(this.pnlEmissao);
            this.pnlDatas.Location = new System.Drawing.Point(20, 278);
            this.pnlDatas.Name = "pnlDatas";
            this.pnlDatas.Size = new System.Drawing.Size(375, 66);
            this.pnlDatas.TabIndex = 0;
            // 
            // pnlVencimento
            // 
            this.pnlVencimento.BackColor = System.Drawing.Color.White;
            this.pnlVencimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVencimento.Controls.Add(this.Dtp_DataVencimento);
            this.pnlVencimento.Controls.Add(this.lblVencHint);
            this.pnlVencimento.Controls.Add(this.lblVenc);
            this.pnlVencimento.Location = new System.Drawing.Point(192, 0);
            this.pnlVencimento.Name = "pnlVencimento";
            this.pnlVencimento.Size = new System.Drawing.Size(183, 62);
            this.pnlVencimento.TabIndex = 0;
            // 
            // Dtp_DataVencimento
            // 
            this.Dtp_DataVencimento.CustomFormat = "dd/MM/yyyy";
            this.Dtp_DataVencimento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Dtp_DataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_DataVencimento.Location = new System.Drawing.Point(8, 33);
            this.Dtp_DataVencimento.Name = "Dtp_DataVencimento";
            this.Dtp_DataVencimento.Size = new System.Drawing.Size(163, 25);
            this.Dtp_DataVencimento.TabIndex = 4;
            // 
            // lblVencHint
            // 
            this.lblVencHint.AutoSize = true;
            this.lblVencHint.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblVencHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(230)))));
            this.lblVencHint.Location = new System.Drawing.Point(96, 11);
            this.lblVencHint.Name = "lblVencHint";
            this.lblVencHint.Size = new System.Drawing.Size(63, 12);
            this.lblVencHint.TabIndex = 5;
            this.lblVencHint.Text = "dd/MM/aaaa";
            // 
            // lblVenc
            // 
            this.lblVenc.AutoSize = true;
            this.lblVenc.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblVenc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblVenc.Location = new System.Drawing.Point(10, 9);
            this.lblVenc.Name = "lblVenc";
            this.lblVenc.Size = new System.Drawing.Size(79, 13);
            this.lblVenc.TabIndex = 6;
            this.lblVenc.Text = "VENCIMENTO";
            // 
            // pnlEmissao
            // 
            this.pnlEmissao.BackColor = System.Drawing.Color.White;
            this.pnlEmissao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmissao.Controls.Add(this.Dtp_DataEmissao);
            this.pnlEmissao.Controls.Add(this.lblEmissaoHint);
            this.pnlEmissao.Controls.Add(this.lblEmissao);
            this.pnlEmissao.Location = new System.Drawing.Point(0, 0);
            this.pnlEmissao.Name = "pnlEmissao";
            this.pnlEmissao.Size = new System.Drawing.Size(180, 62);
            this.pnlEmissao.TabIndex = 1;
            // 
            // Dtp_DataEmissao
            // 
            this.Dtp_DataEmissao.CustomFormat = "dd/MM/yyyy";
            this.Dtp_DataEmissao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Dtp_DataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_DataEmissao.Location = new System.Drawing.Point(8, 33);
            this.Dtp_DataEmissao.Name = "Dtp_DataEmissao";
            this.Dtp_DataEmissao.Size = new System.Drawing.Size(160, 25);
            this.Dtp_DataEmissao.TabIndex = 3;
            // 
            // lblEmissaoHint
            // 
            this.lblEmissaoHint.AutoSize = true;
            this.lblEmissaoHint.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblEmissaoHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(230)))));
            this.lblEmissaoHint.Location = new System.Drawing.Point(74, 11);
            this.lblEmissaoHint.Name = "lblEmissaoHint";
            this.lblEmissaoHint.Size = new System.Drawing.Size(63, 12);
            this.lblEmissaoHint.TabIndex = 4;
            this.lblEmissaoHint.Text = "dd/MM/aaaa";
            // 
            // lblEmissao
            // 
            this.lblEmissao.AutoSize = true;
            this.lblEmissao.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblEmissao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblEmissao.Location = new System.Drawing.Point(10, 9);
            this.lblEmissao.Name = "lblEmissao";
            this.lblEmissao.Size = new System.Drawing.Size(55, 13);
            this.lblEmissao.TabIndex = 5;
            this.lblEmissao.Text = "EMISSÃO";
            // 
            // pnlValor
            // 
            this.pnlValor.BackColor = System.Drawing.Color.White;
            this.pnlValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlValor.Controls.Add(this.Txt_ValorAReceber);
            this.pnlValor.Controls.Add(this.lblValorHint);
            this.pnlValor.Controls.Add(this.lblValor);
            this.pnlValor.Location = new System.Drawing.Point(20, 210);
            this.pnlValor.Name = "pnlValor";
            this.pnlValor.Size = new System.Drawing.Size(375, 58);
            this.pnlValor.TabIndex = 1;
            // 
            // Txt_ValorAReceber
            // 
            this.Txt_ValorAReceber.BackColor = System.Drawing.Color.White;
            this.Txt_ValorAReceber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_ValorAReceber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_ValorAReceber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.Txt_ValorAReceber.Location = new System.Drawing.Point(12, 30);
            this.Txt_ValorAReceber.Name = "Txt_ValorAReceber";
            this.Txt_ValorAReceber.Size = new System.Drawing.Size(348, 22);
            this.Txt_ValorAReceber.TabIndex = 2;
            this.Txt_ValorAReceber.TextChanged += new System.EventHandler(this.Txt_ValorAReceber_TextChanged);
            this.Txt_ValorAReceber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_ValorAReceber_KeyPress);
            // 
            // lblValorHint
            // 
            this.lblValorHint.AutoSize = true;
            this.lblValorHint.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblValorHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(230)))));
            this.lblValorHint.Location = new System.Drawing.Point(175, 11);
            this.lblValorHint.Name = "lblValorHint";
            this.lblValorHint.Size = new System.Drawing.Size(52, 12);
            this.lblValorHint.TabIndex = 3;
            this.lblValorHint.Text = "ex: 1500,00";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblValor.Location = new System.Drawing.Point(12, 9);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(126, 13);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "VALOR A RECEBER (R$)";
            // 
            // pnlNome
            // 
            this.pnlNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.pnlNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNome.Controls.Add(this.lblNomeHint);
            this.pnlNome.Controls.Add(this.Lbl_Cliente);
            this.pnlNome.Location = new System.Drawing.Point(20, 150);
            this.pnlNome.Name = "pnlNome";
            this.pnlNome.Size = new System.Drawing.Size(375, 50);
            this.pnlNome.TabIndex = 2;
            // 
            // lblNomeHint
            // 
            this.lblNomeHint.AutoSize = true;
            this.lblNomeHint.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblNomeHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.lblNomeHint.Location = new System.Drawing.Point(12, 7);
            this.lblNomeHint.Name = "lblNomeHint";
            this.lblNomeHint.Size = new System.Drawing.Size(128, 13);
            this.lblNomeHint.TabIndex = 0;
            this.lblNomeHint.Text = "CLIENTE SELECIONADO";
            // 
            // Lbl_Cliente
            // 
            this.Lbl_Cliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Lbl_Cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.Lbl_Cliente.Location = new System.Drawing.Point(12, 25);
            this.Lbl_Cliente.Name = "Lbl_Cliente";
            this.Lbl_Cliente.Size = new System.Drawing.Size(348, 20);
            this.Lbl_Cliente.TabIndex = 1;
            this.Lbl_Cliente.Text = "—";
            // 
            // pnlCodCliente
            // 
            this.pnlCodCliente.BackColor = System.Drawing.Color.White;
            this.pnlCodCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCodCliente.Controls.Add(this.Txt_IdCliente);
            this.pnlCodCliente.Controls.Add(this.lblCodClienteHint);
            this.pnlCodCliente.Controls.Add(this.lblCodCliente);
            this.pnlCodCliente.Location = new System.Drawing.Point(20, 82);
            this.pnlCodCliente.Name = "pnlCodCliente";
            this.pnlCodCliente.Size = new System.Drawing.Size(375, 58);
            this.pnlCodCliente.TabIndex = 3;
            // 
            // Txt_IdCliente
            // 
            this.Txt_IdCliente.BackColor = System.Drawing.Color.White;
            this.Txt_IdCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_IdCliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Txt_IdCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.Txt_IdCliente.Location = new System.Drawing.Point(12, 31);
            this.Txt_IdCliente.Name = "Txt_IdCliente";
            this.Txt_IdCliente.Size = new System.Drawing.Size(348, 18);
            this.Txt_IdCliente.TabIndex = 1;
            this.Txt_IdCliente.MouseLeave += new System.EventHandler(this.Txt_IdCliente_MouseLeave);
            // 
            // lblCodClienteHint
            // 
            this.lblCodClienteHint.AutoSize = true;
            this.lblCodClienteHint.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblCodClienteHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(230)))));
            this.lblCodClienteHint.Location = new System.Drawing.Point(110, 11);
            this.lblCodClienteHint.Name = "lblCodClienteHint";
            this.lblCodClienteHint.Size = new System.Drawing.Size(118, 12);
            this.lblCodClienteHint.TabIndex = 2;
            this.lblCodClienteHint.Text = "pressione Tab para buscar";
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCodCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblCodCliente.Location = new System.Drawing.Point(12, 9);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(78, 13);
            this.lblCodCliente.TabIndex = 3;
            this.lblCodCliente.Text = "CÓD. CLIENTE";
            // 
            // pnlIDTitulo
            // 
            this.pnlIDTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(235)))));
            this.pnlIDTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIDTitulo.Controls.Add(this.Txt_IDTitulo);
            this.pnlIDTitulo.Controls.Add(this.lblIDTituloHint);
            this.pnlIDTitulo.Controls.Add(this.lblIDTitulo);
            this.pnlIDTitulo.Location = new System.Drawing.Point(20, 14);
            this.pnlIDTitulo.Name = "pnlIDTitulo";
            this.pnlIDTitulo.Size = new System.Drawing.Size(375, 58);
            this.pnlIDTitulo.TabIndex = 4;
            // 
            // Txt_IDTitulo
            // 
            this.Txt_IDTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(235)))));
            this.Txt_IDTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_IDTitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Txt_IDTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.Txt_IDTitulo.Location = new System.Drawing.Point(12, 31);
            this.Txt_IDTitulo.Name = "Txt_IDTitulo";
            this.Txt_IDTitulo.Size = new System.Drawing.Size(348, 18);
            this.Txt_IDTitulo.TabIndex = 0;
            this.Txt_IDTitulo.MouseLeave += new System.EventHandler(this.Txt_IDTitulo_MouseLeave);
            // 
            // lblIDTituloHint
            // 
            this.lblIDTituloHint.AutoSize = true;
            this.lblIDTituloHint.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblIDTituloHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.lblIDTituloHint.Location = new System.Drawing.Point(106, 11);
            this.lblIDTituloHint.Name = "lblIDTituloHint";
            this.lblIDTituloHint.Size = new System.Drawing.Size(110, 12);
            this.lblIDTituloHint.TabIndex = 1;
            this.lblIDTituloHint.Text = "Tab para carregar dados";
            // 
            // lblIDTitulo
            // 
            this.lblIDTitulo.AutoSize = true;
            this.lblIDTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblIDTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.lblIDTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblIDTitulo.Name = "lblIDTitulo";
            this.lblIDTitulo.Size = new System.Drawing.Size(77, 13);
            this.lblIDTitulo.TabIndex = 2;
            this.lblIDTitulo.Text = "ID DO TÍTULO";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.Btn_Cancelar);
            this.pnlFooter.Controls.Add(this.Btn_Editar);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(5, 447);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(415, 62);
            this.pnlFooter.TabIndex = 1;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Btn_Cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.Btn_Cancelar.Location = new System.Drawing.Point(20, 11);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(100, 38);
            this.Btn_Cancelar.TabIndex = 5;
            this.Btn_Cancelar.Text = "Limpar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.BackColor = System.Drawing.Color.RoyalBlue;
            this.Btn_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Editar.FlatAppearance.BorderSize = 0;
            this.Btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Editar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Editar.ForeColor = System.Drawing.Color.White;
            this.Btn_Editar.Location = new System.Drawing.Point(247, 11);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(148, 38);
            this.Btn_Editar.TabIndex = 6;
            this.Btn_Editar.Text = "✎  Salvar Alteração";
            this.Btn_Editar.UseVisualStyleBackColor = false;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // pnlAccent
            // 
            this.pnlAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.pnlAccent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlAccent.Name = "pnlAccent";
            this.pnlAccent.Size = new System.Drawing.Size(5, 510);
            this.pnlAccent.TabIndex = 4;
            // 
            // pnlSep
            // 
            this.pnlSep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlSep.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSep.Location = new System.Drawing.Point(5, 509);
            this.pnlSep.Name = "pnlSep";
            this.pnlSep.Size = new System.Drawing.Size(415, 1);
            this.pnlSep.TabIndex = 2;
            // 
            // AlterarTitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(420, 510);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlSep);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlAccent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AlterarTitulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Título — Sistema Financeiro";
            this.Load += new System.EventHandler(this.AlterarTitulo_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlDatas.ResumeLayout(false);
            this.pnlVencimento.ResumeLayout(false);
            this.pnlVencimento.PerformLayout();
            this.pnlEmissao.ResumeLayout(false);
            this.pnlEmissao.PerformLayout();
            this.pnlValor.ResumeLayout(false);
            this.pnlValor.PerformLayout();
            this.pnlNome.ResumeLayout(false);
            this.pnlNome.PerformLayout();
            this.pnlCodCliente.ResumeLayout(false);
            this.pnlCodCliente.PerformLayout();
            this.pnlIDTitulo.ResumeLayout(false);
            this.pnlIDTitulo.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlAccent;
        private System.Windows.Forms.Panel pnlSep;
        private System.Windows.Forms.Panel pnlIDTitulo;
        private System.Windows.Forms.Panel pnlCodCliente;
        private System.Windows.Forms.Panel pnlNome;
        private System.Windows.Forms.Panel pnlValor;
        private System.Windows.Forms.Panel pnlDatas;
        private System.Windows.Forms.Panel pnlEmissao;
        private System.Windows.Forms.Panel pnlVencimento;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblIDTitulo;
        private System.Windows.Forms.Label lblIDTituloHint;
        private System.Windows.Forms.Label lblCodCliente;
        private System.Windows.Forms.Label lblCodClienteHint;
        private System.Windows.Forms.Label lblNomeHint;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblValorHint;
        private System.Windows.Forms.Label lblEmissao;
        private System.Windows.Forms.Label lblEmissaoHint;
        private System.Windows.Forms.Label lblVenc;
        private System.Windows.Forms.Label lblVencHint;
        private System.Windows.Forms.TextBox Txt_IDTitulo;
        private System.Windows.Forms.TextBox Txt_IdCliente;
        private System.Windows.Forms.Label Lbl_Cliente;
        private System.Windows.Forms.TextBox Txt_ValorAReceber;
        private System.Windows.Forms.DateTimePicker Dtp_DataEmissao;
        private System.Windows.Forms.DateTimePicker Dtp_DataVencimento;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Cancelar;
    }
}