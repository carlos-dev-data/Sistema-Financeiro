namespace Sistema_Financeiro.Form_Relatorios
{
    partial class TitulosAReceber
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblHeaderSub = new System.Windows.Forms.Label();
            this.pnlFiltros = new System.Windows.Forms.Panel();

            // filtros linha 1
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblIdTitulo = new System.Windows.Forms.Label();
            this.txtIdTitulo = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();

            // filtros linha 2
            this.lblEmissao = new System.Windows.Forms.Label();
            this.dtpEmissao = new System.Windows.Forms.DateTimePicker();
            this.lblVenc = new System.Windows.Forms.Label();
            this.dtpVencIni = new System.Windows.Forms.DateTimePicker();
            this.lblVencAte = new System.Windows.Forms.Label();
            this.dtpVencFim = new System.Windows.Forms.DateTimePicker();
            this.lblValorMin = new System.Windows.Forms.Label();
            this.txtValorMin = new System.Windows.Forms.TextBox();
            this.lblValorMax = new System.Windows.Forms.Label();
            this.txtValorMax = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();

            // totais
            this.pnlTotais = new System.Windows.Forms.Panel();
            this.pnlTotTitulos = new System.Windows.Forms.Panel();
            this.lblTotTitulosLbl = new System.Windows.Forms.Label();
            this.lblTotalTitulos = new System.Windows.Forms.Label();
            this.pnlTotAReceber = new System.Windows.Forms.Panel();
            this.lblTotAReceberLbl = new System.Windows.Forms.Label();
            this.lblTotalAReceber = new System.Windows.Forms.Label();
            this.pnlTotRecebido = new System.Windows.Forms.Panel();
            this.lblTotRecebidoLbl = new System.Windows.Forms.Label();
            this.lblTotalRecebido = new System.Windows.Forms.Label();
            this.pnlTotSaldo = new System.Windows.Forms.Panel();
            this.lblTotSaldoLbl = new System.Windows.Forms.Label();
            this.lblTotalSaldo = new System.Windows.Forms.Label();

            // painel de seleção + ações
            this.pnlSelecao = new System.Windows.Forms.Panel();
            this.lblSelTxt = new System.Windows.Forms.Label();
            this.lblSelInfo = new System.Windows.Forms.Label();
            this.btnReceber = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEstornar = new System.Windows.Forms.Button();

            // grid
            this.dgvTitulos = new System.Windows.Forms.DataGridView();

            this.pnlHeader.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.pnlTotais.SuspendLayout();
            this.pnlTotTitulos.SuspendLayout();
            this.pnlTotAReceber.SuspendLayout();
            this.pnlTotRecebido.SuspendLayout();
            this.pnlTotSaldo.SuspendLayout();
            this.pnlSelecao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).BeginInit();
            this.SuspendLayout();

            System.Drawing.Color corFundo = System.Drawing.Color.FromArgb(248, 249, 252);
            System.Drawing.Color corHeader = System.Drawing.Color.FromArgb(15, 23, 42);
            System.Drawing.Color corCard = System.Drawing.Color.White;
            System.Drawing.Color corBorda = System.Drawing.Color.FromArgb(226, 232, 240);
            System.Drawing.Color corTexto = System.Drawing.Color.FromArgb(30, 41, 59);
            System.Drawing.Color corMuted = System.Drawing.Color.FromArgb(100, 116, 139);
            System.Drawing.Color corIndigo = System.Drawing.Color.FromArgb(99, 102, 241);
            System.Drawing.Font fonteLabel = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fonteInput = new System.Drawing.Font("Segoe UI", 9F);
            System.Drawing.Font fonteTot = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);

            // ── pnlHeader ────────────────────────────────────────────
            this.pnlHeader.BackColor = corHeader;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 64;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Controls.Add(this.lblHeaderSub);
            this.pnlHeader.Controls.Add(this.lblHeader);

            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(24, 10);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Text = "Títulos a Receber";

            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblHeaderSub.Location = new System.Drawing.Point(26, 42);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Text = "Relatórios  •  Consulta e Ações";

            // ── pnlFiltros ────────────────────────────────────────────
            this.pnlFiltros.BackColor = corCard;
            this.pnlFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Height = 88;
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Padding = new System.Windows.Forms.Padding(16, 10, 16, 8);
            this.pnlFiltros.Controls.Add(this.btnLimpar);
            this.pnlFiltros.Controls.Add(this.btnBuscar);
            this.pnlFiltros.Controls.Add(this.txtValorMax);
            this.pnlFiltros.Controls.Add(this.lblValorMax);
            this.pnlFiltros.Controls.Add(this.txtValorMin);
            this.pnlFiltros.Controls.Add(this.lblValorMin);
            this.pnlFiltros.Controls.Add(this.dtpVencFim);
            this.pnlFiltros.Controls.Add(this.lblVencAte);
            this.pnlFiltros.Controls.Add(this.dtpVencIni);
            this.pnlFiltros.Controls.Add(this.lblVenc);
            this.pnlFiltros.Controls.Add(this.dtpEmissao);
            this.pnlFiltros.Controls.Add(this.lblEmissao);
            this.pnlFiltros.Controls.Add(this.cmbStatus);
            this.pnlFiltros.Controls.Add(this.lblStatus);
            this.pnlFiltros.Controls.Add(this.txtIdTitulo);
            this.pnlFiltros.Controls.Add(this.lblIdTitulo);
            this.pnlFiltros.Controls.Add(this.txtNomeCliente);
            this.pnlFiltros.Controls.Add(this.lblNomeCliente);
            this.pnlFiltros.Controls.Add(this.txtCodCliente);
            this.pnlFiltros.Controls.Add(this.lblCodCliente);

            // linha 1 de filtros (y=10)
            // Cód. Cliente
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Font = fonteLabel;
            this.lblCodCliente.ForeColor = corMuted;
            this.lblCodCliente.Location = new System.Drawing.Point(16, 10);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Text = "CÓD. CLIENTE";

            this.txtCodCliente.Font = fonteInput;
            this.txtCodCliente.Location = new System.Drawing.Point(16, 26);
            this.txtCodCliente.Size = new System.Drawing.Size(80, 24);
            this.txtCodCliente.Name = "txtCodCliente";

            // Nome Cliente
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = fonteLabel;
            this.lblNomeCliente.ForeColor = corMuted;
            this.lblNomeCliente.Location = new System.Drawing.Point(106, 10);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Text = "NOME DO CLIENTE";

            this.txtNomeCliente.Font = fonteInput;
            this.txtNomeCliente.Location = new System.Drawing.Point(106, 26);
            this.txtNomeCliente.Size = new System.Drawing.Size(200, 24);
            this.txtNomeCliente.Name = "txtNomeCliente";

            // ID Título
            this.lblIdTitulo.AutoSize = true;
            this.lblIdTitulo.Font = fonteLabel;
            this.lblIdTitulo.ForeColor = corMuted;
            this.lblIdTitulo.Location = new System.Drawing.Point(316, 10);
            this.lblIdTitulo.Name = "lblIdTitulo";
            this.lblIdTitulo.Text = "ID TÍTULO";

            this.txtIdTitulo.Font = fonteInput;
            this.txtIdTitulo.Location = new System.Drawing.Point(316, 26);
            this.txtIdTitulo.Size = new System.Drawing.Size(80, 24);
            this.txtIdTitulo.Name = "txtIdTitulo";

            // Status
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = fonteLabel;
            this.lblStatus.ForeColor = corMuted;
            this.lblStatus.Location = new System.Drawing.Point(406, 10);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Text = "STATUS";

            this.cmbStatus.Font = fonteInput;
            this.cmbStatus.Location = new System.Drawing.Point(406, 25);
            this.cmbStatus.Size = new System.Drawing.Size(130, 24);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // linha 2 de filtros (y=55)
            // Emissão
            this.lblEmissao.AutoSize = true;
            this.lblEmissao.Font = fonteLabel;
            this.lblEmissao.ForeColor = corMuted;
            this.lblEmissao.Location = new System.Drawing.Point(16, 55);
            this.lblEmissao.Name = "lblEmissao";
            this.lblEmissao.Text = "EMISSÃO";

            this.dtpEmissao.Font = fonteInput;
            this.dtpEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmissao.ShowCheckBox = true;
            this.dtpEmissao.Checked = false;
            this.dtpEmissao.Location = new System.Drawing.Point(70, 52);
            this.dtpEmissao.Size = new System.Drawing.Size(120, 24);
            this.dtpEmissao.Name = "dtpEmissao";

            // Venc. De
            this.lblVenc.AutoSize = true;
            this.lblVenc.Font = fonteLabel;
            this.lblVenc.ForeColor = corMuted;
            this.lblVenc.Location = new System.Drawing.Point(200, 55);
            this.lblVenc.Name = "lblVenc";
            this.lblVenc.Text = "VENC. DE";

            this.dtpVencIni.Font = fonteInput;
            this.dtpVencIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencIni.ShowCheckBox = true;
            this.dtpVencIni.Checked = false;
            this.dtpVencIni.Location = new System.Drawing.Point(260, 52);
            this.dtpVencIni.Size = new System.Drawing.Size(120, 24);
            this.dtpVencIni.Name = "dtpVencIni";

            // Venc. Até
            this.lblVencAte.AutoSize = true;
            this.lblVencAte.Font = fonteLabel;
            this.lblVencAte.ForeColor = corMuted;
            this.lblVencAte.Location = new System.Drawing.Point(388, 55);
            this.lblVencAte.Name = "lblVencAte";
            this.lblVencAte.Text = "ATÉ";

            this.dtpVencFim.Font = fonteInput;
            this.dtpVencFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencFim.ShowCheckBox = true;
            this.dtpVencFim.Checked = false;
            this.dtpVencFim.Location = new System.Drawing.Point(410, 52);
            this.dtpVencFim.Size = new System.Drawing.Size(120, 24);
            this.dtpVencFim.Name = "dtpVencFim";

            // Valor Min
            this.lblValorMin.AutoSize = true;
            this.lblValorMin.Font = fonteLabel;
            this.lblValorMin.ForeColor = corMuted;
            this.lblValorMin.Location = new System.Drawing.Point(540, 55);
            this.lblValorMin.Name = "lblValorMin";
            this.lblValorMin.Text = "VALOR MÍN.";

            this.txtValorMin.Font = fonteInput;
            this.txtValorMin.Location = new System.Drawing.Point(620, 52);
            this.txtValorMin.Size = new System.Drawing.Size(90, 24);
            this.txtValorMin.Name = "txtValorMin";

            // Valor Max
            this.lblValorMax.AutoSize = true;
            this.lblValorMax.Font = fonteLabel;
            this.lblValorMax.ForeColor = corMuted;
            this.lblValorMax.Location = new System.Drawing.Point(720, 55);
            this.lblValorMax.Name = "lblValorMax";
            this.lblValorMax.Text = "VALOR MÁX.";

            this.txtValorMax.Font = fonteInput;
            this.txtValorMax.Location = new System.Drawing.Point(800, 52);
            this.txtValorMax.Size = new System.Drawing.Size(90, 24);
            this.txtValorMax.Name = "txtValorMax";

            // Botões filtro
            this.btnBuscar.BackColor = corIndigo;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(906, 24);
            this.btnBuscar.Size = new System.Drawing.Size(90, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.FlatAppearance.BorderColor = corBorda;
            this.btnLimpar.FlatAppearance.BorderSize = 1;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLimpar.ForeColor = corTexto;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(906, 54);
            this.btnLimpar.Size = new System.Drawing.Size(90, 26);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);

            // ── pnlTotais ─────────────────────────────────────────────
            this.pnlTotais.BackColor = corFundo;
            this.pnlTotais.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTotais.Height = 68;
            this.pnlTotais.Name = "pnlTotais";
            this.pnlTotais.Padding = new System.Windows.Forms.Padding(16, 10, 16, 8);
            this.pnlTotais.Controls.Add(this.pnlTotSaldo);
            this.pnlTotais.Controls.Add(this.pnlTotRecebido);
            this.pnlTotais.Controls.Add(this.pnlTotAReceber);
            this.pnlTotais.Controls.Add(this.pnlTotTitulos);

            // ── Card TÍTULOS ──────────────────────────────────────────
            this.pnlTotTitulos.BackColor = corCard;
            this.pnlTotTitulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotTitulos.Location = new System.Drawing.Point(16, 10);
            this.pnlTotTitulos.Size = new System.Drawing.Size(200, 46);
            this.pnlTotTitulos.Name = "pnlTotTitulos";
            this.pnlTotTitulos.Controls.Add(this.lblTotTitulosLbl);
            this.pnlTotTitulos.Controls.Add(this.lblTotalTitulos);

            this.lblTotTitulosLbl.AutoSize = true;
            this.lblTotTitulosLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTotTitulosLbl.ForeColor = corMuted;
            this.lblTotTitulosLbl.Location = new System.Drawing.Point(10, 6);
            this.lblTotTitulosLbl.Name = "lblTotTitulosLbl";
            this.lblTotTitulosLbl.Text = "TÍTULOS";

            this.lblTotalTitulos.AutoSize = true;
            this.lblTotalTitulos.Font = fonteTot;
            this.lblTotalTitulos.ForeColor = corTexto;
            this.lblTotalTitulos.Location = new System.Drawing.Point(8, 20);
            this.lblTotalTitulos.Name = "lblTotalTitulos";
            this.lblTotalTitulos.Text = "0";

            // ── Card TOTAL A RECEBER ──────────────────────────────────
            this.pnlTotAReceber.BackColor = corCard;
            this.pnlTotAReceber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotAReceber.Location = new System.Drawing.Point(228, 10);
            this.pnlTotAReceber.Size = new System.Drawing.Size(200, 46);
            this.pnlTotAReceber.Name = "pnlTotAReceber";
            this.pnlTotAReceber.Controls.Add(this.lblTotAReceberLbl);
            this.pnlTotAReceber.Controls.Add(this.lblTotalAReceber);

            this.lblTotAReceberLbl.AutoSize = true;
            this.lblTotAReceberLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTotAReceberLbl.ForeColor = corMuted;
            this.lblTotAReceberLbl.Location = new System.Drawing.Point(10, 6);
            this.lblTotAReceberLbl.Name = "lblTotAReceberLbl";
            this.lblTotAReceberLbl.Text = "TOTAL A RECEBER";

            this.lblTotalAReceber.AutoSize = true;
            this.lblTotalAReceber.Font = fonteTot;
            this.lblTotalAReceber.ForeColor = corTexto;
            this.lblTotalAReceber.Location = new System.Drawing.Point(8, 20);
            this.lblTotalAReceber.Name = "lblTotalAReceber";
            this.lblTotalAReceber.Text = "R$ 0,00";

            // ── Card TOTAL RECEBIDO ───────────────────────────────────
            this.pnlTotRecebido.BackColor = corCard;
            this.pnlTotRecebido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotRecebido.Location = new System.Drawing.Point(440, 10);
            this.pnlTotRecebido.Size = new System.Drawing.Size(200, 46);
            this.pnlTotRecebido.Name = "pnlTotRecebido";
            this.pnlTotRecebido.Controls.Add(this.lblTotRecebidoLbl);
            this.pnlTotRecebido.Controls.Add(this.lblTotalRecebido);

            this.lblTotRecebidoLbl.AutoSize = true;
            this.lblTotRecebidoLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTotRecebidoLbl.ForeColor = corMuted;
            this.lblTotRecebidoLbl.Location = new System.Drawing.Point(10, 6);
            this.lblTotRecebidoLbl.Name = "lblTotRecebidoLbl";
            this.lblTotRecebidoLbl.Text = "TOTAL RECEBIDO";

            this.lblTotalRecebido.AutoSize = true;
            this.lblTotalRecebido.Font = fonteTot;
            this.lblTotalRecebido.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52);
            this.lblTotalRecebido.Location = new System.Drawing.Point(8, 20);
            this.lblTotalRecebido.Name = "lblTotalRecebido";
            this.lblTotalRecebido.Text = "R$ 0,00";

            // ── Card SALDO PENDENTE ───────────────────────────────────
            this.pnlTotSaldo.BackColor = corCard;
            this.pnlTotSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotSaldo.Location = new System.Drawing.Point(652, 10);
            this.pnlTotSaldo.Size = new System.Drawing.Size(200, 46);
            this.pnlTotSaldo.Name = "pnlTotSaldo";
            this.pnlTotSaldo.Controls.Add(this.lblTotSaldoLbl);
            this.pnlTotSaldo.Controls.Add(this.lblTotalSaldo);

            this.lblTotSaldoLbl.AutoSize = true;
            this.lblTotSaldoLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTotSaldoLbl.ForeColor = corMuted;
            this.lblTotSaldoLbl.Location = new System.Drawing.Point(10, 6);
            this.lblTotSaldoLbl.Name = "lblTotSaldoLbl";
            this.lblTotSaldoLbl.Text = "SALDO PENDENTE";

            this.lblTotalSaldo.AutoSize = true;
            this.lblTotalSaldo.Font = fonteTot;
            this.lblTotalSaldo.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.lblTotalSaldo.Location = new System.Drawing.Point(8, 20);
            this.lblTotalSaldo.Name = "lblTotalSaldo";
            this.lblTotalSaldo.Text = "R$ 0,00";

            // ── pnlSelecao (ações) ────────────────────────────────────
            this.pnlSelecao.BackColor = System.Drawing.Color.FromArgb(238, 242, 255);
            this.pnlSelecao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelecao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSelecao.Height = 52;
            this.pnlSelecao.Name = "pnlSelecao";
            this.pnlSelecao.Visible = false;
            this.pnlSelecao.Controls.Add(this.btnEstornar);
            this.pnlSelecao.Controls.Add(this.btnEditar);
            this.pnlSelecao.Controls.Add(this.btnReceber);
            this.pnlSelecao.Controls.Add(this.lblSelInfo);
            this.pnlSelecao.Controls.Add(this.lblSelTxt);

            this.lblSelTxt.AutoSize = true;
            this.lblSelTxt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSelTxt.ForeColor = System.Drawing.Color.FromArgb(99, 102, 241);
            this.lblSelTxt.Location = new System.Drawing.Point(12, 8);
            this.lblSelTxt.Name = "lblSelTxt";
            this.lblSelTxt.Text = "SELECIONADO";

            this.lblSelInfo.AutoSize = false;
            this.lblSelInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSelInfo.ForeColor = corTexto;
            this.lblSelInfo.Location = new System.Drawing.Point(12, 24);
            this.lblSelInfo.Size = new System.Drawing.Size(650, 18);
            this.lblSelInfo.Name = "lblSelInfo";
            this.lblSelInfo.Text = "";

            // Btn Receber
            this.btnReceber.BackColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnReceber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceber.FlatAppearance.BorderSize = 0;
            this.btnReceber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReceber.ForeColor = System.Drawing.Color.White;
            this.btnReceber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceber.Enabled = false;
            this.btnReceber.Location = new System.Drawing.Point(670, 10);
            this.btnReceber.Size = new System.Drawing.Size(120, 30);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Text = "✓  Receber";
            this.btnReceber.UseVisualStyleBackColor = false;
            this.btnReceber.Click += new System.EventHandler(this.btnReceber_Click);

            // Btn Editar
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(800, 10);
            this.btnEditar.Size = new System.Drawing.Size(100, 30);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Text = "✎  Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);

            // Btn Estornar
            this.btnEstornar.BackColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnEstornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstornar.FlatAppearance.BorderSize = 0;
            this.btnEstornar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEstornar.ForeColor = System.Drawing.Color.White;
            this.btnEstornar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstornar.Enabled = false;
            this.btnEstornar.Location = new System.Drawing.Point(910, 10);
            this.btnEstornar.Size = new System.Drawing.Size(110, 30);
            this.btnEstornar.Name = "btnEstornar";
            this.btnEstornar.Text = "↩  Estornar";
            this.btnEstornar.UseVisualStyleBackColor = false;
            this.btnEstornar.Click += new System.EventHandler(this.btnEstornar_Click);

            // ── dgvTitulos ────────────────────────────────────────────
            this.dgvTitulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTitulos.Name = "dgvTitulos";
            this.dgvTitulos.TabIndex = 0;

            // ── Form ──────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = corFundo;
            this.ClientSize = new System.Drawing.Size(1050, 680);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TitulosAReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Títulos a Receber — Sistema Financeiro";

            this.Controls.Add(this.dgvTitulos);
            this.Controls.Add(this.pnlSelecao);
            this.Controls.Add(this.pnlTotais);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.pnlHeader);

            this.Load += new System.EventHandler(this.TitulosAReceber_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.pnlTotais.ResumeLayout(false);
            this.pnlTotTitulos.ResumeLayout(false);
            this.pnlTotTitulos.PerformLayout();
            this.pnlTotAReceber.ResumeLayout(false);
            this.pnlTotAReceber.PerformLayout();
            this.pnlTotRecebido.ResumeLayout(false);
            this.pnlTotRecebido.PerformLayout();
            this.pnlTotSaldo.ResumeLayout(false);
            this.pnlTotSaldo.PerformLayout();
            this.pnlSelecao.ResumeLayout(false);
            this.pnlSelecao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader, pnlFiltros, pnlTotais, pnlSelecao;
        private System.Windows.Forms.Label lblHeader, lblHeaderSub;
        private System.Windows.Forms.Label lblCodCliente, lblNomeCliente, lblIdTitulo, lblStatus;
        private System.Windows.Forms.Label lblEmissao, lblVenc, lblVencAte, lblValorMin, lblValorMax;
        private System.Windows.Forms.TextBox txtCodCliente, txtNomeCliente, txtIdTitulo;
        private System.Windows.Forms.TextBox txtValorMin, txtValorMax;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker dtpEmissao, dtpVencIni, dtpVencFim;
        private System.Windows.Forms.Button btnBuscar, btnLimpar;
        private System.Windows.Forms.Panel pnlTotTitulos, pnlTotAReceber, pnlTotRecebido, pnlTotSaldo;
        private System.Windows.Forms.Label lblTotTitulosLbl, lblTotAReceberLbl, lblTotRecebidoLbl, lblTotSaldoLbl;
        private System.Windows.Forms.Label lblTotalTitulos, lblTotalAReceber, lblTotalRecebido, lblTotalSaldo;
        private System.Windows.Forms.Label lblSelTxt, lblSelInfo;
        private System.Windows.Forms.Button btnReceber, btnEditar, btnEstornar;
        private System.Windows.Forms.DataGridView dgvTitulos;
    }
}