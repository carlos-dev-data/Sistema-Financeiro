using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Financeiro.Configuracao
{
    public partial class Formconfiguracoes : Form
    {
        public Formconfiguracoes()
        {
            InitializeComponent();
            CarregarConfiguracoes();
        }

        private void CarregarConfiguracoes()
        {
            txtCaminhoClientes.Text = Conexao.AppConfig.Instancia.CaminhoClientes;
            txtCaminhoContaReceber.Text = Conexao.AppConfig.Instancia.CaminhoContaReceber;
            AtualizarStatusArquivos();
        }

        private void AtualizarStatusArquivos()
        {
            bool clientesOk = File.Exists(txtCaminhoClientes.Text);
            lblStatusClientes.Text = clientesOk ? "✔ Arquivo encontrado" : "✘ Arquivo não encontrado";
            lblStatusClientes.ForeColor = clientesOk ? System.Drawing.Color.Green : System.Drawing.Color.Red;

            bool contaOk = File.Exists(txtCaminhoContaReceber.Text);
            lblStatusContaReceber.Text = contaOk ? "✔ Arquivo encontrado" : "✘ Arquivo não encontrado";
            lblStatusContaReceber.ForeColor = contaOk ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        }

        private string AbrirDialogArquivo(string nomeArquivoPadrao, string caminhoAtual)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Selecionar arquivo JSON";
                dialog.Filter = "Arquivos JSON (*.json)|*.json|Todos os arquivos (*.*)|*.*";
                dialog.FileName = nomeArquivoPadrao;

                string pastaPadrao = Path.GetDirectoryName(caminhoAtual);
                if (Directory.Exists(pastaPadrao))
                    dialog.InitialDirectory = pastaPadrao;

                if (dialog.ShowDialog() == DialogResult.OK)
                    return dialog.FileName;
            }
            return null;
        }

        // ✔ Método correto com um único parâmetro
        private void CriarArquivoJson(string caminho)
        {
            try
            {
                string pasta = Path.GetDirectoryName(caminho);
                if (!string.IsNullOrWhiteSpace(pasta) && !Directory.Exists(pasta))
                    Directory.CreateDirectory(pasta);

                if (!File.Exists(caminho))
                {
                    File.WriteAllText(caminho, "[]");
                    MessageBox.Show("Arquivo criado com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("O arquivo já existe.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                AtualizarStatusArquivos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar arquivo:\n{ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Formconfiguracoes_Load(object sender, EventArgs e)
        {

        }

        private void txtCaminhoClientes_TextChanged(object sender, EventArgs e)
        {
            AtualizarStatusArquivos();
        }

        private void txtCaminhoContaReceber_TextChanged(object sender, EventArgs e)
        {
            AtualizarStatusArquivos();
        }

        private void btnProcurarClientes_Click(object sender, EventArgs e)
        {
            string caminho = AbrirDialogArquivo("Clientes.json", txtCaminhoClientes.Text);
            if (caminho != null)
            {
                txtCaminhoClientes.Text = caminho;
                AtualizarStatusArquivos();
            }
        }

        private void btnProcurarContaReceber_Click(object sender, EventArgs e)
        {
            string caminho = AbrirDialogArquivo("ContaReceber.json", txtCaminhoContaReceber.Text);
            if (caminho != null)
            {
                txtCaminhoContaReceber.Text = caminho;
                AtualizarStatusArquivos();
            }
        }

        private void btnCriarClientes_Click(object sender, EventArgs e)
        {
            CriarArquivoJson(txtCaminhoClientes.Text);
        }

        private void btnCriarContaReceber_Click(object sender, EventArgs e)
        {
            CriarArquivoJson(txtCaminhoContaReceber.Text);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCaminhoClientes.Text) ||
                string.IsNullOrWhiteSpace(txtCaminhoContaReceber.Text))
            {
                MessageBox.Show("Preencha todos os caminhos antes de salvar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var config = Conexao.AppConfig.Instancia;
                config.CaminhoClientes = txtCaminhoClientes.Text.Trim();
                config.CaminhoContaReceber = txtCaminhoContaReceber.Text.Trim();
                config.Salvar();

                MessageBox.Show("Configurações salvas com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar:\n{ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
