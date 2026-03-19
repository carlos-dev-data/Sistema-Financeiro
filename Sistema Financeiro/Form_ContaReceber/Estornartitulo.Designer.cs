namespace Sistema_Financeiro.Form_ContaReceber
{
    partial class EstornarTitulo
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
            this.pnlBusca = new System.Windows.Forms.Panel();
            this.lblIdTitulo = new System.Windows.Forms.Label();
            this.lblIdHint = new System.Windows.Forms.Label();
            this.Txt_IdTitulo = new System.Windows.Forms.TextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.pnlSecDados = new System.Windows.Forms.Label();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.lblClienteHint = new System.Windows.Forms.Label();
            this.Txt_Cliente = new System.Windows.Forms.TextBox();
            this.pnlInfoRow = new System.Windows.Forms.Panel();
            this.pnlEmissao = new System.Windows.Forms.Panel();
            this.lblEmissaoHint = new System.Windows.Forms.Label();
            this.Txt_Emissao = new System.Windows.Forms.TextBox();
            this.pnlVencimento = new System.Windows.Forms.Panel();
            this.lblVencHint = new System.Windows.Forms.Label();
            this.Txt_Vencimento = new System.Windows.Forms.TextBox();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblStatusHint = new System.Windows.Forms.Label();
            this.Txt_Status = new System.Windows.Forms.TextBox();
            this.pnlSecFinanceiro = new System.Windows.Forms.Label();
            this.pnlFinRow = new System.Windows.Forms.Panel();
            this.pnlAReceber = new System.Windows.Forms.Panel();
            this.lblAReceberHint = new System.Windows.Forms.Label();
            this.Txt_AReceber = new System.Windows.Forms.TextBox();
            this.pnlRecebido = new System.Windows.Forms.Panel();
            this.lblRecebidoHint = new System.Windows.Forms.Label();
            this.Txt_Recebido = new System.Windows.Forms.TextBox();
            this.pnlSaldo = new System.Windows.Forms.Panel();
            this.lblSaldoHint = new System.Windows.Forms.Label();
            this.Txt_Saldo = new System.Windows.Forms.TextBox();
            this.pnlSecEstorno = new System.Windows.Forms.Label();
            this.pnlEstornoValor = new System.Windows.Forms.Panel();
            this.lblEstornoValor = new System.Windows.Forms.Label();
            this.lblEstornoHint = new System.Windows.Forms.Label();
            this.Txt_ValorEstorno = new System.Windows.Forms.TextBox();
            this.pnlAviso = new System.Windows.Forms.Panel();
            this.lblAvisoIcon = new System.Windows.Forms.Label();
            this.lblAvisoTxt = new System.Windows.Forms.Label();
            this.pnlSep = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Btn_Estornar = new System.Windows.Forms.Button();
            this.pnlAccent = new System.Windows.Forms.Panel();

            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlBusca.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.pnlInfoRow.SuspendLayout();
            this.pnlEmissao.SuspendLayout();
            this.pnlVencimento.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlFinRow.SuspendLayout();
            this.pnlAReceber.SuspendLayout();
            this.pnlRecebido.SuspendLayout();
            this.pnlSaldo.SuspendLayout();
            this.pnlEstornoValor.SuspendLayout();
            this.pnlAviso.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();

            // ── Paleta ───────────────────────────────────────────────
            System.Drawing.Color corFundo = System.Drawing.Color.FromArgb(248, 249, 252);
            System.Drawing.Color corHeader = System.Drawing.Color.FromArgb(15, 23, 42);
            System.Drawing.Color corAccent = System.Drawing.Color.FromArgb(220, 38, 38);  // vermelho — estorno
            System.Drawing.Color corCard = System.Drawing.Color.White;
            System.Drawing.Color corBorda = System.Drawing.Color.FromArgb(226, 232, 240);
            System.Drawing.Color corTexto = System.Drawing.Color.FromArgb(30, 41, 59);
            System.Drawing.Color corHint = System.Drawing.Color.FromArgb(148, 163, 184);
            System.Drawing.Color corHintFraco = System.Drawing.Color.FromArgb(200, 210, 230);
            System.Drawing.Color corVerde = System.Drawing.Color.FromArgb(22, 101, 52);
            System.Drawing.Color corVermelho = System.Drawing.Color.FromArgb(185, 28, 28);
            System.Drawing.Color corAmbar50 = System.Drawing.Color.FromArgb(255, 251, 235);
            System.Drawing.Color corAmbarText = System.Drawing.Color.FromArgb(146, 64, 14);
            System.Drawing.Color corAzulClaro = System.Drawing.Color.FromArgb(240, 242, 255);
            System.Drawing.Color corVermBg = System.Drawing.Color.FromArgb(254, 242, 242);
            System.Drawing.Color corVermBorda = System.Drawing.Color.FromArgb(254, 202, 202);

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
            this.lblTitulo.Text = "Estornar Pagamento";

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblSubtitulo.Location = new System.Drawing.Point(26, 46);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Text = "Contas a Receber  •  Reverter Pagamento";

            // ── pnlBody ──────────────────────────────────────────────
            this.pnlBody.BackColor = corFundo;
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.AutoScroll = true;
            this.pnlBody.Padding = new System.Windows.Forms.Padding(20, 12, 20, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Controls.Add(this.pnlAviso);
            this.pnlBody.Controls.Add(this.pnlEstornoValor);
            this.pnlBody.Controls.Add(this.pnlSecEstorno);
            this.pnlBody.Controls.Add(this.pnlFinRow);
            this.pnlBody.Controls.Add(this.pnlSecFinanceiro);
            this.pnlBody.Controls.Add(this.pnlInfoRow);
            this.pnlBody.Controls.Add(this.pnlCliente);
            this.pnlBody.Controls.Add(this.pnlSecDados);
            this.pnlBody.Controls.Add(this.pnlBusca);

            // ── Seção Busca ───────────────────────────────────────────
            this.pnlBusca.BackColor = corAmbar50;
            this.pnlBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBusca.Location = new System.Drawing.Point(20, 12);
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

            // ── Seção Dados label ─────────────────────────────────────
            this.pnlSecDados.AutoSize = true;
            this.pnlSecDados.Font = fonteSecao;
            this.pnlSecDados.ForeColor = corHint;
            this.pnlSecDados.Location = new System.Drawing.Point(20, 72);
            this.pnlSecDados.Name = "pnlSecDados";
            this.pnlSecDados.Text = "DADOS DO TÍTULO";

            // ── pnlCliente ────────────────────────────────────────────
            this.pnlCliente.BackColor = corAzulClaro;
            this.pnlCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCliente.Location = new System.Drawing.Point(20, 88);
            this.pnlCliente.Size = new System.Drawing.Size(375, 46);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Controls.Add(this.Txt_Cliente);
            this.pnlCliente.Controls.Add(this.lblClienteHint);

            this.lblClienteHint.AutoSize = true;
            this.lblClienteHint.Font = fonteLabel;
            this.lblClienteHint.ForeColor = System.Drawing.Color.FromArgb(99, 102, 241);
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

            // ── pnlInfoRow (Emissão | Vencimento | Status) ────────────
            this.pnlInfoRow.BackColor = corFundo;
            this.pnlInfoRow.Location = new System.Drawing.Point(20, 142);
            this.pnlInfoRow.Size = new System.Drawing.Size(375, 54);
            this.pnlInfoRow.Name = "pnlInfoRow";
            this.pnlInfoRow.Controls.Add(this.pnlStatus);
            this.pnlInfoRow.Controls.Add(this.pnlVencimento);
            this.pnlInfoRow.Controls.Add(this.pnlEmissao);

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

            // ── Seção Financeiro label ────────────────────────────────
            this.pnlSecFinanceiro.AutoSize = true;
            this.pnlSecFinanceiro.Font = fonteSecao;
            this.pnlSecFinanceiro.ForeColor = corHint;
            this.pnlSecFinanceiro.Location = new System.Drawing.Point(20, 206);
            this.pnlSecFinanceiro.Name = "pnlSecFinanceiro";
            this.pnlSecFinanceiro.Text = "SITUAÇÃO FINANCEIRA";

            // ── pnlFinRow (A Receber | Recebido | Saldo) ──────────────
            this.pnlFinRow.BackColor = corFundo;
            this.pnlFinRow.Location = new System.Drawing.Point(20, 222);
            this.pnlFinRow.Size = new System.Drawing.Size(375, 54);
            this.pnlFinRow.Name = "pnlFinRow";
            this.pnlFinRow.Controls.Add(this.pnlSaldo);
            this.pnlFinRow.Controls.Add(this.pnlRecebido);
            this.pnlFinRow.Controls.Add(this.pnlAReceber);

            this.pnlAReceber.BackColor = corCard;
            this.pnlAReceber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAReceber.Location = new System.Drawing.Point(0, 0);
            this.pnlAReceber.Size = new System.Drawing.Size(118, 54);
            this.pnlAReceber.Name = "pnlAReceber";
            this.pnlAReceber.Controls.Add(this.Txt_AReceber);
            this.pnlAReceber.Controls.Add(this.lblAReceberHint);

            this.lblAReceberHint.AutoSize = true;
            this.lblAReceberHint.Font = fonteLabel;
            this.lblAReceberHint.ForeColor = corHint;
            this.lblAReceberHint.Location = new System.Drawing.Point(9, 7);
            this.lblAReceberHint.Name = "lblAReceberHint";
            this.lblAReceberHint.Text = "A RECEBER";

            this.Txt_AReceber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_AReceber.Font = fonteBold;
            this.Txt_AReceber.ForeColor = corTexto;
            this.Txt_AReceber.BackColor = corCard;
            this.Txt_AReceber.ReadOnly = true;
            this.Txt_AReceber.TabStop = false;
            this.Txt_AReceber.Location = new System.Drawing.Point(9, 27);
            this.Txt_AReceber.Size = new System.Drawing.Size(96, 18);
            this.Txt_AReceber.Name = "Txt_AReceber";

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
            this.Txt_Recebido.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52);
            this.Txt_Recebido.BackColor = corCard;
            this.Txt_Recebido.ReadOnly = true;
            this.Txt_Recebido.TabStop = false;
            this.Txt_Recebido.Location = new System.Drawing.Point(9, 27);
            this.Txt_Recebido.Size = new System.Drawing.Size(102, 18);
            this.Txt_Recebido.Name = "Txt_Recebido";

            this.pnlSaldo.BackColor = corCard;
            this.pnlSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSaldo.Location = new System.Drawing.Point(258, 0);
            this.pnlSaldo.Size = new System.Drawing.Size(117, 54);
            this.pnlSaldo.Name = "pnlSaldo";
            this.pnlSaldo.Controls.Add(this.Txt_Saldo);
            this.pnlSaldo.Controls.Add(this.lblSaldoHint);

            this.lblSaldoHint.AutoSize = true;
            this.lblSaldoHint.Font = fonteLabel;
            this.lblSaldoHint.ForeColor = corHint;
            this.lblSaldoHint.Location = new System.Drawing.Point(9, 7);
            this.lblSaldoHint.Name = "lblSaldoHint";
            this.lblSaldoHint.Text = "SALDO";

            this.Txt_Saldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Saldo.Font = fonteBold;
            this.Txt_Saldo.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.Txt_Saldo.BackColor = corCard;
            this.Txt_Saldo.ReadOnly = true;
            this.Txt_Saldo.TabStop = false;
            this.Txt_Saldo.Location = new System.Drawing.Point(9, 27);
            this.Txt_Saldo.Size = new System.Drawing.Size(95, 18);
            this.Txt_Saldo.Name = "Txt_Saldo";

            // ── Seção Estorno label ───────────────────────────────────
            this.pnlSecEstorno.AutoSize = true;
            this.pnlSecEstorno.Font = fonteSecao;
            this.pnlSecEstorno.ForeColor = corHint;
            this.pnlSecEstorno.Location = new System.Drawing.Point(20, 286);
            this.pnlSecEstorno.Name = "pnlSecEstorno";
            this.pnlSecEstorno.Text = "ESTORNO";

            // ── pnlEstornoValor ───────────────────────────────────────
            this.pnlEstornoValor.BackColor = corVermBg;
            this.pnlEstornoValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEstornoValor.Location = new System.Drawing.Point(20, 302);
            this.pnlEstornoValor.Size = new System.Drawing.Size(375, 58);
            this.pnlEstornoValor.Name = "pnlEstornoValor";
            this.pnlEstornoValor.Controls.Add(this.Txt_ValorEstorno);
            this.pnlEstornoValor.Controls.Add(this.lblEstornoHint);
            this.pnlEstornoValor.Controls.Add(this.lblEstornoValor);

            this.lblEstornoValor.AutoSize = true;
            this.lblEstornoValor.Font = fonteLabel;
            this.lblEstornoValor.ForeColor = corVermelho;
            this.lblEstornoValor.Location = new System.Drawing.Point(12, 9);
            this.lblEstornoValor.Name = "lblEstornoValor";
            this.lblEstornoValor.Text = "VALOR DO ESTORNO (R$)";

            this.lblEstornoHint.AutoSize = true;
            this.lblEstornoHint.Font = fonteHint;
            this.lblEstornoHint.ForeColor = System.Drawing.Color.FromArgb(252, 165, 165);
            this.lblEstornoHint.Location = new System.Drawing.Point(188, 11);
            this.lblEstornoHint.Name = "lblEstornoHint";
            this.lblEstornoHint.Text = "deixe vazio para estorno total";

            this.Txt_ValorEstorno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_ValorEstorno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_ValorEstorno.ForeColor = corVermelho;
            this.Txt_ValorEstorno.BackColor = corVermBg;
            this.Txt_ValorEstorno.Location = new System.Drawing.Point(12, 30);
            this.Txt_ValorEstorno.Size = new System.Drawing.Size(348, 22);
            this.Txt_ValorEstorno.TabIndex = 2;
            this.Txt_ValorEstorno.Name = "Txt_ValorEstorno";
            this.Txt_ValorEstorno.TextChanged += new System.EventHandler(this.Txt_ValorEstorno_TextChanged);
            this.Txt_ValorEstorno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_ValorEstorno_KeyPress);

            // ── pnlAviso ──────────────────────────────────────────────
            this.pnlAviso.BackColor = System.Drawing.Color.FromArgb(255, 251, 235);
            this.pnlAviso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAviso.Location = new System.Drawing.Point(20, 370);
            this.pnlAviso.Size = new System.Drawing.Size(375, 38);
            this.pnlAviso.Name = "pnlAviso";
            this.pnlAviso.Controls.Add(this.lblAvisoTxt);
            this.pnlAviso.Controls.Add(this.lblAvisoIcon);

            this.lblAvisoIcon.AutoSize = true;
            this.lblAvisoIcon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAvisoIcon.ForeColor = System.Drawing.Color.FromArgb(217, 119, 6);
            this.lblAvisoIcon.Location = new System.Drawing.Point(10, 10);
            this.lblAvisoIcon.Name = "lblAvisoIcon";
            this.lblAvisoIcon.Text = "⚠";

            this.lblAvisoTxt.AutoSize = true;
            this.lblAvisoTxt.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAvisoTxt.ForeColor = System.Drawing.Color.FromArgb(146, 64, 14);
            this.lblAvisoTxt.Location = new System.Drawing.Point(30, 12);
            this.lblAvisoTxt.Name = "lblAvisoTxt";
            this.lblAvisoTxt.Text = "Esta operação não pode ser desfeita. Confirme antes de prosseguir.";

            // ── pnlSep + pnlFooter ────────────────────────────────────
            this.pnlSep.BackColor = corBorda;
            this.pnlSep.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSep.Height = 1;
            this.pnlSep.Name = "pnlSep";

            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Height = 62;
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Controls.Add(this.Btn_Limpar);
            this.pnlFooter.Controls.Add(this.Btn_Estornar);

            this.Btn_Estornar.BackColor = corAccent;
            this.Btn_Estornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Estornar.FlatAppearance.BorderSize = 0;
            this.Btn_Estornar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Estornar.ForeColor = System.Drawing.Color.White;
            this.Btn_Estornar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Estornar.Location = new System.Drawing.Point(230, 11);
            this.Btn_Estornar.Size = new System.Drawing.Size(168, 38);
            this.Btn_Estornar.TabIndex = 4;
            this.Btn_Estornar.Name = "Btn_Estornar";
            this.Btn_Estornar.Text = "↩  Confirmar Estorno";
            this.Btn_Estornar.UseVisualStyleBackColor = false;
            this.Btn_Estornar.Click += new System.EventHandler(this.Btn_Estornar_Click);

            this.Btn_Limpar.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.Btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Limpar.FlatAppearance.BorderColor = corBorda;
            this.Btn_Limpar.FlatAppearance.BorderSize = 1;
            this.Btn_Limpar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Btn_Limpar.ForeColor = corTexto;
            this.Btn_Limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Limpar.Location = new System.Drawing.Point(20, 11);
            this.Btn_Limpar.Size = new System.Drawing.Size(100, 38);
            this.Btn_Limpar.TabIndex = 3;
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = false;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);

            // ── Form ──────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = corFundo;
            this.ClientSize = new System.Drawing.Size(420, 540);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EstornarTitulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estornar Pagamento — Sistema Financeiro";

            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlSep);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlAccent);

            this.Load += new System.EventHandler(this.EstornarTitulo_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlBusca.ResumeLayout(false);
            this.pnlBusca.PerformLayout();
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.pnlInfoRow.ResumeLayout(false);
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
            this.pnlEstornoValor.ResumeLayout(false);
            this.pnlEstornoValor.PerformLayout();
            this.pnlAviso.ResumeLayout(false);
            this.pnlAviso.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader, pnlBody, pnlFooter, pnlAccent, pnlSep;
        private System.Windows.Forms.Panel pnlBusca, pnlCliente, pnlInfoRow;
        private System.Windows.Forms.Panel pnlEmissao, pnlVencimento, pnlStatus;
        private System.Windows.Forms.Panel pnlFinRow, pnlAReceber, pnlRecebido, pnlSaldo;
        private System.Windows.Forms.Panel pnlEstornoValor, pnlAviso;
        private System.Windows.Forms.Label lblTitulo, lblSubtitulo;
        private System.Windows.Forms.Label pnlSecDados, pnlSecFinanceiro, pnlSecEstorno;
        private System.Windows.Forms.Label lblIdTitulo, lblIdHint;
        private System.Windows.Forms.Label lblClienteHint;
        private System.Windows.Forms.Label lblEmissaoHint, lblVencHint, lblStatusHint;
        private System.Windows.Forms.Label lblAReceberHint, lblRecebidoHint, lblSaldoHint;
        private System.Windows.Forms.Label lblEstornoValor, lblEstornoHint;
        private System.Windows.Forms.Label lblAvisoIcon, lblAvisoTxt;
        private System.Windows.Forms.TextBox Txt_IdTitulo, Txt_Cliente;
        private System.Windows.Forms.TextBox Txt_Emissao, Txt_Vencimento, Txt_Status;
        private System.Windows.Forms.TextBox Txt_AReceber, Txt_Recebido, Txt_Saldo;
        private System.Windows.Forms.TextBox Txt_ValorEstorno;
        private System.Windows.Forms.Button Btn_Buscar, Btn_Estornar, Btn_Limpar;
    }
}