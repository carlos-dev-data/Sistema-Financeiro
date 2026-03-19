using Newtonsoft.Json;
using Sistema_Financeiro.Conexao;
using Sistema_Financeiro.Form_ContaReceber;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_Financeiro.Form_Relatorios
{
    public partial class TitulosAReceber : Form
    {
        private List<ContaReceber> _todos = new List<ContaReceber>();
        private List<ContaReceber> _filtrados = new List<ContaReceber>();
        private ContaReceber _selecionado = null;
        private readonly CultureInfo _ptBR = new CultureInfo("pt-BR");
        private readonly Color CorVerde = Color.FromArgb(22, 101, 52);
        private readonly Color CorVermelho = Color.FromArgb(185, 28, 28);

        public TitulosAReceber()
        {
            InitializeComponent();
        }

        private void TitulosAReceber_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new object[] { "Todos", "Aberto", "Pago", "Pago Parcial", "Vencido" });
            cmbStatus.SelectedIndex = 0;
            dtpEmissao.Checked = false;
            dtpVencIni.Checked = false;
            dtpVencFim.Checked = false;
            ConfigurarGrid();
            AtualizarBotoes();
            CarregarDados();
        }

        // ── Dados ─────────────────────────────────────────────────────
        private void CarregarDados()
        {
            try
            {
                string cam = new ContaReceber().caminhoArquivoContaReceber;
                if (File.Exists(cam))
                {
                    JsonSerializerSettings cfg = new JsonSerializerSettings
                    { DateTimeZoneHandling = DateTimeZoneHandling.Local };
                    _todos = JsonConvert.DeserializeObject<List<ContaReceber>>(
                                 File.ReadAllText(cam), cfg) ?? new List<ContaReceber>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                _todos = new List<ContaReceber>();
            }
            _filtrados = new List<ContaReceber>(_todos);
            PreencherGrid(_filtrados);
        }

        // ── Grid ──────────────────────────────────────────────────────
        private void ConfigurarGrid()
        {
            dgvTitulos.Columns.Clear();
            dgvTitulos.AutoGenerateColumns = false;
            dgvTitulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTitulos.MultiSelect = false;
            dgvTitulos.ReadOnly = true;
            dgvTitulos.AllowUserToAddRows = false;
            dgvTitulos.AllowUserToDeleteRows = false;
            dgvTitulos.RowHeadersVisible = false;
            dgvTitulos.BackgroundColor = Color.White;
            dgvTitulos.BorderStyle = BorderStyle.None;
            dgvTitulos.GridColor = Color.FromArgb(241, 245, 249);
            dgvTitulos.RowTemplate.Height = 30;

            dgvTitulos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 252);
            dgvTitulos.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(100, 116, 139);
            dgvTitulos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dgvTitulos.ColumnHeadersHeight = 32;
            dgvTitulos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgvTitulos.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvTitulos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(238, 242, 255);
            dgvTitulos.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 41, 59);

            Col("IdTitulo", "ID", 55, false, DataGridViewContentAlignment.MiddleCenter, "");
            Col("IdCliente", "Cód.", 55, false, DataGridViewContentAlignment.MiddleCenter, "");
            Col("NomeCliente", "Cliente", 0, true, DataGridViewContentAlignment.MiddleLeft, "");
            Col("DataEmissao", "Emissão", 90, false, DataGridViewContentAlignment.MiddleCenter, "dd/MM/yyyy");
            Col("DataVencimento", "Vencimento", 90, false, DataGridViewContentAlignment.MiddleCenter, "dd/MM/yyyy");
            Col("ValorAReceber", "A Receber", 105, false, DataGridViewContentAlignment.MiddleRight, "C2");
            Col("ValorRecebido", "Recebido", 105, false, DataGridViewContentAlignment.MiddleRight, "C2");
            Col("Diferenca", "Saldo", 105, false, DataGridViewContentAlignment.MiddleRight, "C2");
            Col("Status", "Status", 95, false, DataGridViewContentAlignment.MiddleCenter, "");

            dgvTitulos.CellFormatting += dgvTitulos_CellFormatting;
            dgvTitulos.SelectionChanged += dgvTitulos_SelectionChanged;
        }

        private void Col(string prop, string header, int w, bool fill,
                         DataGridViewContentAlignment align, string fmt)
        {
            DataGridViewTextBoxColumn c = new DataGridViewTextBoxColumn
            {
                DataPropertyName = prop,
                HeaderText = header,
                Width = w,
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.Automatic,
                AutoSizeMode = fill ? DataGridViewAutoSizeColumnMode.Fill
                                        : DataGridViewAutoSizeColumnMode.None
            };
            c.DefaultCellStyle.Alignment = align;
            if (!string.IsNullOrEmpty(fmt))
                c.DefaultCellStyle.Format = fmt;
            dgvTitulos.Columns.Add(c);
        }

        private void PreencherGrid(List<ContaReceber> lista)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = lista.OrderByDescending(t => t.DataVencimento).ToList();
            dgvTitulos.DataSource = bs;
            AtualizarTotais(lista);
            _selecionado = null;
            AtualizarBotoes();
        }

        private void dgvTitulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || dgvTitulos.Rows[e.RowIndex].DataBoundItem == null) return;
            ContaReceber t = (ContaReceber)dgvTitulos.Rows[e.RowIndex].DataBoundItem;
            bool venc = t.Status != "Pago" && t.DataVencimento.Date < DateTime.Today;

            if (!dgvTitulos.Rows[e.RowIndex].Selected)
            {
                Color bg;
                if (t.Status == "Pago") bg = Color.FromArgb(240, 253, 244);
                else if (t.Status == "Pago Parcial") bg = Color.FromArgb(254, 252, 232);
                else if (venc) bg = Color.FromArgb(254, 242, 242);
                else bg = Color.White;
                dgvTitulos.Rows[e.RowIndex].DefaultCellStyle.BackColor = bg;
            }

            string colProp = dgvTitulos.Columns[e.ColumnIndex].DataPropertyName;
            DataGridViewCell cell = dgvTitulos.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (colProp == "Status")
            {
                string txt = venc && t.Status != "Pago" ? "Vencido" : t.Status;
                e.Value = txt; e.FormattingApplied = true;
                if (txt == "Pago") cell.Style.ForeColor = CorVerde;
                else if (txt == "Pago Parcial") cell.Style.ForeColor = Color.FromArgb(29, 78, 216);
                else if (txt == "Vencido") cell.Style.ForeColor = CorVermelho;
                else cell.Style.ForeColor = Color.FromArgb(146, 64, 14);
                cell.Style.Font = new Font(dgvTitulos.DefaultCellStyle.Font, FontStyle.Bold);
            }

            if (colProp == "Diferenca")
            {
                cell.Style.ForeColor = t.Diferenca > 0 ? CorVermelho : CorVerde;
                cell.Style.Font = new Font(dgvTitulos.DefaultCellStyle.Font, FontStyle.Bold);
            }
        }

        // ── Seleção → habilita botões ─────────────────────────────────
        private void dgvTitulos_SelectionChanged(object sender, EventArgs e)
        {
            _selecionado = dgvTitulos.SelectedRows.Count > 0 &&
                           dgvTitulos.SelectedRows[0].DataBoundItem != null
                ? (ContaReceber)dgvTitulos.SelectedRows[0].DataBoundItem
                : null;
            AtualizarBotoes();
        }

        private void AtualizarBotoes()
        {
            bool tem = _selecionado != null;
            bool naoQuit = tem && _selecionado.Status != "Pago";
            bool temPag = tem && _selecionado.Status != "Aberto";

            btnReceber.Enabled = naoQuit;
            btnEditar.Enabled = tem;
            btnEstornar.Enabled = temPag;

            btnReceber.BackColor = naoQuit ? Color.FromArgb(22, 163, 74) : Color.FromArgb(148, 163, 184);
            btnEditar.BackColor = tem ? Color.FromArgb(245, 158, 11) : Color.FromArgb(148, 163, 184);
            btnEstornar.BackColor = temPag ? Color.FromArgb(220, 38, 38) : Color.FromArgb(148, 163, 184);

            // Painel de info da linha selecionada
            if (tem)
            {
                bool venc = _selecionado.Status != "Pago" &&
                            _selecionado.DataVencimento.Date < DateTime.Today;
                string status = venc ? "Vencido" : _selecionado.Status;

                lblSelInfo.Text =
                    string.Format("Título #{0}  |  {1}  |  A Receber: {2}  |  Recebido: {3}  |  Saldo: {4}  |  Status: {5}",
                        _selecionado.IdTitulo,
                        _selecionado.NomeCliente,
                        _selecionado.ValorAReceber.ToString("C2", _ptBR),
                        _selecionado.ValorRecebido.ToString("C2", _ptBR),
                        _selecionado.Diferenca.ToString("C2", _ptBR),
                        status);

                lblSelInfo.ForeColor =
                    status == "Pago" ? CorVerde :
                    status == "Vencido" ? CorVermelho :
                    status == "Pago Parcial" ? Color.FromArgb(29, 78, 216) :
                                              Color.FromArgb(146, 64, 14);
                pnlSelecao.Visible = true;
            }
            else
            {
                pnlSelecao.Visible = false;
            }
        }

        // ── Ações ─────────────────────────────────────────────────────
        private void btnReceber_Click(object sender, EventArgs e)
        {
            if (_selecionado == null) return;
            LancarTituloRecebido frm = new LancarTituloRecebido();
            frm.PreCarregarTitulo(_selecionado.IdTitulo);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            Recarregar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (_selecionado == null) return;
            AlterarTitulo frm = new AlterarTitulo();
            frm.PreCarregarTitulo(_selecionado.IdTitulo);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            Recarregar();
        }

        private void btnEstornar_Click(object sender, EventArgs e)
        {
            if (_selecionado == null) return;
            EstornarTitulo frm = new EstornarTitulo();
            frm.PreCarregarTitulo(_selecionado.IdTitulo);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            Recarregar();
        }

        private void Recarregar()
        {
            CarregarDados();
            AplicarFiltro();
        }

        // ── Filtros ───────────────────────────────────────────────────
        private void btnBuscar_Click(object sender, EventArgs e) => AplicarFiltro();

        private void AplicarFiltro()
        {
            string cod = txtCodCliente.Text.Trim();
            string nome = txtNomeCliente.Text.Trim().ToLower();
            string idTit = txtIdTitulo.Text.Trim();
            string st = cmbStatus.SelectedItem != null ? cmbStatus.SelectedItem.ToString() : "";

            decimal vMin = 0, vMax = 0;
            decimal.TryParse(txtValorMin.Text.Trim(), NumberStyles.Any, _ptBR, out vMin);
            decimal.TryParse(txtValorMax.Text.Trim(), NumberStyles.Any, _ptBR, out vMax);

            DateTime dtEm = dtpEmissao.Checked ? dtpEmissao.Value.Date : DateTime.MinValue;
            DateTime dtVIni = dtpVencIni.Checked ? dtpVencIni.Value.Date : DateTime.MinValue;
            DateTime dtVFim = dtpVencFim.Checked ? dtpVencFim.Value.Date : DateTime.MaxValue;

            _filtrados = _todos.Where(t =>
            {
                if (!string.IsNullOrEmpty(cod) && !t.IdCliente.ToString().Contains(cod)) return false;
                if (!string.IsNullOrEmpty(nome) && !t.NomeCliente.ToLower().Contains(nome)) return false;
                if (!string.IsNullOrEmpty(idTit) && t.IdTitulo.ToString() != idTit) return false;
                if (st != "" && st != "Todos")
                {
                    bool v = t.Status != "Pago" && t.DataVencimento.Date < DateTime.Today;
                    if ((v ? "Vencido" : t.Status) != st) return false;
                }
                if (vMin > 0 && t.ValorAReceber < vMin) return false;
                if (vMax > 0 && t.ValorAReceber > vMax) return false;
                if (dtEm != DateTime.MinValue && t.DataEmissao.Date != dtEm) return false;
                if (dtVIni != DateTime.MinValue && t.DataVencimento.Date < dtVIni) return false;
                if (dtVFim != DateTime.MaxValue && t.DataVencimento.Date > dtVFim) return false;
                return true;
            }).ToList();

            PreencherGrid(_filtrados);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodCliente.Clear(); txtNomeCliente.Clear();
            txtIdTitulo.Clear(); txtValorMin.Clear(); txtValorMax.Clear();
            if (cmbStatus.Items.Count > 0) cmbStatus.SelectedIndex = 0;
            dtpEmissao.Checked = false;
            dtpVencIni.Checked = false;
            dtpVencFim.Checked = false;
            _filtrados = new List<ContaReceber>(_todos);
            PreencherGrid(_filtrados);
        }

        // ── Totalizadores ─────────────────────────────────────────────
        private void AtualizarTotais(List<ContaReceber> lista)
        {
            lblTotalTitulos.Text = lista.Count.ToString();
            lblTotalAReceber.Text = lista.Sum(t => t.ValorAReceber).ToString("C2", _ptBR);
            lblTotalRecebido.Text = lista.Sum(t => t.ValorRecebido).ToString("C2", _ptBR);
            lblTotalSaldo.Text = lista.Sum(t => t.Diferenca).ToString("C2", _ptBR);
        }
    }
}