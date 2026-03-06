using Newtonsoft.Json;
using Sistema_Financeiro.Conexao;
using Sistema_Financeiro.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Financeiro.Form_Relatorios
{
    public partial class Rel_Clientes : Form
    {
        public Rel_Clientes()
        {
            InitializeComponent();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            if (System.IO.File.Exists(cliente.caminhoArquivoCliente))
            {
                string jsonLido = System.IO.File.ReadAllText(cliente.caminhoArquivoCliente);
                var listaCompleta = JsonConvert.DeserializeObject<List<Cliente>>(jsonLido)
                                    ?? new List<Cliente>();

                string filtroId = Txt_Id.Text.Trim();
                string filtroNome = Txt_NomeCliente.Text.Trim().ToLower();

                // MaskedTextBox: remove tudo que não for número para comparar corretamente
                string filtroTel = new string(Msk_Telefone.Text.Where(char.IsDigit).ToArray());

                var resultadoBusca = listaCompleta
                    .Where(a =>
                    {
                        bool passaId = string.IsNullOrEmpty(filtroId) || a.Id.ToString().Contains(filtroId);
                        bool passaNome = string.IsNullOrEmpty(filtroNome) || a.NomeCompleto.ToLower().Contains(filtroNome);

                        // Compara só os dígitos do telefone salvo com os dígitos digitados
                        string telSalvo = new string(a.Telefone.Where(char.IsDigit).ToArray());
                        bool passaTel = string.IsNullOrEmpty(filtroTel) || telSalvo.Contains(filtroTel);

                        return passaId && passaNome && passaTel;
                    })
                    .ToList();

                Dtw_Tabela.DataSource = null;
                Dtw_Tabela.DataSource = resultadoBusca;

                if (resultadoBusca.Count == 0)
                {
                    MessageBox.Show("Nenhum cliente encontrado com os filtros informados.",
                                    "Busca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nenhum cliente cadastrado.",
                                "Relatório de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
