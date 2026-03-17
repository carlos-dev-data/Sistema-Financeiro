using Newtonsoft.Json;
using Sistema_Financeiro.Conexao;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Sistema_Financeiro
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        public void CarregarDados()
        {
            try
            {
                CultureInfo ptBR = new CultureInfo("pt-BR");

                // ── Clientes ─────────────────────────────────────────
                int totalClientes = 0;
                string caminhoClientes = new Cliente().caminhoArquivoCliente;
                if (File.Exists(caminhoClientes))
                {
                    List<Cliente> clientes = JsonConvert.DeserializeObject<List<Cliente>>(
                        File.ReadAllText(caminhoClientes)) ?? new List<Cliente>();
                    totalClientes = clientes.Count;
                }
                lblValClientes.Text = totalClientes.ToString();

                // ── Títulos ───────────────────────────────────────────
                int totalAbertos = 0;
                int totalVencidos = 0;
                decimal recebidoMes = 0;
                decimal pendente = 0;

                string caminhoTitulos = new ContaReceber().caminhoArquivoContaReceber;
                if (File.Exists(caminhoTitulos))
                {
                    List<ContaReceber> titulos = JsonConvert.DeserializeObject<List<ContaReceber>>(
                        File.ReadAllText(caminhoTitulos)) ?? new List<ContaReceber>();

                    foreach (ContaReceber t in titulos)
                    {
                        bool vencido = t.Status != "Pago" && t.DataVencimento.Date < DateTime.Today;

                        if (t.Status != "Pago")
                        {
                            totalAbertos++;
                            pendente += t.Diferenca;
                        }

                        if (vencido)
                            totalVencidos++;

                        if (t.DataPagamento.HasValue &&
                            t.DataPagamento.Value.Month == DateTime.Today.Month &&
                            t.DataPagamento.Value.Year == DateTime.Today.Year)
                            recebidoMes += t.ValorRecebido;
                    }
                }

                lblValTitulos.Text = totalAbertos.ToString();
                lblValRecebido.Text = recebidoMes.ToString("C2", ptBR);
                lblValPendente.Text = pendente.ToString("C2", ptBR);
                lblValVencidos.Text = totalVencidos.ToString();

                // Cor dinâmica — vencidos ficam vermelhos, zero fica verde
                if (totalVencidos > 0)
                {
                    lblValVencidos.ForeColor = Color.FromArgb(220, 38, 38);
                    pnlCardVencidos.BackColor = Color.FromArgb(254, 242, 242);
                    pnlIconVencidos.BackColor = Color.FromArgb(254, 226, 226);
                }
                else
                {
                    lblValVencidos.ForeColor = Color.FromArgb(22, 163, 74);
                    pnlCardVencidos.BackColor = Color.FromArgb(240, 253, 244);
                    pnlIconVencidos.BackColor = Color.FromArgb(220, 252, 231);
                    lblSubVencidos.Text = "tudo em dia";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dashboard: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}