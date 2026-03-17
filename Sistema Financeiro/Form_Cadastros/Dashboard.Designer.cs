namespace Sistema_Financeiro
{
    partial class Dashboard
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
            this.lblHeaderTitulo = new System.Windows.Forms.Label();
            this.lblHeaderData = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();

            this.pnlCardClientes = new System.Windows.Forms.Panel();
            this.pnlIconClientes = new System.Windows.Forms.Panel();
            this.lblIconClientes = new System.Windows.Forms.Label();
            this.lblTxtClientes = new System.Windows.Forms.Label();
            this.lblValClientes = new System.Windows.Forms.Label();
            this.lblSubClientes = new System.Windows.Forms.Label();

            this.pnlCardTitulos = new System.Windows.Forms.Panel();
            this.pnlIconTitulos = new System.Windows.Forms.Panel();
            this.lblIconTitulos = new System.Windows.Forms.Label();
            this.lblTxtTitulos = new System.Windows.Forms.Label();
            this.lblValTitulos = new System.Windows.Forms.Label();
            this.lblSubTitulos = new System.Windows.Forms.Label();

            this.pnlCardRecebido = new System.Windows.Forms.Panel();
            this.pnlIconRecebido = new System.Windows.Forms.Panel();
            this.lblIconRecebido = new System.Windows.Forms.Label();
            this.lblTxtRecebido = new System.Windows.Forms.Label();
            this.lblValRecebido = new System.Windows.Forms.Label();
            this.lblSubRecebido = new System.Windows.Forms.Label();

            this.pnlCardPendente = new System.Windows.Forms.Panel();
            this.pnlIconPendente = new System.Windows.Forms.Panel();
            this.lblIconPendente = new System.Windows.Forms.Label();
            this.lblTxtPendente = new System.Windows.Forms.Label();
            this.lblValPendente = new System.Windows.Forms.Label();
            this.lblSubPendente = new System.Windows.Forms.Label();

            this.pnlCardVencidos = new System.Windows.Forms.Panel();
            this.pnlIconVencidos = new System.Windows.Forms.Panel();
            this.lblIconVencidos = new System.Windows.Forms.Label();
            this.lblTxtVencidos = new System.Windows.Forms.Label();
            this.lblValVencidos = new System.Windows.Forms.Label();
            this.lblSubVencidos = new System.Windows.Forms.Label();

            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.tableLayout.SuspendLayout();
            this.pnlCardClientes.SuspendLayout();
            this.pnlIconClientes.SuspendLayout();
            this.pnlCardTitulos.SuspendLayout();
            this.pnlIconTitulos.SuspendLayout();
            this.pnlCardRecebido.SuspendLayout();
            this.pnlIconRecebido.SuspendLayout();
            this.pnlCardPendente.SuspendLayout();
            this.pnlIconPendente.SuspendLayout();
            this.pnlCardVencidos.SuspendLayout();
            this.pnlIconVencidos.SuspendLayout();
            this.SuspendLayout();

            // ── Cores ────────────────────────────────────────────────
            System.Drawing.Color corFundo = System.Drawing.Color.FromArgb(241, 245, 249);
            System.Drawing.Color corHeader = System.Drawing.Color.FromArgb(15, 23, 42);
            System.Drawing.Color corCard = System.Drawing.Color.White;
            System.Drawing.Color corTexto = System.Drawing.Color.FromArgb(30, 41, 59);
            System.Drawing.Color corMuted = System.Drawing.Color.FromArgb(100, 116, 139);
            System.Drawing.Color corIndigoBg = System.Drawing.Color.FromArgb(238, 242, 255);
            System.Drawing.Color corAmbarBg = System.Drawing.Color.FromArgb(255, 251, 235);
            System.Drawing.Color corVerdeBg = System.Drawing.Color.FromArgb(240, 253, 244);
            System.Drawing.Color corVermBg = System.Drawing.Color.FromArgb(254, 242, 242);
            System.Drawing.Color corRoxoBg = System.Drawing.Color.FromArgb(245, 243, 255);
            System.Drawing.Color corIndigo = System.Drawing.Color.FromArgb(99, 102, 241);
            System.Drawing.Color corAmbar = System.Drawing.Color.FromArgb(217, 119, 6);
            System.Drawing.Color corVerde = System.Drawing.Color.FromArgb(22, 163, 74);
            System.Drawing.Color corVermelho = System.Drawing.Color.FromArgb(220, 38, 38);
            System.Drawing.Color corRoxo = System.Drawing.Color.FromArgb(124, 58, 237);

            System.Drawing.Font fonteLbl = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fonteVal = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fonteSub = new System.Drawing.Font("Segoe UI", 8.5F);
            System.Drawing.Font fonteIcon = new System.Drawing.Font("Segoe UI", 16F);
            System.Drawing.Font fonteValMed = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);

            // ── pnlHeader ────────────────────────────────────────────
            this.pnlHeader.BackColor = corHeader;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 44;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Controls.Add(this.lblHeaderData);
            this.pnlHeader.Controls.Add(this.lblHeaderTitulo);

            this.lblHeaderTitulo.AutoSize = true;
            this.lblHeaderTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitulo.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblHeaderTitulo.Location = new System.Drawing.Point(20, 14);
            this.lblHeaderTitulo.Name = "lblHeaderTitulo";
            this.lblHeaderTitulo.Text = "VISÃO GERAL";

            this.lblHeaderData.AutoSize = true;
            this.lblHeaderData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderData.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblHeaderData.Location = new System.Drawing.Point(880, 14);
            this.lblHeaderData.Name = "lblHeaderData";
            this.lblHeaderData.Text = System.DateTime.Now.ToString("dd/MM/yyyy");
            this.lblHeaderData.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            // ── pnlBody ──────────────────────────────────────────────
            this.pnlBody.BackColor = corFundo;
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(24);
            this.pnlBody.Controls.Add(this.tableLayout);

            // ── TableLayoutPanel — distribui os 5 cards em 2 linhas ──
            // Linha 1: 4 colunas iguais (25% cada)
            // Linha 2: 4 colunas, só a col 0 tem card
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.BackColor = corFundo;
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 3;
            this.tableLayout.ColumnCount = 4;
            this.tableLayout.Padding = new System.Windows.Forms.Padding(0);
            this.tableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.None;

            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            // linha 1 e 2: altura fixa para os cards
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            // linha 3: absorve o espaço restante (impede que a linha 2 se estique)
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));

            this.tableLayout.Controls.Add(this.pnlCardClientes, 0, 0);
            this.tableLayout.Controls.Add(this.pnlCardTitulos, 1, 0);
            this.tableLayout.Controls.Add(this.pnlCardRecebido, 2, 0);
            this.tableLayout.Controls.Add(this.pnlCardPendente, 3, 0);
            this.tableLayout.Controls.Add(this.pnlCardVencidos, 0, 1);

            // ════════ CARDS ════════════════════════════════════════════

            // ── Card CLIENTES ─────────────────────────────────────────
            this.pnlCardClientes.BackColor = corCard;
            this.pnlCardClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardClientes.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.pnlCardClientes.Name = "pnlCardClientes";
            this.pnlCardClientes.Controls.Add(this.lblSubClientes);
            this.pnlCardClientes.Controls.Add(this.lblValClientes);
            this.pnlCardClientes.Controls.Add(this.lblTxtClientes);
            this.pnlCardClientes.Controls.Add(this.pnlIconClientes);

            this.pnlIconClientes.BackColor = corIndigoBg;
            this.pnlIconClientes.Location = new System.Drawing.Point(16, 16);
            this.pnlIconClientes.Size = new System.Drawing.Size(40, 40);
            this.pnlIconClientes.Name = "pnlIconClientes";
            this.pnlIconClientes.Controls.Add(this.lblIconClientes);

            this.lblIconClientes.AutoSize = false;
            this.lblIconClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIconClientes.Font = fonteIcon;
            this.lblIconClientes.ForeColor = corIndigo;
            this.lblIconClientes.Name = "lblIconClientes";
            this.lblIconClientes.Text = "👥";
            this.lblIconClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblTxtClientes.AutoSize = true;
            this.lblTxtClientes.Font = fonteLbl;
            this.lblTxtClientes.ForeColor = corMuted;
            this.lblTxtClientes.Location = new System.Drawing.Point(16, 66);
            this.lblTxtClientes.Name = "lblTxtClientes";
            this.lblTxtClientes.Text = "CLIENTES";

            this.lblValClientes.AutoSize = true;
            this.lblValClientes.Font = fonteVal;
            this.lblValClientes.ForeColor = corTexto;
            this.lblValClientes.Location = new System.Drawing.Point(14, 84);
            this.lblValClientes.Name = "lblValClientes";
            this.lblValClientes.Text = "0";

            this.lblSubClientes.AutoSize = true;
            this.lblSubClientes.Font = fonteSub;
            this.lblSubClientes.ForeColor = corMuted;
            this.lblSubClientes.Location = new System.Drawing.Point(16, 124);
            this.lblSubClientes.Name = "lblSubClientes";
            this.lblSubClientes.Text = "cadastrados";

            // ── Card TÍTULOS ABERTOS ──────────────────────────────────
            this.pnlCardTitulos.BackColor = corCard;
            this.pnlCardTitulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardTitulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardTitulos.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.pnlCardTitulos.Name = "pnlCardTitulos";
            this.pnlCardTitulos.Controls.Add(this.lblSubTitulos);
            this.pnlCardTitulos.Controls.Add(this.lblValTitulos);
            this.pnlCardTitulos.Controls.Add(this.lblTxtTitulos);
            this.pnlCardTitulos.Controls.Add(this.pnlIconTitulos);

            this.pnlIconTitulos.BackColor = corAmbarBg;
            this.pnlIconTitulos.Location = new System.Drawing.Point(16, 16);
            this.pnlIconTitulos.Size = new System.Drawing.Size(40, 40);
            this.pnlIconTitulos.Name = "pnlIconTitulos";
            this.pnlIconTitulos.Controls.Add(this.lblIconTitulos);

            this.lblIconTitulos.AutoSize = false;
            this.lblIconTitulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIconTitulos.Font = fonteIcon;
            this.lblIconTitulos.ForeColor = corAmbar;
            this.lblIconTitulos.Name = "lblIconTitulos";
            this.lblIconTitulos.Text = "📄";
            this.lblIconTitulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblTxtTitulos.AutoSize = true;
            this.lblTxtTitulos.Font = fonteLbl;
            this.lblTxtTitulos.ForeColor = corMuted;
            this.lblTxtTitulos.Location = new System.Drawing.Point(16, 66);
            this.lblTxtTitulos.Name = "lblTxtTitulos";
            this.lblTxtTitulos.Text = "TÍTULOS ABERTOS";

            this.lblValTitulos.AutoSize = true;
            this.lblValTitulos.Font = fonteVal;
            this.lblValTitulos.ForeColor = corTexto;
            this.lblValTitulos.Location = new System.Drawing.Point(14, 84);
            this.lblValTitulos.Name = "lblValTitulos";
            this.lblValTitulos.Text = "0";

            this.lblSubTitulos.AutoSize = true;
            this.lblSubTitulos.Font = fonteSub;
            this.lblSubTitulos.ForeColor = corMuted;
            this.lblSubTitulos.Location = new System.Drawing.Point(16, 124);
            this.lblSubTitulos.Name = "lblSubTitulos";
            this.lblSubTitulos.Text = "a receber";

            // ── Card RECEBIDO ─────────────────────────────────────────
            this.pnlCardRecebido.BackColor = corCard;
            this.pnlCardRecebido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardRecebido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardRecebido.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.pnlCardRecebido.Name = "pnlCardRecebido";
            this.pnlCardRecebido.Controls.Add(this.lblSubRecebido);
            this.pnlCardRecebido.Controls.Add(this.lblValRecebido);
            this.pnlCardRecebido.Controls.Add(this.lblTxtRecebido);
            this.pnlCardRecebido.Controls.Add(this.pnlIconRecebido);

            this.pnlIconRecebido.BackColor = corVerdeBg;
            this.pnlIconRecebido.Location = new System.Drawing.Point(16, 16);
            this.pnlIconRecebido.Size = new System.Drawing.Size(40, 40);
            this.pnlIconRecebido.Name = "pnlIconRecebido";
            this.pnlIconRecebido.Controls.Add(this.lblIconRecebido);

            this.lblIconRecebido.AutoSize = false;
            this.lblIconRecebido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIconRecebido.Font = fonteIcon;
            this.lblIconRecebido.ForeColor = corVerde;
            this.lblIconRecebido.Name = "lblIconRecebido";
            this.lblIconRecebido.Text = "✅";
            this.lblIconRecebido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblTxtRecebido.AutoSize = true;
            this.lblTxtRecebido.Font = fonteLbl;
            this.lblTxtRecebido.ForeColor = corMuted;
            this.lblTxtRecebido.Location = new System.Drawing.Point(16, 66);
            this.lblTxtRecebido.Name = "lblTxtRecebido";
            this.lblTxtRecebido.Text = "RECEBIDO";

            this.lblValRecebido.AutoSize = true;
            this.lblValRecebido.Font = fonteValMed;
            this.lblValRecebido.ForeColor = corVerde;
            this.lblValRecebido.Location = new System.Drawing.Point(14, 84);
            this.lblValRecebido.Name = "lblValRecebido";
            this.lblValRecebido.Text = "R$ 0,00";

            this.lblSubRecebido.AutoSize = true;
            this.lblSubRecebido.Font = fonteSub;
            this.lblSubRecebido.ForeColor = corMuted;
            this.lblSubRecebido.Location = new System.Drawing.Point(16, 124);
            this.lblSubRecebido.Name = "lblSubRecebido";
            this.lblSubRecebido.Text = "este mês";

            // ── Card SALDO PENDENTE ───────────────────────────────────
            this.pnlCardPendente.BackColor = corCard;
            this.pnlCardPendente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardPendente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardPendente.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.pnlCardPendente.Name = "pnlCardPendente";
            this.pnlCardPendente.Controls.Add(this.lblSubPendente);
            this.pnlCardPendente.Controls.Add(this.lblValPendente);
            this.pnlCardPendente.Controls.Add(this.lblTxtPendente);
            this.pnlCardPendente.Controls.Add(this.pnlIconPendente);

            this.pnlIconPendente.BackColor = corRoxoBg;
            this.pnlIconPendente.Location = new System.Drawing.Point(16, 16);
            this.pnlIconPendente.Size = new System.Drawing.Size(40, 40);
            this.pnlIconPendente.Name = "pnlIconPendente";
            this.pnlIconPendente.Controls.Add(this.lblIconPendente);

            this.lblIconPendente.AutoSize = false;
            this.lblIconPendente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIconPendente.Font = fonteIcon;
            this.lblIconPendente.ForeColor = corRoxo;
            this.lblIconPendente.Name = "lblIconPendente";
            this.lblIconPendente.Text = "💰";
            this.lblIconPendente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblTxtPendente.AutoSize = true;
            this.lblTxtPendente.Font = fonteLbl;
            this.lblTxtPendente.ForeColor = corMuted;
            this.lblTxtPendente.Location = new System.Drawing.Point(16, 66);
            this.lblTxtPendente.Name = "lblTxtPendente";
            this.lblTxtPendente.Text = "SALDO PENDENTE";

            this.lblValPendente.AutoSize = true;
            this.lblValPendente.Font = fonteValMed;
            this.lblValPendente.ForeColor = corRoxo;
            this.lblValPendente.Location = new System.Drawing.Point(14, 84);
            this.lblValPendente.Name = "lblValPendente";
            this.lblValPendente.Text = "R$ 0,00";

            this.lblSubPendente.AutoSize = true;
            this.lblSubPendente.Font = fonteSub;
            this.lblSubPendente.ForeColor = corMuted;
            this.lblSubPendente.Location = new System.Drawing.Point(16, 124);
            this.lblSubPendente.Name = "lblSubPendente";
            this.lblSubPendente.Text = "em aberto";

            // ── Card VENCIDOS ─────────────────────────────────────────
            this.pnlCardVencidos.BackColor = corCard;
            this.pnlCardVencidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardVencidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardVencidos.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.pnlCardVencidos.Name = "pnlCardVencidos";
            this.pnlCardVencidos.Controls.Add(this.lblSubVencidos);
            this.pnlCardVencidos.Controls.Add(this.lblValVencidos);
            this.pnlCardVencidos.Controls.Add(this.lblTxtVencidos);
            this.pnlCardVencidos.Controls.Add(this.pnlIconVencidos);

            this.pnlIconVencidos.BackColor = corVermBg;
            this.pnlIconVencidos.Location = new System.Drawing.Point(16, 16);
            this.pnlIconVencidos.Size = new System.Drawing.Size(40, 40);
            this.pnlIconVencidos.Name = "pnlIconVencidos";
            this.pnlIconVencidos.Controls.Add(this.lblIconVencidos);

            this.lblIconVencidos.AutoSize = false;
            this.lblIconVencidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIconVencidos.Font = fonteIcon;
            this.lblIconVencidos.ForeColor = corVermelho;
            this.lblIconVencidos.Name = "lblIconVencidos";
            this.lblIconVencidos.Text = "⚠";
            this.lblIconVencidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblTxtVencidos.AutoSize = true;
            this.lblTxtVencidos.Font = fonteLbl;
            this.lblTxtVencidos.ForeColor = corMuted;
            this.lblTxtVencidos.Location = new System.Drawing.Point(16, 66);
            this.lblTxtVencidos.Name = "lblTxtVencidos";
            this.lblTxtVencidos.Text = "VENCIDOS";

            this.lblValVencidos.AutoSize = true;
            this.lblValVencidos.Font = fonteVal;
            this.lblValVencidos.ForeColor = corVermelho;
            this.lblValVencidos.Location = new System.Drawing.Point(14, 84);
            this.lblValVencidos.Name = "lblValVencidos";
            this.lblValVencidos.Text = "0";

            this.lblSubVencidos.AutoSize = true;
            this.lblSubVencidos.Font = fonteSub;
            this.lblSubVencidos.ForeColor = corMuted;
            this.lblSubVencidos.Location = new System.Drawing.Point(16, 124);
            this.lblSubVencidos.Name = "lblSubVencidos";
            this.lblSubVencidos.Text = "título em atraso";

            // ── Form ──────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(900, 400);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.Text = "";

            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);

            this.Load += new System.EventHandler(this.Dashboard_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.tableLayout.ResumeLayout(false);
            this.pnlCardClientes.ResumeLayout(false);
            this.pnlCardClientes.PerformLayout();
            this.pnlIconClientes.ResumeLayout(false);
            this.pnlCardTitulos.ResumeLayout(false);
            this.pnlCardTitulos.PerformLayout();
            this.pnlIconTitulos.ResumeLayout(false);
            this.pnlCardRecebido.ResumeLayout(false);
            this.pnlCardRecebido.PerformLayout();
            this.pnlIconRecebido.ResumeLayout(false);
            this.pnlCardPendente.ResumeLayout(false);
            this.pnlCardPendente.PerformLayout();
            this.pnlIconPendente.ResumeLayout(false);
            this.pnlCardVencidos.ResumeLayout(false);
            this.pnlCardVencidos.PerformLayout();
            this.pnlIconVencidos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader, pnlBody;
        private System.Windows.Forms.Label lblHeaderTitulo, lblHeaderData;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Panel pnlCardClientes, pnlIconClientes;
        private System.Windows.Forms.Label lblIconClientes, lblTxtClientes, lblValClientes, lblSubClientes;
        private System.Windows.Forms.Panel pnlCardTitulos, pnlIconTitulos;
        private System.Windows.Forms.Label lblIconTitulos, lblTxtTitulos, lblValTitulos, lblSubTitulos;
        private System.Windows.Forms.Panel pnlCardRecebido, pnlIconRecebido;
        private System.Windows.Forms.Label lblIconRecebido, lblTxtRecebido, lblValRecebido, lblSubRecebido;
        private System.Windows.Forms.Panel pnlCardPendente, pnlIconPendente;
        private System.Windows.Forms.Label lblIconPendente, lblTxtPendente, lblValPendente, lblSubPendente;
        private System.Windows.Forms.Panel pnlCardVencidos, pnlIconVencidos;
        private System.Windows.Forms.Label lblIconVencidos, lblTxtVencidos, lblValVencidos, lblSubVencidos;
    }
}