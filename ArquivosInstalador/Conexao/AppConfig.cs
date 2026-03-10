using Newtonsoft.Json;
using System;
using System.IO;
using System.Text.Json;

namespace Sistema_Financeiro.Conexao
{
    public class AppConfig
    {
        private static readonly string ConfigFolder =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SistemaFinanceiro");

        private static readonly string ConfigFilePath =
            Path.Combine(ConfigFolder, "config.json");

        public string CaminhoClientes { get; set; } =
            @"C:\PROJETO\Financeiro\Sistema Financeiro\Sistema Financeiro\DataBase\Clientes.json";

        public string CaminhoContaReceber { get; set; } =
            @"C:\PROJETO\Financeiro\Sistema Financeiro\Sistema Financeiro\DataBase\ContaReceber.json";

        // Instância global acessível em todo o projeto
        private static AppConfig _instancia;
        public static AppConfig Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = Carregar();
                return _instancia;
            }
        }

        public static AppConfig Carregar()
        {
            try
            {
                if (File.Exists(ConfigFilePath))
                {
                    string json = File.ReadAllText(ConfigFilePath);
                    return System.Text.Json.JsonSerializer.Deserialize<AppConfig>(json) ?? new AppConfig();
                }
            }
            catch { }

            return new AppConfig();
        }

        public void Salvar()
        {
            try
            {
                if (!Directory.Exists(ConfigFolder))
                    Directory.CreateDirectory(ConfigFolder);

                string json = System.Text.Json.JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(ConfigFilePath, json);

                // Atualiza a instância global
                _instancia = this;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar configurações: {ex.Message}");
            }
        }
    }
}