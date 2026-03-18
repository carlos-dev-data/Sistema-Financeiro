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
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlAviso = new System.Windows.Forms.Panel();
            this.lblAvisoTxt = new System.Windows.Forms.Label();
            this.lblAvisoIcon = new System.Windows.Forms.Label();
            this.pnlEstornoValor = new System.Windows.Forms.Panel();
            this.Txt_ValorEstorno = new System.Windows.Forms.TextBox();
            this.lblEstornoHint = new System.Windows.Forms.Label();
            this.lblEstornoValor = new System.Windows.Forms.Label();
            this.pnlSecEstorno = new System.Windows.Forms.Label();
            this.pnlFinRow = new System.Windows.Forms.Panel();
            this.pnlSaldo = new System.Windows.Forms.Panel();
            this.Txt_Saldo = new System.Windows.Forms.TextBox();
            this.lblSaldoHint = new System.Windows.Forms.Label();
            this.pnlRecebido = new System.Windows.Forms.Panel();
            this.Txt_Recebido = new System.Windows.Forms.TextBox();
            this.lblRecebidoHint = new System.Windows.Forms.Label();
            this.pnlAReceber = new System.Windows.Forms.Panel();
            this.Txt_AReceber = new System.Windows.Forms.TextBox();
            this.lblAReceberHint = new System.Windows.Forms.Label();
            this.pnlSecFinanceiro = new System.Windows.Forms.Label();
            this.pnlInfoRow = new System.Windows.Forms.Panel();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.Txt_Status = new System.Windows.Forms.TextBox();
            this.lblStatusHint = new System.Windows.Forms.Label();
            this.pnlVencimento = new System.Windows.Forms.Panel();
            this.Txt_Vencimento = new System.Windows.Forms.TextBox();
            this.lblVencHint = new System.Windows.Forms.Label();
            this.pnlEmissao = new System.Windows.Forms.Panel();
            this.Txt_Emissao = new System.Windows.Forms.TextBox();
            this.lblEmissaoHint = new System.Windows.Forms.Label();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.Txt_Cliente = new System.Windows.Forms.TextBox();
            this.lblClienteHint = new System.Windows.Forms.Label();
            this.pnlSecDados = new System.Windows.Forms.Label();
            this.pnlBusca = new System.Windows.Forms.Panel();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Txt_IdTitulo = new System.Windows.Forms.TextBox();
            this.lblIdHint = new System.Windows.Forms.Label();
            this.lblIdTitulo = new System.Windows.Forms.Label();
            this.pnlSep = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Btn_Estornar = new System.Windows.Forms.Button();
            this.pnlAccent = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlAviso.SuspendLayout();
            this.pnlEstornoValor.SuspendLayout();
            this.pnlFinRow.SuspendLayout();
            this.pnlSaldo.SuspendLayout();
            this.pnlRecebido.SuspendLayout();
            this.pnlAReceber.SuspendLayout();
            this.pnlInfoRow.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlVencimento.SuspendLayout();
            this.pnlEmissao.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.pnlBusca.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
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
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(26, 46);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(215, 13);
            this.lblSubtitulo.TabIndex = 0;
            this.lblSubtitulo.Text = "Contas a Receber  •  Reverter Pagamento";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(24, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(194, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Estornar Pagamento";
            // 
            // pnlBody
            // 
            this.pnlBody.AutoScroll = true;
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.pnlBody.Controls.Add(this.pnlAviso);
            this.pnlBody.Controls.Add(this.pnlEstornoValor);
            this.pnlBody.Controls.Add(this.pnlSecEstorno);
            this.pnlBody.Controls.Add(this.pnlFinRow);
            this.pnlBody.Controls.Add(this.pnlSecFinanceiro);
            this.pnlBody.Controls.Add(this.pnlInfoRow);
            this.pnlBody.Controls.Add(this.pnlCliente);
            this.pnlBody.Controls.Add(this.pnlSecDados);
            this.pnlBody.Controls.Add(this.pnlBusca);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(5, 72);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(20, 12, 20, 0);
            this.pnlBody.Size = new System.Drawing.Size(415, 405);
            this.pnlBody.TabIndex = 0;
            // 
            // pnlAviso
            // 
            this.pnlAviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(235)))));
            this.pnlAviso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAviso.Controls.Add(this.lblAvisoTxt);
            this.pnlAviso.Controls.Add(this.lblAvisoIcon);
            this.pnlAviso.Location = new System.Drawing.Point(20, 370);
            this.pnlAviso.Name = "pnlAviso";
            this.pnlAviso.Size = new System.Drawing.Size(375, 38);
            this.pnlAviso.TabIndex = 0;
            // 
            // lblAvisoTxt
            // 
            this.lblAvisoTxt.AutoSize = true;
            this.lblAvisoTxt.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAvisoTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.lblAvisoTxt.Location = new System.Drawing.Point(30, 12);
            this.lblAvisoTxt.Name = "lblAvisoTxt";
            this.lblAvisoTxt.Size = new System.Drawing.Size(355, 13);
            this.lblAvisoTxt.TabIndex = 0;
            this.lblAvisoTxt.Text = "Esta operação não pode ser desfeita. Confirme antes de prosseguir.";
            // 
            // lblAvisoIcon
            // 
            this.lblAvisoIcon.AutoSize = true;
            this.lblAvisoIcon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAvisoIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.lblAvisoIcon.Location = new System.Drawing.Point(10, 10);
            this.lblAvisoIcon.Name = "lblAvisoIcon";
            this.lblAvisoIcon.Size = new System.Drawing.Size(28, 19);
            this.lblAvisoIcon.TabIndex = 1;
            this.lblAvisoIcon.Text = "⚠";
            // 
            // pnlEstornoValor
            // 
            this.pnlEstornoValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlEstornoValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEstornoValor.Controls.Add(this.Txt_ValorEstorno);
            this.pnlEstornoValor.Controls.Add(this.lblEstornoHint);
            this.pnlEstornoValor.Controls.Add(this.lblEstornoValor);
            this.pnlEstornoValor.Location = new System.Drawing.Point(20, 302);
            this.pnlEstornoValor.Name = "pnlEstornoValor";
            this.pnlEstornoValor.Size = new System.Drawing.Size(375, 58);
            this.pnlEstornoValor.TabIndex = 1;
            // 
            // Txt_ValorEstorno
            // 
            this.Txt_ValorEstorno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Txt_ValorEstorno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_ValorEstorno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_ValorEstorno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Txt_ValorEstorno.Location = new System.Drawing.Point(12, 30);
            this.Txt_ValorEstorno.Name = "Txt_ValorEstorno";
            this.Txt_ValorEstorno.Size = new System.Drawing.Size(348, 22);
            this.Txt_ValorEstorno.TabIndex = 2;
            this.Txt_ValorEstorno.TextChanged += new System.EventHandler(this.Txt_ValorEstorno_TextChanged);
            this.Txt_ValorEstorno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_ValorEstorno_KeyPress);
            // 
            // lblEstornoHint
            // 
            this.lblEstornoHint.AutoSize = true;
            this.lblEstornoHint.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblEstornoHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.lblEstornoHint.Location = new System.Drawing.Point(188, 11);
            this.lblEstornoHint.Name = "lblEstornoHint";
            this.lblEstornoHint.Size = new System.Drawing.Size(134, 12);
            this.lblEstornoHint.TabIndex = 3;
            this.lblEstornoHint.Text = "deixe vazio para estorno total";
            // 
            // lblEstornoValor
            // 
            this.lblEstornoValor.AutoSize = true;
            this.lblEstornoValor.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblEstornoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblEstornoValor.Location = new System.Drawing.Point(12, 9);
            this.lblEstornoValor.Name = "lblEstornoValor";
            this.lblEstornoValor.Size = new System.Drawing.Size(138, 13);
            this.lblEstornoValor.TabIndex = 4;
            this.lblEstornoValor.Text = "VALOR DO ESTORNO (R$)";
            // 
            // pnlSecEstorno
            // 
            this.pnlSecEstorno.AutoSize = true;
            this.pnlSecEstorno.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.pnlSecEstorno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.pnlSecEstorno.Location = new System.Drawing.Point(20, 286);
            this.pnlSecEstorno.Name = "pnlSecEstorno";
            this.pnlSecEstorno.Size = new System.Drawing.Size(53, 12);
            this.pnlSecEstorno.TabIndex = 2;
            this.pnlSecEstorno.Text = "ESTORNO";
            // 
            // pnlFinRow
            // 
            this.pnlFinRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.pnlFinRow.Controls.Add(this.pnlSaldo);
            this.pnlFinRow.Controls.Add(this.pnlRecebido);
            this.pnlFinRow.Controls.Add(this.pnlAReceber);
            this.pnlFinRow.Location = new System.Drawing.Point(20, 222);
            this.pnlFinRow.Name = "pnlFinRow";
            this.pnlFinRow.Size = new System.Drawing.Size(375, 54);
            this.pnlFinRow.TabIndex = 3;
            // 
            // pnlSaldo
            // 
            this.pnlSaldo.BackColor = System.Drawing.Color.White;
            this.pnlSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSaldo.Controls.Add(this.Txt_Saldo);
            this.pnlSaldo.Controls.Add(this.lblSaldoHint);
            this.pnlSaldo.Location = new System.Drawing.Point(258, 0);
            this.pnlSaldo.Name = "pnlSaldo";
            this.pnlSaldo.Size = new System.Drawing.Size(117, 54);
            this.pnlSaldo.TabIndex = 0;
            // 
            // Txt_Saldo
            // 
            this.Txt_Saldo.BackColor = System.Drawing.Color.White;
            this.Txt_Saldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Saldo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Txt_Saldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Txt_Saldo.Location = new System.Drawing.Point(9, 27);
            this.Txt_Saldo.Name = "Txt_Saldo";
            this.Txt_Saldo.ReadOnly = true;
            this.Txt_Saldo.Size = new System.Drawing.Size(95, 18);
            this.Txt_Saldo.TabIndex = 0;
            this.Txt_Saldo.TabStop = false;
            // 
            // lblSaldoHint
            // 
            this.lblSaldoHint.AutoSize = true;
            this.lblSaldoHint.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSaldoHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSaldoHint.Location = new System.Drawing.Point(9, 7);
            this.lblSaldoHint.Name = "lblSaldoHint";
            this.lblSaldoHint.Size = new System.Drawing.Size(43, 13);
            this.lblSaldoHint.TabIndex = 1;
            this.lblSaldoHint.Text = "SALDO";
            // 
            // pnlRecebido
            // 
            this.pnlRecebido.BackColor = System.Drawing.Color.White;
            this.pnlRecebido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRecebido.Controls.Add(this.Txt_Recebido);
            this.pnlRecebido.Controls.Add(this.lblRecebidoHint);
            this.pnlRecebido.Location = new System.Drawing.Point(126, 0);
            this.pnlRecebido.Name = "pnlRecebido";
            this.pnlRecebido.Size = new System.Drawing.Size(124, 54);
            this.pnlRecebido.TabIndex = 1;
            // 
            // Txt_Recebido
            // 
            this.Txt_Recebido.BackColor = System.Drawing.Color.White;
            this.Txt_Recebido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Recebido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Txt_Recebido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.Txt_Recebido.Location = new System.Drawing.Point(9, 27);
            this.Txt_Recebido.Name = "Txt_Recebido";
            this.Txt_Recebido.ReadOnly = true;
            this.Txt_Recebido.Size = new System.Drawing.Size(102, 18);
            this.Txt_Recebido.TabIndex = 0;
            this.Txt_Recebido.TabStop = false;
            // 
            // lblRecebidoHint
            // 
            this.lblRecebidoHint.AutoSize = true;
            this.lblRecebidoHint.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblRecebidoHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblRecebidoHint.Location = new System.Drawing.Point(9, 7);
            this.lblRecebidoHint.Name = "lblRecebidoHint";
            this.lblRecebidoHint.Size = new System.Drawing.Size(75, 13);
            this.lblRecebidoHint.TabIndex = 1;
            this.lblRecebidoHint.Text = "JÁ RECEBIDO";
            // 
            // pnlAReceber
            // 
            this.pnlAReceber.BackColor = System.Drawing.Color.White;
            this.pnlAReceber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAReceber.Controls.Add(this.Txt_AReceber);
            this.pnlAReceber.Controls.Add(this.lblAReceberHint);
            this.pnlAReceber.Location = new System.Drawing.Point(0, 0);
            this.pnlAReceber.Name = "pnlAReceber";
            this.pnlAReceber.Size = new System.Drawing.Size(118, 54);
            this.pnlAReceber.TabIndex = 2;
            // 
            // Txt_AReceber
            // 
            this.Txt_AReceber.BackColor = System.Drawing.Color.White;
            this.Txt_AReceber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_AReceber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Txt_AReceber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.Txt_AReceber.Location = new System.Drawing.Point(9, 27);
            this.Txt_AReceber.Name = "Txt_AReceber";
            this.Txt_AReceber.ReadOnly = true;
            this.Txt_AReceber.Size = new System.Drawing.Size(96, 18);
            this.Txt_AReceber.TabIndex = 0;
            this.Txt_AReceber.TabStop = false;
            // 
            // lblAReceberHint
            // 
            this.lblAReceberHint.AutoSize = true;
            this.lblAReceberHint.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblAReceberHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblAReceberHint.Location = new System.Drawing.Point(9, 7);
            this.lblAReceberHint.Name = "lblAReceberHint";
            this.lblAReceberHint.Size = new System.Drawing.Size(64, 13);
            this.lblAReceberHint.TabIndex = 1;
            this.lblAReceberHint.Text = "A RECEBER";
            // 
            // pnlSecFinanceiro
            // 
            this.pnlSecFinanceiro.AutoSize = true;
            this.pnlSecFinanceiro.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.pnlSecFinanceiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.pnlSecFinanceiro.Location = new System.Drawing.Point(20, 206);
            this.pnlSecFinanceiro.Name = "pnlSecFinanceiro";
            this.pnlSecFinanceiro.Size = new System.Drawing.Size(117, 12);
            this.pnlSecFinanceiro.TabIndex = 4;
            this.pnlSecFinanceiro.Text = "SITUAÇÃO FINANCEIRA";
            // 
            // pnlInfoRow
            // 
            this.pnlInfoRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.pnlInfoRow.Controls.Add(this.pnlStatus);
            this.pnlInfoRow.Controls.Add(this.pnlVencimento);
            this.pnlInfoRow.Controls.Add(this.pnlEmissao);
            this.pnlInfoRow.Location = new System.Drawing.Point(20, 142);
            this.pnlInfoRow.Name = "pnlInfoRow";
            this.pnlInfoRow.Size = new System.Drawing.Size(375, 54);
            this.pnlInfoRow.TabIndex = 5;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.White;
            this.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatus.Controls.Add(this.Txt_Status);
            this.pnlStatus.Controls.Add(this.lblStatusHint);
            this.pnlStatus.Location = new System.Drawing.Point(258, 0);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(117, 54);
            this.pnlStatus.TabIndex = 0;
            // 
            // Txt_Status
            // 
            this.Txt_Status.BackColor = System.Drawing.Color.White;
            this.Txt_Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Txt_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.Txt_Status.Location = new System.Drawing.Point(9, 27);
            this.Txt_Status.Name = "Txt_Status";
            this.Txt_Status.ReadOnly = true;
            this.Txt_Status.Size = new System.Drawing.Size(95, 16);
            this.Txt_Status.TabIndex = 0;
            this.Txt_Status.TabStop = false;
            // 
            // lblStatusHint
            // 
            this.lblStatusHint.AutoSize = true;
            this.lblStatusHint.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblStatusHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblStatusHint.Location = new System.Drawing.Point(9, 7);
            this.lblStatusHint.Name = "lblStatusHint";
            this.lblStatusHint.Size = new System.Drawing.Size(45, 13);
            this.lblStatusHint.TabIndex = 1;
            this.lblStatusHint.Text = "STATUS";
            // 
            // pnlVencimento
            // 
            this.pnlVencimento.BackColor = System.Drawing.Color.White;
            this.pnlVencimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVencimento.Controls.Add(this.Txt_Vencimento);
            this.pnlVencimento.Controls.Add(this.lblVencHint);
            this.pnlVencimento.Location = new System.Drawing.Point(126, 0);
            this.pnlVencimento.Name = "pnlVencimento";
            this.pnlVencimento.Size = new System.Drawing.Size(124, 54);
            this.pnlVencimento.TabIndex = 1;
            // 
            // Txt_Vencimento
            // 
            this.Txt_Vencimento.BackColor = System.Drawing.Color.White;
            this.Txt_Vencimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Vencimento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Txt_Vencimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.Txt_Vencimento.Location = new System.Drawing.Point(9, 27);
            this.Txt_Vencimento.Name = "Txt_Vencimento";
            this.Txt_Vencimento.ReadOnly = true;
            this.Txt_Vencimento.Size = new System.Drawing.Size(102, 18);
            this.Txt_Vencimento.TabIndex = 0;
            this.Txt_Vencimento.TabStop = false;
            // 
            // lblVencHint
            // 
            this.lblVencHint.AutoSize = true;
            this.lblVencHint.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblVencHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblVencHint.Location = new System.Drawing.Point(9, 7);
            this.lblVencHint.Name = "lblVencHint";
            this.lblVencHint.Size = new System.Drawing.Size(79, 13);
            this.lblVencHint.TabIndex = 1;
            this.lblVencHint.Text = "VENCIMENTO";
            // 
            // pnlEmissao
            // 
            this.pnlEmissao.BackColor = System.Drawing.Color.White;
            this.pnlEmissao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmissao.Controls.Add(this.Txt_Emissao);
            this.pnlEmissao.Controls.Add(this.lblEmissaoHint);
            this.pnlEmissao.Location = new System.Drawing.Point(0, 0);
            this.pnlEmissao.Name = "pnlEmissao";
            this.pnlEmissao.Size = new System.Drawing.Size(118, 54);
            this.pnlEmissao.TabIndex = 2;
            // 
            // Txt_Emissao
            // 
            this.Txt_Emissao.BackColor = System.Drawing.Color.White;
            this.Txt_Emissao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Emissao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Txt_Emissao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.Txt_Emissao.Location = new System.Drawing.Point(9, 27);
            this.Txt_Emissao.Name = "Txt_Emissao";
            this.Txt_Emissao.ReadOnly = true;
            this.Txt_Emissao.Size = new System.Drawing.Size(96, 18);
            this.Txt_Emissao.TabIndex = 0;
            this.Txt_Emissao.TabStop = false;
            // 
            // lblEmissaoHint
            // 
            this.lblEmissaoHint.AutoSize = true;
            this.lblEmissaoHint.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblEmissaoHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblEmissaoHint.Location = new System.Drawing.Point(9, 7);
            this.lblEmissaoHint.Name = "lblEmissaoHint";
            this.lblEmissaoHint.Size = new System.Drawing.Size(55, 13);
            this.lblEmissaoHint.TabIndex = 1;
            this.lblEmissaoHint.Text = "EMISSÃO";
            // 
            // pnlCliente
            // 
            this.pnlCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.pnlCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCliente.Controls.Add(this.Txt_Cliente);
            this.pnlCliente.Controls.Add(this.lblClienteHint);
            this.pnlCliente.Location = new System.Drawing.Point(20, 88);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(375, 46);
            this.pnlCliente.TabIndex = 6;
            // 
            // Txt_Cliente
            // 
            this.Txt_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.Txt_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Cliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Txt_Cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.Txt_Cliente.Location = new System.Drawing.Point(12, 25);
            this.Txt_Cliente.Name = "Txt_Cliente";
            this.Txt_Cliente.ReadOnly = true;
            this.Txt_Cliente.Size = new System.Drawing.Size(348, 18);
            this.Txt_Cliente.TabIndex = 0;
            this.Txt_Cliente.TabStop = false;
            // 
            // lblClienteHint
            // 
            this.lblClienteHint.AutoSize = true;
            this.lblClienteHint.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblClienteHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.lblClienteHint.Location = new System.Drawing.Point(12, 7);
            this.lblClienteHint.Name = "lblClienteHint";
            this.lblClienteHint.Size = new System.Drawing.Size(50, 13);
            this.lblClienteHint.TabIndex = 1;
            this.lblClienteHint.Text = "CLIENTE";
            // 
            // pnlSecDados
            // 
            this.pnlSecDados.AutoSize = true;
            this.pnlSecDados.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.pnlSecDados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.pnlSecDados.Location = new System.Drawing.Point(20, 72);
            this.pnlSecDados.Name = "pnlSecDados";
            this.pnlSecDados.Size = new System.Drawing.Size(96, 12);
            this.pnlSecDados.TabIndex = 7;
            this.pnlSecDados.Text = "DADOS DO TÍTULO";
            // 
            // pnlBusca
            // 
            this.pnlBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(235)))));
            this.pnlBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBusca.Controls.Add(this.Btn_Buscar);
            this.pnlBusca.Controls.Add(this.Txt_IdTitulo);
            this.pnlBusca.Controls.Add(this.lblIdHint);
            this.pnlBusca.Controls.Add(this.lblIdTitulo);
            this.pnlBusca.Location = new System.Drawing.Point(20, 12);
            this.pnlBusca.Name = "pnlBusca";
            this.pnlBusca.Size = new System.Drawing.Size(375, 50);
            this.pnlBusca.TabIndex = 8;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.Btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Buscar.FlatAppearance.BorderSize = 0;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.Btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.Btn_Buscar.Location = new System.Drawing.Point(288, 10);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(80, 28);
            this.Btn_Buscar.TabIndex = 1;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Txt_IdTitulo
            // 
            this.Txt_IdTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(235)))));
            this.Txt_IdTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_IdTitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Txt_IdTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.Txt_IdTitulo.Location = new System.Drawing.Point(12, 27);
            this.Txt_IdTitulo.Name = "Txt_IdTitulo";
            this.Txt_IdTitulo.Size = new System.Drawing.Size(240, 18);
            this.Txt_IdTitulo.TabIndex = 0;
            // 
            // lblIdHint
            // 
            this.lblIdHint.AutoSize = true;
            this.lblIdHint.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblIdHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.lblIdHint.Location = new System.Drawing.Point(102, 10);
            this.lblIdHint.Name = "lblIdHint";
            this.lblIdHint.Size = new System.Drawing.Size(82, 12);
            this.lblIdHint.TabIndex = 2;
            this.lblIdHint.Text = "informe o código";
            // 
            // lblIdTitulo
            // 
            this.lblIdTitulo.AutoSize = true;
            this.lblIdTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblIdTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.lblIdTitulo.Location = new System.Drawing.Point(12, 8);
            this.lblIdTitulo.Name = "lblIdTitulo";
            this.lblIdTitulo.Size = new System.Drawing.Size(77, 13);
            this.lblIdTitulo.TabIndex = 3;
            this.lblIdTitulo.Text = "ID DO TÍTULO";
            // 
            // pnlSep
            // 
            this.pnlSep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlSep.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSep.Location = new System.Drawing.Point(5, 539);
            this.pnlSep.Name = "pnlSep";
            this.pnlSep.Size = new System.Drawing.Size(415, 1);
            this.pnlSep.TabIndex = 2;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.Btn_Limpar);
            this.pnlFooter.Controls.Add(this.Btn_Estornar);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(5, 477);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(415, 62);
            this.pnlFooter.TabIndex = 1;
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Btn_Limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Limpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.Btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Limpar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Btn_Limpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.Btn_Limpar.Location = new System.Drawing.Point(20, 11);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(100, 38);
            this.Btn_Limpar.TabIndex = 3;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = false;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Btn_Estornar
            // 
            this.Btn_Estornar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Btn_Estornar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Estornar.FlatAppearance.BorderSize = 0;
            this.Btn_Estornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Estornar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Estornar.ForeColor = System.Drawing.Color.White;
            this.Btn_Estornar.Location = new System.Drawing.Point(230, 11);
            this.Btn_Estornar.Name = "Btn_Estornar";
            this.Btn_Estornar.Size = new System.Drawing.Size(168, 38);
            this.Btn_Estornar.TabIndex = 4;
            this.Btn_Estornar.Text = "↩  Confirmar Estorno";
            this.Btn_Estornar.UseVisualStyleBackColor = false;
            this.Btn_Estornar.Click += new System.EventHandler(this.Btn_Estornar_Click);
            // 
            // pnlAccent
            // 
            this.pnlAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pnlAccent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlAccent.Name = "pnlAccent";
            this.pnlAccent.Size = new System.Drawing.Size(5, 540);
            this.pnlAccent.TabIndex = 4;
            // 
            // EstornarTitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(420, 540);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlSep);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlAccent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EstornarTitulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estornar Pagamento — Sistema Financeiro";
            this.Load += new System.EventHandler(this.EstornarTitulo_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlAviso.ResumeLayout(false);
            this.pnlAviso.PerformLayout();
            this.pnlEstornoValor.ResumeLayout(false);
            this.pnlEstornoValor.PerformLayout();
            this.pnlFinRow.ResumeLayout(false);
            this.pnlSaldo.ResumeLayout(false);
            this.pnlSaldo.PerformLayout();
            this.pnlRecebido.ResumeLayout(false);
            this.pnlRecebido.PerformLayout();
            this.pnlAReceber.ResumeLayout(false);
            this.pnlAReceber.PerformLayout();
            this.pnlInfoRow.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.pnlVencimento.ResumeLayout(false);
            this.pnlVencimento.PerformLayout();
            this.pnlEmissao.ResumeLayout(false);
            this.pnlEmissao.PerformLayout();
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.pnlBusca.ResumeLayout(false);
            this.pnlBusca.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

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