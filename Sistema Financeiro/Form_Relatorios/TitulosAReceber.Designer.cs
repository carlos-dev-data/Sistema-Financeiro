namespace Sistema_Financeiro.Form_Relatorios
{
    partial class TitulosAReceber
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitulo = new System.Windows.Forms.Label();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.dtpVencimentoFinalFinan = new System.Windows.Forms.DateTimePicker();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtValorMinFinan = new System.Windows.Forms.TextBox();
            this.cmbStatusFinan = new System.Windows.Forms.ComboBox();
            this.lblValorMinFinan = new System.Windows.Forms.Label();
            this.lblStatusFinan = new System.Windows.Forms.Label();
            this.dtpVencimentoIniFinan = new System.Windows.Forms.DateTimePicker();
            this.txtValorMaxFinan = new System.Windows.Forms.TextBox();
            this.txtNomeClienteFinan = new System.Windows.Forms.TextBox();
            this.lblValorMaxFinan = new System.Windows.Forms.Label();
            this.lblVencimentoFinan = new System.Windows.Forms.Label();
            this.lblNomeClienteFinan = new System.Windows.Forms.Label();
            this.dtpEmissaoFinan = new System.Windows.Forms.DateTimePicker();
            this.txtIdTituloFinan = new System.Windows.Forms.TextBox();
            this.txtCodClienteFinan = new System.Windows.Forms.TextBox();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.lblIdTituloFinan = new System.Windows.Forms.Label();
            this.lblEmissaoFinan = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblCodClienteFinan = new System.Windows.Forms.Label();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.pnlCardAzul = new System.Windows.Forms.Panel();
            this.lblTotalTitulos = new System.Windows.Forms.Label();
            this.lblLblTitulosFinan = new System.Windows.Forms.Label();
            this.pnlCardAmarelo = new System.Windows.Forms.Panel();
            this.lblTotalSaldo = new System.Windows.Forms.Label();
            this.lblLblSaldo = new System.Windows.Forms.Label();
            this.pnlCardVermelho = new System.Windows.Forms.Panel();
            this.lblTotalAReceber = new System.Windows.Forms.Label();
            this.lblLblAReceber = new System.Windows.Forms.Label();
            this.pnlCardVerde = new System.Windows.Forms.Panel();
            this.lblTotalRecebido = new System.Windows.Forms.Label();
            this.lblLblRecebido = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.grpTabela = new System.Windows.Forms.GroupBox();
            this.dgvTitulos = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.grpFiltros.SuspendLayout();
            this.pnlCardAzul.SuspendLayout();
            this.pnlCardAmarelo.SuspendLayout();
            this.pnlCardVermelho.SuspendLayout();
            this.pnlCardVerde.SuspendLayout();
            this.grpTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlHeader.Controls.Add(this.lblHeaderTitulo);
            this.pnlHeader.Location = new System.Drawing.Point(12, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1064, 43);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitulo
            // 
            this.lblHeaderTitulo.AutoSize = true;
            this.lblHeaderTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTitulo.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitulo.Location = new System.Drawing.Point(56, 13);
            this.lblHeaderTitulo.Name = "lblHeaderTitulo";
            this.lblHeaderTitulo.Size = new System.Drawing.Size(238, 19);
            this.lblHeaderTitulo.TabIndex = 0;
            this.lblHeaderTitulo.Text = "Consulta de Títulos a Receber";
            // 
            // grpFiltros
            // 
            this.grpFiltros.BackColor = System.Drawing.Color.White;
            this.grpFiltros.Controls.Add(this.dtpVencimentoFinalFinan);
            this.grpFiltros.Controls.Add(this.btnLimpar);
            this.grpFiltros.Controls.Add(this.btnBuscar);
            this.grpFiltros.Controls.Add(this.txtValorMinFinan);
            this.grpFiltros.Controls.Add(this.cmbStatusFinan);
            this.grpFiltros.Controls.Add(this.lblValorMinFinan);
            this.grpFiltros.Controls.Add(this.lblStatusFinan);
            this.grpFiltros.Controls.Add(this.dtpVencimentoIniFinan);
            this.grpFiltros.Controls.Add(this.txtValorMaxFinan);
            this.grpFiltros.Controls.Add(this.txtNomeClienteFinan);
            this.grpFiltros.Controls.Add(this.lblValorMaxFinan);
            this.grpFiltros.Controls.Add(this.lblVencimentoFinan);
            this.grpFiltros.Controls.Add(this.lblNomeClienteFinan);
            this.grpFiltros.Controls.Add(this.dtpEmissaoFinan);
            this.grpFiltros.Controls.Add(this.txtIdTituloFinan);
            this.grpFiltros.Controls.Add(this.txtCodClienteFinan);
            this.grpFiltros.Controls.Add(this.txtCodCliente);
            this.grpFiltros.Controls.Add(this.lblIdTituloFinan);
            this.grpFiltros.Controls.Add(this.lblEmissaoFinan);
            this.grpFiltros.Controls.Add(this.lblNomeCliente);
            this.grpFiltros.Controls.Add(this.lblCodClienteFinan);
            this.grpFiltros.Controls.Add(this.lblCodCliente);
            this.grpFiltros.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltros.Location = new System.Drawing.Point(12, 68);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(1064, 156);
            this.grpFiltros.TabIndex = 1;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // dtpVencimentoFinalFinan
            // 
            this.dtpVencimentoFinalFinan.Checked = false;
            this.dtpVencimentoFinalFinan.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVencimentoFinalFinan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimentoFinalFinan.Location = new System.Drawing.Point(397, 83);
            this.dtpVencimentoFinalFinan.Name = "dtpVencimentoFinalFinan";
            this.dtpVencimentoFinalFinan.Size = new System.Drawing.Size(133, 20);
            this.dtpVencimentoFinalFinan.TabIndex = 20;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Red;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpar.Location = new System.Drawing.Point(851, 124);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(94, 26);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(964, 124);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 26);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtValorMinFinan
            // 
            this.txtValorMinFinan.Location = new System.Drawing.Point(743, 59);
            this.txtValorMinFinan.Name = "txtValorMinFinan";
            this.txtValorMinFinan.Size = new System.Drawing.Size(133, 22);
            this.txtValorMinFinan.TabIndex = 17;
            // 
            // cmbStatusFinan
            // 
            this.cmbStatusFinan.FormattingEnabled = true;
            this.cmbStatusFinan.Location = new System.Drawing.Point(743, 28);
            this.cmbStatusFinan.Name = "cmbStatusFinan";
            this.cmbStatusFinan.Size = new System.Drawing.Size(164, 24);
            this.cmbStatusFinan.TabIndex = 16;
            // 
            // lblValorMinFinan
            // 
            this.lblValorMinFinan.AutoSize = true;
            this.lblValorMinFinan.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorMinFinan.Location = new System.Drawing.Point(655, 63);
            this.lblValorMinFinan.Name = "lblValorMinFinan";
            this.lblValorMinFinan.Size = new System.Drawing.Size(54, 14);
            this.lblValorMinFinan.TabIndex = 13;
            this.lblValorMinFinan.Text = "Valor Mín.";
            // 
            // lblStatusFinan
            // 
            this.lblStatusFinan.AutoSize = true;
            this.lblStatusFinan.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusFinan.Location = new System.Drawing.Point(655, 33);
            this.lblStatusFinan.Name = "lblStatusFinan";
            this.lblStatusFinan.Size = new System.Drawing.Size(38, 14);
            this.lblStatusFinan.TabIndex = 12;
            this.lblStatusFinan.Text = "Status";
            // 
            // dtpVencimentoIniFinan
            // 
            this.dtpVencimentoIniFinan.Checked = false;
            this.dtpVencimentoIniFinan.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVencimentoIniFinan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimentoIniFinan.Location = new System.Drawing.Point(397, 59);
            this.dtpVencimentoIniFinan.Name = "dtpVencimentoIniFinan";
            this.dtpVencimentoIniFinan.Size = new System.Drawing.Size(133, 20);
            this.dtpVencimentoIniFinan.TabIndex = 11;
            // 
            // txtValorMaxFinan
            // 
            this.txtValorMaxFinan.Location = new System.Drawing.Point(397, 109);
            this.txtValorMaxFinan.Name = "txtValorMaxFinan";
            this.txtValorMaxFinan.Size = new System.Drawing.Size(133, 22);
            this.txtValorMaxFinan.TabIndex = 10;
            // 
            // txtNomeClienteFinan
            // 
            this.txtNomeClienteFinan.Location = new System.Drawing.Point(396, 33);
            this.txtNomeClienteFinan.Name = "txtNomeClienteFinan";
            this.txtNomeClienteFinan.Size = new System.Drawing.Size(253, 22);
            this.txtNomeClienteFinan.TabIndex = 9;
            // 
            // lblValorMaxFinan
            // 
            this.lblValorMaxFinan.AutoSize = true;
            this.lblValorMaxFinan.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorMaxFinan.Location = new System.Drawing.Point(311, 114);
            this.lblValorMaxFinan.Name = "lblValorMaxFinan";
            this.lblValorMaxFinan.Size = new System.Drawing.Size(58, 14);
            this.lblValorMaxFinan.TabIndex = 8;
            this.lblValorMaxFinan.Text = "Valor Máx.";
            // 
            // lblVencimentoFinan
            // 
            this.lblVencimentoFinan.AutoSize = true;
            this.lblVencimentoFinan.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimentoFinan.Location = new System.Drawing.Point(309, 65);
            this.lblVencimentoFinan.Name = "lblVencimentoFinan";
            this.lblVencimentoFinan.Size = new System.Drawing.Size(76, 14);
            this.lblVencimentoFinan.TabIndex = 7;
            this.lblVencimentoFinan.Text = "Dt.Vencimento";
            // 
            // lblNomeClienteFinan
            // 
            this.lblNomeClienteFinan.AutoSize = true;
            this.lblNomeClienteFinan.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeClienteFinan.Location = new System.Drawing.Point(309, 35);
            this.lblNomeClienteFinan.Name = "lblNomeClienteFinan";
            this.lblNomeClienteFinan.Size = new System.Drawing.Size(69, 14);
            this.lblNomeClienteFinan.TabIndex = 6;
            this.lblNomeClienteFinan.Text = "Nome Cliente";
            // 
            // dtpEmissaoFinan
            // 
            this.dtpEmissaoFinan.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmissaoFinan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmissaoFinan.Location = new System.Drawing.Point(106, 61);
            this.dtpEmissaoFinan.Name = "dtpEmissaoFinan";
            this.dtpEmissaoFinan.Size = new System.Drawing.Size(133, 20);
            this.dtpEmissaoFinan.TabIndex = 5;
            // 
            // txtIdTituloFinan
            // 
            this.txtIdTituloFinan.Location = new System.Drawing.Point(106, 87);
            this.txtIdTituloFinan.Name = "txtIdTituloFinan";
            this.txtIdTituloFinan.Size = new System.Drawing.Size(133, 22);
            this.txtIdTituloFinan.TabIndex = 4;
            // 
            // txtCodClienteFinan
            // 
            this.txtCodClienteFinan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodClienteFinan.Location = new System.Drawing.Point(105, 33);
            this.txtCodClienteFinan.Name = "txtCodClienteFinan";
            this.txtCodClienteFinan.Size = new System.Drawing.Size(133, 15);
            this.txtCodClienteFinan.TabIndex = 3;
            this.txtCodClienteFinan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(106, 30);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(133, 22);
            this.txtCodCliente.TabIndex = 3;
            // 
            // lblIdTituloFinan
            // 
            this.lblIdTituloFinan.AutoSize = true;
            this.lblIdTituloFinan.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTituloFinan.Location = new System.Drawing.Point(20, 92);
            this.lblIdTituloFinan.Name = "lblIdTituloFinan";
            this.lblIdTituloFinan.Size = new System.Drawing.Size(44, 14);
            this.lblIdTituloFinan.TabIndex = 2;
            this.lblIdTituloFinan.Text = "ID Título";
            // 
            // lblEmissaoFinan
            // 
            this.lblEmissaoFinan.AutoSize = true;
            this.lblEmissaoFinan.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmissaoFinan.Location = new System.Drawing.Point(18, 65);
            this.lblEmissaoFinan.Name = "lblEmissaoFinan";
            this.lblEmissaoFinan.Size = new System.Drawing.Size(60, 14);
            this.lblEmissaoFinan.TabIndex = 1;
            this.lblEmissaoFinan.Text = "Dt.Emissão";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(19, 62);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(60, 14);
            this.lblNomeCliente.TabIndex = 1;
            this.lblNomeCliente.Text = "Dt.Emissão";
            // 
            // lblCodClienteFinan
            // 
            this.lblCodClienteFinan.AutoSize = true;
            this.lblCodClienteFinan.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodClienteFinan.Location = new System.Drawing.Point(18, 35);
            this.lblCodClienteFinan.Name = "lblCodClienteFinan";
            this.lblCodClienteFinan.Size = new System.Drawing.Size(61, 14);
            this.lblCodClienteFinan.TabIndex = 0;
            this.lblCodClienteFinan.Text = "Cód.Cliente";
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCliente.Location = new System.Drawing.Point(19, 32);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(61, 14);
            this.lblCodCliente.TabIndex = 0;
            this.lblCodCliente.Text = "Cód.Cliente";
            // 
            // pnlCardAzul
            // 
            this.pnlCardAzul.BackColor = System.Drawing.Color.White;
            this.pnlCardAzul.Controls.Add(this.lblTotalTitulos);
            this.pnlCardAzul.Controls.Add(this.lblLblTitulosFinan);
            this.pnlCardAzul.Location = new System.Drawing.Point(12, 230);
            this.pnlCardAzul.Name = "pnlCardAzul";
            this.pnlCardAzul.Size = new System.Drawing.Size(238, 59);
            this.pnlCardAzul.TabIndex = 2;
            // 
            // lblTotalTitulos
            // 
            this.lblTotalTitulos.AutoSize = true;
            this.lblTotalTitulos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTitulos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalTitulos.Location = new System.Drawing.Point(20, 32);
            this.lblTotalTitulos.Name = "lblTotalTitulos";
            this.lblTotalTitulos.Size = new System.Drawing.Size(85, 15);
            this.lblTotalTitulos.TabIndex = 21;
            this.lblTotalTitulos.Text = "lblTotalTitulos";
            // 
            // lblLblTitulosFinan
            // 
            this.lblLblTitulosFinan.AutoSize = true;
            this.lblLblTitulosFinan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLblTitulosFinan.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLblTitulosFinan.Location = new System.Drawing.Point(16, 11);
            this.lblLblTitulosFinan.Name = "lblLblTitulosFinan";
            this.lblLblTitulosFinan.Size = new System.Drawing.Size(75, 15);
            this.lblLblTitulosFinan.TabIndex = 20;
            this.lblLblTitulosFinan.Text = "Total Títulos";
            // 
            // pnlCardAmarelo
            // 
            this.pnlCardAmarelo.BackColor = System.Drawing.Color.White;
            this.pnlCardAmarelo.Controls.Add(this.lblTotalSaldo);
            this.pnlCardAmarelo.Controls.Add(this.lblLblSaldo);
            this.pnlCardAmarelo.Location = new System.Drawing.Point(838, 230);
            this.pnlCardAmarelo.Name = "pnlCardAmarelo";
            this.pnlCardAmarelo.Size = new System.Drawing.Size(238, 59);
            this.pnlCardAmarelo.TabIndex = 3;
            // 
            // lblTotalSaldo
            // 
            this.lblTotalSaldo.AutoSize = true;
            this.lblTotalSaldo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaldo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalSaldo.Location = new System.Drawing.Point(29, 32);
            this.lblTotalSaldo.Name = "lblTotalSaldo";
            this.lblTotalSaldo.Size = new System.Drawing.Size(79, 15);
            this.lblTotalSaldo.TabIndex = 24;
            this.lblTotalSaldo.Text = "lblTotalSaldo";
            // 
            // lblLblSaldo
            // 
            this.lblLblSaldo.AutoSize = true;
            this.lblLblSaldo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLblSaldo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLblSaldo.Location = new System.Drawing.Point(22, 11);
            this.lblLblSaldo.Name = "lblLblSaldo";
            this.lblLblSaldo.Size = new System.Drawing.Size(101, 15);
            this.lblLblSaldo.TabIndex = 23;
            this.lblLblSaldo.Text = "Saldo em Aberto";
            // 
            // pnlCardVermelho
            // 
            this.pnlCardVermelho.BackColor = System.Drawing.Color.White;
            this.pnlCardVermelho.Controls.Add(this.lblTotalAReceber);
            this.pnlCardVermelho.Controls.Add(this.lblLblAReceber);
            this.pnlCardVermelho.Location = new System.Drawing.Point(282, 230);
            this.pnlCardVermelho.Name = "pnlCardVermelho";
            this.pnlCardVermelho.Size = new System.Drawing.Size(238, 59);
            this.pnlCardVermelho.TabIndex = 4;
            // 
            // lblTotalAReceber
            // 
            this.lblTotalAReceber.AutoSize = true;
            this.lblTotalAReceber.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAReceber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalAReceber.Location = new System.Drawing.Point(26, 32);
            this.lblTotalAReceber.Name = "lblTotalAReceber";
            this.lblTotalAReceber.Size = new System.Drawing.Size(103, 15);
            this.lblTotalAReceber.TabIndex = 22;
            this.lblTotalAReceber.Text = "lblTotalAReceber";
            // 
            // lblLblAReceber
            // 
            this.lblLblAReceber.AutoSize = true;
            this.lblLblAReceber.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLblAReceber.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLblAReceber.Location = new System.Drawing.Point(22, 11);
            this.lblLblAReceber.Name = "lblLblAReceber";
            this.lblLblAReceber.Size = new System.Drawing.Size(96, 15);
            this.lblLblAReceber.TabIndex = 21;
            this.lblLblAReceber.Text = "Total A Receber";
            // 
            // pnlCardVerde
            // 
            this.pnlCardVerde.BackColor = System.Drawing.Color.White;
            this.pnlCardVerde.Controls.Add(this.lblTotalRecebido);
            this.pnlCardVerde.Controls.Add(this.lblLblRecebido);
            this.pnlCardVerde.Controls.Add(this.panel7);
            this.pnlCardVerde.Location = new System.Drawing.Point(572, 230);
            this.pnlCardVerde.Name = "pnlCardVerde";
            this.pnlCardVerde.Size = new System.Drawing.Size(238, 59);
            this.pnlCardVerde.TabIndex = 5;
            // 
            // lblTotalRecebido
            // 
            this.lblTotalRecebido.AutoSize = true;
            this.lblTotalRecebido.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecebido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalRecebido.Location = new System.Drawing.Point(35, 32);
            this.lblTotalRecebido.Name = "lblTotalRecebido";
            this.lblTotalRecebido.Size = new System.Drawing.Size(100, 15);
            this.lblTotalRecebido.TabIndex = 23;
            this.lblTotalRecebido.Text = "lblTotalRecebido";
            // 
            // lblLblRecebido
            // 
            this.lblLblRecebido.AutoSize = true;
            this.lblLblRecebido.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLblRecebido.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLblRecebido.Location = new System.Drawing.Point(26, 11);
            this.lblLblRecebido.Name = "lblLblRecebido";
            this.lblLblRecebido.Size = new System.Drawing.Size(90, 15);
            this.lblLblRecebido.TabIndex = 22;
            this.lblLblRecebido.Text = "Total Recebido";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkGreen;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 59);
            this.panel7.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Blue;
            this.panel5.Location = new System.Drawing.Point(12, 230);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 59);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Red;
            this.panel6.Location = new System.Drawing.Point(282, 230);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 59);
            this.panel6.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel8.Location = new System.Drawing.Point(838, 230);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 59);
            this.panel8.TabIndex = 6;
            // 
            // grpTabela
            // 
            this.grpTabela.BackColor = System.Drawing.Color.White;
            this.grpTabela.Controls.Add(this.dgvTitulos);
            this.grpTabela.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTabela.Location = new System.Drawing.Point(12, 295);
            this.grpTabela.Name = "grpTabela";
            this.grpTabela.Size = new System.Drawing.Size(1064, 320);
            this.grpTabela.TabIndex = 7;
            this.grpTabela.TabStop = false;
            this.grpTabela.Text = "Títulos";
            // 
            // dgvTitulos
            // 
            this.dgvTitulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitulos.Location = new System.Drawing.Point(0, 21);
            this.dgvTitulos.Name = "dgvTitulos";
            this.dgvTitulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTitulos.Size = new System.Drawing.Size(1064, 299);
            this.dgvTitulos.TabIndex = 0;
            this.dgvTitulos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTitulos_CellFormatting);
            this.dgvTitulos.SelectionChanged += new System.EventHandler(this.dgvTitulos_SelectionChanged);
            // 
            // TitulosAReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1088, 617);
            this.Controls.Add(this.grpTabela);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnlCardVerde);
            this.Controls.Add(this.pnlCardVermelho);
            this.Controls.Add(this.pnlCardAmarelo);
            this.Controls.Add(this.pnlCardAzul);
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "TitulosAReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TitulosAReceber";
            this.Load += new System.EventHandler(this.TitulosAReceber_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.pnlCardAzul.ResumeLayout(false);
            this.pnlCardAzul.PerformLayout();
            this.pnlCardAmarelo.ResumeLayout(false);
            this.pnlCardAmarelo.PerformLayout();
            this.pnlCardVermelho.ResumeLayout(false);
            this.pnlCardVermelho.PerformLayout();
            this.pnlCardVerde.ResumeLayout(false);
            this.pnlCardVerde.PerformLayout();
            this.grpTabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitulo;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.TextBox txtIdTituloFinan;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label lblIdTituloFinan;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblCodCliente;
        private System.Windows.Forms.DateTimePicker dtpEmissaoFinan;
        private System.Windows.Forms.DateTimePicker dtpVencimentoIniFinan;
        private System.Windows.Forms.TextBox txtValorMaxFinan;
        private System.Windows.Forms.TextBox txtNomeClienteFinan;
        private System.Windows.Forms.Label lblValorMaxFinan;
        private System.Windows.Forms.Label lblVencimentoFinan;
        private System.Windows.Forms.Label lblNomeClienteFinan;
        private System.Windows.Forms.TextBox txtCodClienteFinan;
        private System.Windows.Forms.Label lblEmissaoFinan;
        private System.Windows.Forms.Label lblCodClienteFinan;
        private System.Windows.Forms.Label lblValorMinFinan;
        private System.Windows.Forms.Label lblStatusFinan;
        private System.Windows.Forms.ComboBox cmbStatusFinan;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtValorMinFinan;
        private System.Windows.Forms.Panel pnlCardAzul;
        private System.Windows.Forms.Panel pnlCardAmarelo;
        private System.Windows.Forms.Panel pnlCardVermelho;
        private System.Windows.Forms.Panel pnlCardVerde;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblLblTitulosFinan;
        private System.Windows.Forms.Label lblLblSaldo;
        private System.Windows.Forms.Label lblLblAReceber;
        private System.Windows.Forms.Label lblLblRecebido;
        private System.Windows.Forms.Label lblTotalTitulos;
        private System.Windows.Forms.Label lblTotalSaldo;
        private System.Windows.Forms.Label lblTotalAReceber;
        private System.Windows.Forms.Label lblTotalRecebido;
        private System.Windows.Forms.GroupBox grpTabela;
        private System.Windows.Forms.DataGridView dgvTitulos;
        private System.Windows.Forms.DateTimePicker dtpVencimentoFinalFinan;
    }
}