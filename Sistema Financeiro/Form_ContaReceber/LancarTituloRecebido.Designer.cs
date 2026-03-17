namespace Sistema_Financeiro.Form_ContaReceber
{
    partial class LancarTituloRecebido
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlSecTitle1 = new System.Windows.Forms.Label();
            this.pnlBusca = new System.Windows.Forms.Panel();
            this.lblIdTitulo = new System.Windows.Forms.Label();
            this.lblIdHint = new System.Windows.Forms.Label();
            this.Txt_IdTitulo = new System.Windows.Forms.TextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.pnlSecTitle2 = new System.Windows.Forms.Label();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.lblClienteHint = new System.Windows.Forms.Label();
            this.Txt_Cliente = new System.Windows.Forms.TextBox();
            this.pnlDadosRow = new System.Windows.Forms.Panel();
            this.pnlEmissao = new System.Windows.Forms.Panel();
            this.lblEmissaoHint = new System.Windows.Forms.Label();
            this.Txt_Emissao = new System.Windows.Forms.TextBox();
            this.pnlVencimento = new System.Windows.Forms.Panel();
            this.lblVencHint = new System.Windows.Forms.Label();
            this.Txt_Vencimento = new System.Windows.Forms.TextBox();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblStatusHint = new System.Windows.Forms.Label();
            this.Txt_Status = new System.Windows.Forms.TextBox();
            this.pnlSecTitle3 = new System.Windows.Forms.Label();
            this.pnlFinRow = new System.Windows.Forms.Panel();
            this.pnlAReceber = new System.Windows.Forms.Panel();
            this.lblAReceberHint = new System.Windows.Forms.Label();
            this.Txt_Receber = new System.Windows.Forms.TextBox();
            this.pnlRecebido = new System.Windows.Forms.Panel();
            this.lblRecebidoHint = new System.Windows.Forms.Label();
            this.Txt_Recebido = new System.Windows.Forms.TextBox();
            this.pnlSaldo = new System.Windows.Forms.Panel();
            this.lblSaldoHint = new System.Windows.Forms.Label();
            this.Txt_Diferenca = new System.Windows.Forms.TextBox();
            this.pnlUltPag = new System.Windows.Forms.Panel();
            this.lblUltPagHint = new System.Windows.Forms.Label();
            this.Txt_DataUltPag = new System.Windows.Forms.TextBox();
            this.pnlPagValor = new System.Windows.Forms.Panel();
            this.lblPagValor = new System.Windows.Forms.Label();
            this.lblPagValorHint = new System.Windows.Forms.Label();
            this.Txt_APagar = new System.Windows.Forms.TextBox();
            this.pnlPagData = new System.Windows.Forms.Panel();
            this.lblPagData = new System.Windows.Forms.Label();
            this.lblPagDataHint = new System.Windows.Forms.Label();
            this.Dtp_Pagamento = new System.Windows.Forms.DateTimePicker();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Btn_Registrar = new System.Windows.Forms.Button();
            this.pnlAccent = new System.Windows.Forms.Panel();
            this.pnlSep = new System.Windows.Forms.Panel();

            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlBusca.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.pnlDadosRow.SuspendLayout();
            this.pnlEmissao.SuspendLayout();
            this.pnlVencimento.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlFinRow.SuspendLayout();
            this.pnlAReceber.SuspendLayout();
            this.pnlRecebido.SuspendLayout();
            this.pnlSaldo.SuspendLayout();
            this.pnlUltPag.SuspendLayout();
            this.pnlPagValor.SuspendLayout();
            this.pnlPagData.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();

            // ── Cores e fontes ───────────────────────────────────────
            System.Drawing.Color corFundo = System.Drawing.Color.FromArgb(248, 249, 252);
            System.Drawing.Color corHeader = System.Drawing.Color.FromArgb(15, 23, 42);
            System.Drawing.Color corAccent = System.Drawing.Color.FromArgb(22, 163, 74);
            System.Drawing.Color corCard = System.Drawing.Color.White;
            System.Drawing.Color corBorda = System.Drawing.Color.FromArgb(226, 232, 240);
            System.Drawing.Color corTexto = System.Drawing.Color.FromArgb(30, 41, 59);
            System.Drawing.Color corHint = System.Drawing.Color.FromArgb(148, 163, 184);
            System.Drawing.Color corHintFraco = System.Drawing.Color.FromArgb(200, 210, 230);
            System.Drawing.Color corVerde = System.Drawing.Color.FromArgb(22, 101, 52);
            System.Drawing.Color corVermelho = System.Drawing.Color.FromArgb(185, 28, 28);
            System.Drawing.Color corAzulClaro = System.Drawing.Color.FromArgb(240, 242, 255);
            System.Drawing.Color corAmbar50 = System.Drawing.Color.FromArgb(255, 251, 235);
            System.Drawing.Color corAmbarText = System.Drawing.Color.FromArgb(146, 64, 14);
            System.Drawing.Color corVerdePag = System.Drawing.Color.FromArgb(240, 253, 244);
            System.Drawing.Color corIndigo = System.Drawing.Color.FromArgb(99, 102, 241);
            System.Drawing.Font fonteLabel = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fonteHint = new System.Drawing.Font("Segoe UI", 7.5F);
            System.Drawing.Font fonteInput = new System.Drawing.Font("Segoe UI", 10F);
            System.Drawing.Font fonteBold = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fonteMoney = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fonteSecao = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);

            // ── pnlAccent ────────────────────────────────────────────
            this.pnlAccent.BackColor = corAccent;
            this.pnlAccent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccent.Width = 5;
            this.pnlAccent.Name = "pnlAccent";

            // ── pnlHeader ────────────────────────────────────────────
            this.pnlHeader.BackColor = corHeader;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 72;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.lblTitulo);

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(24, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Receber Título";

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblSubtitulo.Location = new System.Drawing.Point(26, 46);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Text = "Contas a Receber  •  Registrar Pagamento";

            // ── pnlBody ──────────────────────────────────────────────
            this.pnlBody.BackColor = corFundo;
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.AutoScroll = true;
            this.pnlBody.Padding = new System.Windows.Forms.Padding(20, 12, 20, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Controls.Add(this.pnlPagData);
            this.pnlBody.Controls.Add(this.pnlPagValor);
            this.pnlBody.Controls.Add(this.pnlUltPag);
            this.pnlBody.Controls.Add(this.pnlFinRow);
            this.pnlBody.Controls.Add(this.pnlSecTitle3);
            this.pnlBody.Controls.Add(this.pnlDadosRow);
            this.pnlBody.Controls.Add(this.pnlCliente);
            this.pnlBody.Controls.Add(this.pnlSecTitle2);
            this.pnlBody.Controls.Add(this.pnlBusca);
            this.pnlBody.Controls.Add(this.pnlSecTitle1);

            // ── Seção 1 label ─────────────────────────────────────────
            this.pnlSecTitle1.AutoSize = true;
            this.pnlSecTitle1.Font = fonteSecao;
            this.pnlSecTitle1.ForeColor = corHint;
            this.pnlSecTitle1.Location = new System.Drawing.Point(20, 12);
            this.pnlSecTitle1.Name = "pnlSecTitle1";
            this.pnlSecTitle1.Text = "BUSCAR TÍTULO";

            // ── pnlBusca ──────────────────────────────────────────────
            this.pnlBusca.BackColor = corAmbar50;
            this.pnlBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBusca.Location = new System.Drawing.Point(20, 28);
            this.pnlBusca.Size = new System.Drawing.Size(375, 50);
            this.pnlBusca.Name = "pnlBusca";
            this.pnlBusca.Controls.Add(this.Btn_Buscar);
            this.pnlBusca.Controls.Add(this.Txt_IdTitulo);
            this.pnlBusca.Controls.Add(this.lblIdHint);
            this.pnlBusca.Controls.Add(this.lblIdTitulo);

            this.lblIdTitulo.AutoSize = true;
            this.lblIdTitulo.Font = fonteLabel;
            this.lblIdTitulo.ForeColor = corAmbarText;
            this.lblIdTitulo.Location = new System.Drawing.Point(12, 8);
            this.lblIdTitulo.Name = "lblIdTitulo";
            this.lblIdTitulo.Text = "ID DO TÍTULO";

            this.lblIdHint.AutoSize = true;
            this.lblIdHint.Font = fonteHint;
            this.lblIdHint.ForeColor = System.Drawing.Color.FromArgb(217, 119, 6);
            this.lblIdHint.Location = new System.Drawing.Point(102, 10);
            this.lblIdHint.Name = "lblIdHint";
            this.lblIdHint.Text = "informe o código";

            this.Txt_IdTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_IdTitulo.Font = fonteInput;
            this.Txt_IdTitulo.ForeColor = corAmbarText;
            this.Txt_IdTitulo.BackColor = corAmbar50;
            this.Txt_IdTitulo.Location = new System.Drawing.Point(12, 27);
            this.Txt_IdTitulo.Size = new System.Drawing.Size(240, 20);
            this.Txt_IdTitulo.TabIndex = 0;
            this.Txt_IdTitulo.Name = "Txt_IdTitulo";

            this.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.FlatAppearance.BorderSize = 0;
            this.Btn_Buscar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.Btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.Btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Buscar.Location = new System.Drawing.Point(288, 10);
            this.Btn_Buscar.Size = new System.Drawing.Size(80, 28);
            this.Btn_Buscar.TabIndex = 1;
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);

            // ── Seção 2 label ─────────────────────────────────────────
            this.pnlSecTitle2.AutoSize = true;
            this.pnlSecTitle2.Font = fonteSecao;
            this.pnlSecTitle2.ForeColor = corHint;
            this.pnlSecTitle2.Location = new System.Drawing.Point(20, 88);
            this.pnlSecTitle2.Name = "pnlSecTitle2";
            this.pnlSecTitle2.Text = "DADOS DO TÍTULO";

            // ── pnlCliente ────────────────────────────────────────────
            this.pnlCliente.BackColor = corAzulClaro;
            this.pnlCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCliente.Location = new System.Drawing.Point(20, 104);
            this.pnlCliente.Size = new System.Drawing.Size(375, 46);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Controls.Add(this.Txt_Cliente);
            this.pnlCliente.Controls.Add(this.lblClienteHint);

            this.lblClienteHint.AutoSize = true;
            this.lblClienteHint.Font = fonteLabel;
            this.lblClienteHint.ForeColor = corIndigo;
            this.lblClienteHint.Location = new System.Drawing.Point(12, 7);
            this.lblClienteHint.Name = "lblClienteHint";
            this.lblClienteHint.Text = "CLIENTE";

            this.Txt_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Cliente.Font = fonteBold;
            this.Txt_Cliente.ForeColor = corTexto;
            this.Txt_Cliente.BackColor = corAzulClaro;
            this.Txt_Cliente.ReadOnly = true;
            this.Txt_Cliente.TabStop = false;
            this.Txt_Cliente.Location = new System.Drawing.Point(12, 25);
            this.Txt_Cliente.Size = new System.Drawing.Size(348, 18);
            this.Txt_Cliente.Name = "Txt_Cliente";

            // ── pnlDadosRow: Emissão | Vencimento | Status ───────────
            this.pnlDadosRow.BackColor = corFundo;
            this.pnlDadosRow.Location = new System.Drawing.Point(20, 158);
            this.pnlDadosRow.Size = new System.Drawing.Size(375, 58);
            this.pnlDadosRow.Name = "pnlDadosRow";
            this.pnlDadosRow.Controls.Add(this.pnlStatus);
            this.pnlDadosRow.Controls.Add(this.pnlVencimento);
            this.pnlDadosRow.Controls.Add(this.pnlEmissao);

            // pnlEmissao
            this.pnlEmissao.BackColor = corCard;
            this.pnlEmissao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmissao.Location = new System.Drawing.Point(0, 0);
            this.pnlEmissao.Size = new System.Drawing.Size(118, 54);
            this.pnlEmissao.Name = "pnlEmissao";
            this.pnlEmissao.Controls.Add(this.Txt_Emissao);
            this.pnlEmissao.Controls.Add(this.lblEmissaoHint);

            this.lblEmissaoHint.AutoSize = true;
            this.lblEmissaoHint.Font = fonteLabel;
            this.lblEmissaoHint.ForeColor = corHint;
            this.lblEmissaoHint.Location = new System.Drawing.Point(9, 7);
            this.lblEmissaoHint.Name = "lblEmissaoHint";
            this.lblEmissaoHint.Text = "EMISSÃO";

            this.Txt_Emissao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Emissao.Font = fonteInput;
            this.Txt_Emissao.ForeColor = corTexto;
            this.Txt_Emissao.BackColor = corCard;
            this.Txt_Emissao.ReadOnly = true;
            this.Txt_Emissao.TabStop = false;
            this.Txt_Emissao.Location = new System.Drawing.Point(9, 27);
            this.Txt_Emissao.Size = new System.Drawing.Size(96, 18);
            this.Txt_Emissao.Name = "Txt_Emissao";

            // pnlVencimento
            this.pnlVencimento.BackColor = corCard;
            this.pnlVencimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVencimento.Location = new System.Drawing.Point(126, 0);
            this.pnlVencimento.Size = new System.Drawing.Size(124, 54);
            this.pnlVencimento.Name = "pnlVencimento";
            this.pnlVencimento.Controls.Add(this.Txt_Vencimento);
            this.pnlVencimento.Controls.Add(this.lblVencHint);

            this.lblVencHint.AutoSize = true;
            this.lblVencHint.Font = fonteLabel;
            this.lblVencHint.ForeColor = corHint;
            this.lblVencHint.Location = new System.Drawing.Point(9, 7);
            this.lblVencHint.Name = "lblVencHint";
            this.lblVencHint.Text = "VENCIMENTO";

            this.Txt_Vencimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Vencimento.Font = fonteInput;
            this.Txt_Vencimento.ForeColor = corTexto;
            this.Txt_Vencimento.BackColor = corCard;
            this.Txt_Vencimento.ReadOnly = true;
            this.Txt_Vencimento.TabStop = false;
            this.Txt_Vencimento.Location = new System.Drawing.Point(9, 27);
            this.Txt_Vencimento.Size = new System.Drawing.Size(102, 18);
            this.Txt_Vencimento.Name = "Txt_Vencimento";

            // pnlStatus
            this.pnlStatus.BackColor = corCard;
            this.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatus.Location = new System.Drawing.Point(258, 0);
            this.pnlStatus.Size = new System.Drawing.Size(117, 54);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Controls.Add(this.Txt_Status);
            this.pnlStatus.Controls.Add(this.lblStatusHint);

            this.lblStatusHint.AutoSize = true;
            this.lblStatusHint.Font = fonteLabel;
            this.lblStatusHint.ForeColor = corHint;
            this.lblStatusHint.Location = new System.Drawing.Point(9, 7);
            this.lblStatusHint.Name = "lblStatusHint";
            this.lblStatusHint.Text = "STATUS";

            this.Txt_Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Txt_Status.ForeColor = corTexto;
            this.Txt_Status.BackColor = corCard;
            this.Txt_Status.ReadOnly = true;
            this.Txt_Status.TabStop = false;
            this.Txt_Status.Location = new System.Drawing.Point(9, 27);
            this.Txt_Status.Size = new System.Drawing.Size(95, 18);
            this.Txt_Status.Name = "Txt_Status";

            // ── Seção 3 label ─────────────────────────────────────────
            this.pnlSecTitle3.AutoSize = true;
            this.pnlSecTitle3.Font = fonteSecao;
            this.pnlSecTitle3.ForeColor = corHint;
            this.pnlSecTitle3.Location = new System.Drawing.Point(20, 226);
            this.pnlSecTitle3.Name = "pnlSecTitle3";
            this.pnlSecTitle3.Text = "SITUAÇÃO FINANCEIRA";

            // ── pnlFinRow: A Receber | Recebido | Saldo ───────────────
            this.pnlFinRow.BackColor = corFundo;
            this.pnlFinRow.Location = new System.Drawing.Point(20, 242);
            this.pnlFinRow.Size = new System.Drawing.Size(375, 58);
            this.pnlFinRow.Name = "pnlFinRow";
            this.pnlFinRow.Controls.Add(this.pnlSaldo);
            this.pnlFinRow.Controls.Add(this.pnlRecebido);
            this.pnlFinRow.Controls.Add(this.pnlAReceber);

            // pnlAReceber
            this.pnlAReceber.BackColor = corCard;
            this.pnlAReceber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAReceber.Location = new System.Drawing.Point(0, 0);
            this.pnlAReceber.Size = new System.Drawing.Size(118, 54);
            this.pnlAReceber.Name = "pnlAReceber";
            this.pnlAReceber.Controls.Add(this.Txt_Receber);
            this.pnlAReceber.Controls.Add(this.lblAReceberHint);

            this.lblAReceberHint.AutoSize = true;
            this.lblAReceberHint.Font = fonteLabel;
            this.lblAReceberHint.ForeColor = corHint;
            this.lblAReceberHint.Location = new System.Drawing.Point(9, 7);
            this.lblAReceberHint.Name = "lblAReceberHint";
            this.lblAReceberHint.Text = "A RECEBER";

            this.Txt_Receber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Receber.Font = fonteBold;
            this.Txt_Receber.ForeColor = corTexto;
            this.Txt_Receber.BackColor = corCard;
            this.Txt_Receber.ReadOnly = true;
            this.Txt_Receber.TabStop = false;
            this.Txt_Receber.Location = new System.Drawing.Point(9, 27);
            this.Txt_Receber.Size = new System.Drawing.Size(96, 18);
            this.Txt_Receber.Name = "Txt_Receber";

            // pnlRecebido
            this.pnlRecebido.BackColor = corCard;
            this.pnlRecebido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRecebido.Location = new System.Drawing.Point(126, 0);
            this.pnlRecebido.Size = new System.Drawing.Size(124, 54);
            this.pnlRecebido.Name = "pnlRecebido";
            this.pnlRecebido.Controls.Add(this.Txt_Recebido);
            this.pnlRecebido.Controls.Add(this.lblRecebidoHint);

            this.lblRecebidoHint.AutoSize = true;
            this.lblRecebidoHint.Font = fonteLabel;
            this.lblRecebidoHint.ForeColor = corHint;
            this.lblRecebidoHint.Location = new System.Drawing.Point(9, 7);
            this.lblRecebidoHint.Name = "lblRecebidoHint";
            this.lblRecebidoHint.Text = "JÁ RECEBIDO";

            this.Txt_Recebido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Recebido.Font = fonteBold;
            this.Txt_Recebido.ForeColor = corVerde;
            this.Txt_Recebido.BackColor = corCard;
            this.Txt_Recebido.ReadOnly = true;
            this.Txt_Recebido.TabStop = false;
            this.Txt_Recebido.Location = new System.Drawing.Point(9, 27);
            this.Txt_Recebido.Size = new System.Drawing.Size(102, 18);
            this.Txt_Recebido.Name = "Txt_Recebido";

            // pnlSaldo
            this.pnlSaldo.BackColor = corCard;
            this.pnlSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSaldo.Location = new System.Drawing.Point(258, 0);
            this.pnlSaldo.Size = new System.Drawing.Size(117, 54);
            this.pnlSaldo.Name = "pnlSaldo";
            this.pnlSaldo.Controls.Add(this.Txt_Diferenca);
            this.pnlSaldo.Controls.Add(this.lblSaldoHint);

            this.lblSaldoHint.AutoSize = true;
            this.lblSaldoHint.Font = fonteLabel;
            this.lblSaldoHint.ForeColor = corHint;
            this.lblSaldoHint.Location = new System.Drawing.Point(9, 7);
            this.lblSaldoHint.Name = "lblSaldoHint";
            this.lblSaldoHint.Text = "SALDO";

            this.Txt_Diferenca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Diferenca.Font = fonteBold;
            this.Txt_Diferenca.ForeColor = corVermelho;
            this.Txt_Diferenca.BackColor = corCard;
            this.Txt_Diferenca.ReadOnly = true;
            this.Txt_Diferenca.TabStop = false;
            this.Txt_Diferenca.Location = new System.Drawing.Point(9, 27);
            this.Txt_Diferenca.Size = new System.Drawing.Size(95, 18);
            this.Txt_Diferenca.Name = "Txt_Diferenca";

            // ── pnlUltPag ─────────────────────────────────────────────
            this.pnlUltPag.BackColor = corCard;
            this.pnlUltPag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUltPag.Location = new System.Drawing.Point(20, 308);
            this.pnlUltPag.Size = new System.Drawing.Size(375, 46);
            this.pnlUltPag.Name = "pnlUltPag";
            this.pnlUltPag.Controls.Add(this.Txt_DataUltPag);
            this.pnlUltPag.Controls.Add(this.lblUltPagHint);

            this.lblUltPagHint.AutoSize = true;
            this.lblUltPagHint.Font = fonteLabel;
            this.lblUltPagHint.ForeColor = corHint;
            this.lblUltPagHint.Location = new System.Drawing.Point(12, 7);
            this.lblUltPagHint.Name = "lblUltPagHint";
            this.lblUltPagHint.Text = "DATA DO ÚLTIMO PAGAMENTO";

            this.Txt_DataUltPag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_DataUltPag.Font = fonteInput;
            this.Txt_DataUltPag.ForeColor = corTexto;
            this.Txt_DataUltPag.BackColor = corCard;
            this.Txt_DataUltPag.ReadOnly = true;
            this.Txt_DataUltPag.TabStop = false;
            this.Txt_DataUltPag.Location = new System.Drawing.Point(12, 25);
            this.Txt_DataUltPag.Size = new System.Drawing.Size(348, 18);
            this.Txt_DataUltPag.Name = "Txt_DataUltPag";

            // ── pnlPagValor ───────────────────────────────────────────
            this.pnlPagValor.BackColor = corVerdePag;
            this.pnlPagValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPagValor.Location = new System.Drawing.Point(20, 368);
            this.pnlPagValor.Size = new System.Drawing.Size(375, 58);
            this.pnlPagValor.Name = "pnlPagValor";
            this.pnlPagValor.Controls.Add(this.Txt_APagar);
            this.pnlPagValor.Controls.Add(this.lblPagValorHint);
            this.pnlPagValor.Controls.Add(this.lblPagValor);

            this.lblPagValor.AutoSize = true;
            this.lblPagValor.Font = fonteLabel;
            this.lblPagValor.ForeColor = corVerde;
            this.lblPagValor.Location = new System.Drawing.Point(12, 9);
            this.lblPagValor.Name = "lblPagValor";
            this.lblPagValor.Text = "VALOR DO PAGAMENTO (R$)";

            this.lblPagValorHint.AutoSize = true;
            this.lblPagValorHint.Font = fonteHint;
            this.lblPagValorHint.ForeColor = System.Drawing.Color.FromArgb(134, 239, 172);
            this.lblPagValorHint.Location = new System.Drawing.Point(192, 11);
            this.lblPagValorHint.Name = "lblPagValorHint";
            this.lblPagValorHint.Text = "ex: 650,00";

            this.Txt_APagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_APagar.Font = fonteMoney;
            this.Txt_APagar.ForeColor = corVerde;
            this.Txt_APagar.BackColor = corVerdePag;
            this.Txt_APagar.Location = new System.Drawing.Point(12, 30);
            this.Txt_APagar.Size = new System.Drawing.Size(348, 22);
            this.Txt_APagar.TabIndex = 2;
            this.Txt_APagar.Name = "Txt_APagar";
            this.Txt_APagar.TextChanged += new System.EventHandler(this.Txt_APagar_TextChanged);
            this.Txt_APagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_APagar_KeyPress);

            // ── pnlPagData ────────────────────────────────────────────
            this.pnlPagData.BackColor = corCard;
            this.pnlPagData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPagData.Location = new System.Drawing.Point(20, 434);
            this.pnlPagData.Size = new System.Drawing.Size(375, 58);
            this.pnlPagData.Name = "pnlPagData";
            this.pnlPagData.Controls.Add(this.Dtp_Pagamento);
            this.pnlPagData.Controls.Add(this.lblPagDataHint);
            this.pnlPagData.Controls.Add(this.lblPagData);

            this.lblPagData.AutoSize = true;
            this.lblPagData.Font = fonteLabel;
            this.lblPagData.ForeColor = corHint;
            this.lblPagData.Location = new System.Drawing.Point(12, 9);
            this.lblPagData.Name = "lblPagData";
            this.lblPagData.Text = "DATA DO PAGAMENTO";

            this.lblPagDataHint.AutoSize = true;
            this.lblPagDataHint.Font = fonteHint;
            this.lblPagDataHint.ForeColor = corHintFraco;
            this.lblPagDataHint.Location = new System.Drawing.Point(160, 11);
            this.lblPagDataHint.Name = "lblPagDataHint";
            this.lblPagDataHint.Text = "dd/MM/aaaa";

            this.Dtp_Pagamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_Pagamento.CustomFormat = "dd/MM/yyyy";
            this.Dtp_Pagamento.Font = fonteInput;
            this.Dtp_Pagamento.Location = new System.Drawing.Point(12, 30);
            this.Dtp_Pagamento.Size = new System.Drawing.Size(200, 24);
            this.Dtp_Pagamento.TabIndex = 3;
            this.Dtp_Pagamento.Name = "Dtp_Pagamento";

            // ── pnlSep ────────────────────────────────────────────────
            this.pnlSep.BackColor = corBorda;
            this.pnlSep.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSep.Height = 1;
            this.pnlSep.Name = "pnlSep";

            // ── pnlFooter ─────────────────────────────────────────────
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Height = 62;
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Controls.Add(this.Btn_Limpar);
            this.pnlFooter.Controls.Add(this.Btn_Registrar);

            this.Btn_Registrar.BackColor = corAccent;
            this.Btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Registrar.FlatAppearance.BorderSize = 0;
            this.Btn_Registrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Registrar.ForeColor = System.Drawing.Color.White;
            this.Btn_Registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Registrar.Location = new System.Drawing.Point(230, 11);
            this.Btn_Registrar.Size = new System.Drawing.Size(168, 38);
            this.Btn_Registrar.TabIndex = 5;
            this.Btn_Registrar.Name = "Btn_Registrar";
            this.Btn_Registrar.Text = "✓  Registrar Pagamento";
            this.Btn_Registrar.UseVisualStyleBackColor = false;
            this.Btn_Registrar.Click += new System.EventHandler(this.Btn_Registrar_Click);

            this.Btn_Limpar.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.Btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Limpar.FlatAppearance.BorderColor = corBorda;
            this.Btn_Limpar.FlatAppearance.BorderSize = 1;
            this.Btn_Limpar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Btn_Limpar.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.Btn_Limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Limpar.Location = new System.Drawing.Point(20, 11);
            this.Btn_Limpar.Size = new System.Drawing.Size(100, 38);
            this.Btn_Limpar.TabIndex = 4;
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = false;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);

            // ── Form ──────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = corFundo;
            this.ClientSize = new System.Drawing.Size(420, 640);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LancarTituloRecebido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receber Título — Sistema Financeiro";

            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlSep);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlAccent);

            this.Load += new System.EventHandler(this.LancarTituloRecebido_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlBusca.ResumeLayout(false);
            this.pnlBusca.PerformLayout();
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.pnlDadosRow.ResumeLayout(false);
            this.pnlEmissao.ResumeLayout(false);
            this.pnlEmissao.PerformLayout();
            this.pnlVencimento.ResumeLayout(false);
            this.pnlVencimento.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.pnlFinRow.ResumeLayout(false);
            this.pnlAReceber.ResumeLayout(false);
            this.pnlAReceber.PerformLayout();
            this.pnlRecebido.ResumeLayout(false);
            this.pnlRecebido.PerformLayout();
            this.pnlSaldo.ResumeLayout(false);
            this.pnlSaldo.PerformLayout();
            this.pnlUltPag.ResumeLayout(false);
            this.pnlUltPag.PerformLayout();
            this.pnlPagValor.ResumeLayout(false);
            this.pnlPagValor.PerformLayout();
            this.pnlPagData.ResumeLayout(false);
            this.pnlPagData.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader, pnlBody, pnlFooter, pnlAccent, pnlSep;
        private System.Windows.Forms.Panel pnlBusca, pnlCliente, pnlDadosRow;
        private System.Windows.Forms.Panel pnlEmissao, pnlVencimento, pnlStatus;
        private System.Windows.Forms.Panel pnlFinRow, pnlAReceber, pnlRecebido, pnlSaldo;
        private System.Windows.Forms.Panel pnlUltPag, pnlPagValor, pnlPagData;
        private System.Windows.Forms.Label lblTitulo, lblSubtitulo;
        private System.Windows.Forms.Label pnlSecTitle1, pnlSecTitle2, pnlSecTitle3;
        private System.Windows.Forms.Label lblIdTitulo, lblIdHint;
        private System.Windows.Forms.Label lblClienteHint;
        private System.Windows.Forms.Label lblEmissaoHint, lblVencHint, lblStatusHint;
        private System.Windows.Forms.Label lblAReceberHint, lblRecebidoHint, lblSaldoHint;
        private System.Windows.Forms.Label lblUltPagHint;
        private System.Windows.Forms.Label lblPagValor, lblPagValorHint;
        private System.Windows.Forms.Label lblPagData, lblPagDataHint;
        private System.Windows.Forms.TextBox Txt_IdTitulo, Txt_Cliente;
        private System.Windows.Forms.TextBox Txt_Emissao, Txt_Vencimento, Txt_Status;
        private System.Windows.Forms.TextBox Txt_Receber, Txt_Recebido, Txt_Diferenca;
        private System.Windows.Forms.TextBox Txt_DataUltPag, Txt_APagar;
        private System.Windows.Forms.DateTimePicker Dtp_Pagamento;
        private System.Windows.Forms.Button Btn_Buscar, Btn_Registrar, Btn_Limpar;
    }
}