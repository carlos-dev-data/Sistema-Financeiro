using Newtonsoft.Json;
using Sistema_Financeiro.Conexao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sistema_Financeiro.Form_Relatorios
{
    public partial class TitulosAReceber : Form
    {
        private List<ContaReceber> _todos = new List<ContaReceber>();
        private List<ContaReceber> _filtrados = new List<ContaReceber>();

        private readonly Color CorVerde = Color.FromArgb(46, 125, 50);
        private readonly Color CorVermelho = Color.FromArgb(229, 57, 53);

        public TitulosAReceber()
        {
            InitializeComponent();
        }

        private void TitulosAReceber_Load(object sender, EventArgs e)
        {
            cmbStatusFinan.Items.Clear();
            cmbStatusFinan.Items.AddRange(new object[] { "Todos", "Aberto", "Pago", "Pago Parcial", "Vencido" });
            cmbStatusFinan.SelectedIndex = 0;
            // Garante que os filtros de data iniciam desmarcados
            dtpEmissaoFinan.Checked = false;
            dtpVencimentoIniFinan.Checked = false;
            dtpVencimentoFinalFinan.Checked = false;

            ConfigurarGrid();
            CarregarDados();
        }

        private void CarregarDados()
        {
            try
            {
                string cam = new ContaReceber().caminhoArquivoContaReceber;
                if (File.Exists(cam))
                {
                    var settings = new JsonSerializerSettings
                    {
                        DateTimeZoneHandling = DateTimeZoneHandling.Local  // ← corrige o fuso -04:00
                    };

                    _todos = JsonConvert.DeserializeObject<List<ContaReceber>>(
                                 File.ReadAllText(cam), settings)
                             ?? new List<ContaReceber>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERRO ao carregar: {ex.Message}");
                _todos = new List<ContaReceber>();
            }

            _filtrados = new List<ContaReceber>(_todos);
            PreencherGrid(_filtrados);
        }

        // ── Configurar DataGridView ────────────────────────────────
        private void ConfigurarGrid()
        {
            dgvTitulos.Columns.Clear();

            AdicionarColuna("IdTitulo", "ID", 60, false);
            AdicionarColuna("IdCliente", "Cód. Cliente", 90, false);
            AdicionarColuna("NomeCliente", "Nome Cliente", 200, true);
            AdicionarColuna("DataEmissao", "Dt. Emissão", 100, false);
            AdicionarColuna("DataVencimento", "Dt. Vencimento", 100, false);
            AdicionarColuna("ValorAReceber", "Valor a Receber", 110, false);
            AdicionarColuna("ValorRecebido", "Valor Recebido", 110, false);
            AdicionarColuna("Diferenca", "Saldo", 100, false);
            AdicionarColuna("Status", "Status", 95, false);

            dgvTitulos.AutoGenerateColumns = false;
            dgvTitulos.CellFormatting += dgvTitulos_CellFormatting;
        }

        private void AdicionarColuna(string prop, string header, int width, bool fill)
        {
            var col = new DataGridViewTextBoxColumn
            {
                DataPropertyName = prop,
                HeaderText = header,
                Width = width,
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.Automatic,
                AutoSizeMode = fill
                     ? DataGridViewAutoSizeColumnMode.Fill
                     : DataGridViewAutoSizeColumnMode.None
            };

            if (prop == "ValorAReceber" || prop == "ValorRecebido" || prop == "Diferenca")
                col.DefaultCellStyle.Format = "C2";

            if (prop == "DataEmissao" || prop == "DataVencimento")
                col.DefaultCellStyle.Format = "dd/MM/yyyy";

            col.DefaultCellStyle.Alignment =
                (prop.Contains("Valor") || prop == "Diferenca")
                ? DataGridViewContentAlignment.MiddleRight
                : DataGridViewContentAlignment.MiddleLeft;

            dgvTitulos.Columns.Add(col);
        }

        // ── Preencher grid ─────────────────────────────────────────
        private void PreencherGrid(List<ContaReceber> lista)
        {
            var bs = new BindingSource();
            bs.DataSource = lista.OrderByDescending(t => t.DataVencimento).ToList();
            dgvTitulos.DataSource = bs;
            AtualizarTotais(lista);
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dgvTitulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || dgvTitulos.Rows[e.RowIndex].DataBoundItem == null) return;
            var t = (ContaReceber)dgvTitulos.Rows[e.RowIndex].DataBoundItem;

            bool vencido = t.Status != "Pago" && t.DataVencimento.Date < DateTime.Today;

            Color bg;
            if (t.Status == "Pago")
            {
                bg = Color.FromArgb(232, 245, 233);
            }
            else if (t.Status == "Pago Parcial")
            {
                bg = Color.FromArgb(255, 249, 196);
            }
            else if (vencido)
            {
                bg = Color.FromArgb(255, 235, 238);
            }
            else
            {
                bg = Color.White;
            }

            if (!dgvTitulos.Rows[e.RowIndex].Selected)
                dgvTitulos.Rows[e.RowIndex].DefaultCellStyle.BackColor = bg;

            // Status — exibe "Vencido" quando aplicável
            if (dgvTitulos.Columns[e.ColumnIndex].DataPropertyName == "Status" && vencido && t.Status != "Pago")
            {
                e.Value = "Vencido";
                e.FormattingApplied = true;
            }

            // Saldo — vermelho se tem saldo, verde se quitado
            if (dgvTitulos.Columns[e.ColumnIndex].DataPropertyName == "Diferenca")
            {
                dgvTitulos.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor =
                    t.Diferenca > 0 ? CorVermelho : CorVerde;
                dgvTitulos.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Font =
                    new Font(dgvTitulos.Font, FontStyle.Bold);
            }
        }

        // ── Totalizadores ──────────────────────────────────────────
        private void AtualizarTotais(List<ContaReceber> lista = null)
        {
            var src = lista ?? _todos;
            var ptBR = new System.Globalization.CultureInfo("pt-BR");

            lblTotalTitulos.Text = src.Count.ToString();
            lblTotalAReceber.Text = src.Sum(t => t.ValorAReceber).ToString("C2", ptBR);
            lblTotalRecebido.Text = src.Sum(t => t.ValorRecebido).ToString("C2", ptBR);
            lblTotalSaldo.Text = src.Sum(t => t.Diferenca).ToString("C2", ptBR);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cod = txtCodCliente.Text.Trim();
            string nome = txtNomeClienteFinan.Text.Trim().ToLower();
            string idTit = txtIdTituloFinan.Text.Trim();
            string status = cmbStatusFinan.SelectedItem?.ToString() ?? "";

            decimal.TryParse(txtValorMinFinan.Text.Replace("R$", "").Trim(), out decimal vMin);
            decimal.TryParse(txtValorMaxFinan.Text.Replace("R$", "").Trim(), out decimal vMax);

            // Datas "zeradas" = não filtrar. Só filtra se diferente do valor padrão (DateTime.MinValue)
            DateTime dtEmissao = dtpEmissaoFinan.Checked ? dtpEmissaoFinan.Value.Date : DateTime.MinValue;
            DateTime dtVencIni = dtpVencimentoIniFinan.Checked ? dtpVencimentoIniFinan.Value.Date : DateTime.MinValue;
            DateTime dtVencFinal = dtpVencimentoFinalFinan.Checked ? dtpVencimentoFinalFinan.Value.Date : DateTime.MaxValue;

            _filtrados = _todos.Where(t =>
            {
                if (!string.IsNullOrEmpty(cod) && !t.IdCliente.ToString().Contains(cod)) return false;
                if (!string.IsNullOrEmpty(nome) && !t.NomeCliente.ToLower().Contains(nome)) return false;
                if (!string.IsNullOrEmpty(idTit) && t.IdTitulo.ToString() != idTit) return false;

                if (status != "" && status != "Todos")
                {
                    bool vencido = t.Status != "Pago" && t.DataVencimento.Date < DateTime.Today;
                    string stReal = vencido ? "Vencido" : t.Status;
                    if (stReal != status) return false;
                }

                if (vMin > 0 && t.ValorAReceber < vMin) return false;
                if (vMax > 0 && t.ValorAReceber > vMax) return false;

                if (dtEmissao != DateTime.MinValue && t.DataEmissao.Date != dtEmissao) return false;
                if (dtVencIni != DateTime.MinValue && t.DataVencimento.Date < dtVencIni) return false;
                if (dtVencFinal != DateTime.MaxValue && t.DataVencimento.Date > dtVencFinal) return false;

                return true;
            }).ToList();

            PreencherGrid(_filtrados);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodCliente.Clear();
            txtNomeClienteFinan.Clear();
            txtIdTituloFinan.Clear();
            txtValorMinFinan.Clear();
            txtValorMaxFinan.Clear();

            // Só seta index se tiver itens
            if (cmbStatusFinan.Items.Count > 0)
                cmbStatusFinan.SelectedIndex = 0;
            else
                cmbStatusFinan.SelectedIndex = -1;

            dtpEmissaoFinan.Checked = false;
            dtpVencimentoIniFinan.Checked = false;
            dtpVencimentoFinalFinan.Checked = false;
            dtpEmissaoFinan.Value = DateTime.Today;
            dtpVencimentoIniFinan.Value = DateTime.Today;
            dtpVencimentoFinalFinan.Value = DateTime.Today;

            _filtrados = new List<ContaReceber>(_todos);
            PreencherGrid(_filtrados);
        }


        private void dgvTitulos_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
