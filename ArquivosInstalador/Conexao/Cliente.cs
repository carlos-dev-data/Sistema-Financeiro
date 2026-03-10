using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Financeiro.Conexao
{
    public class Cliente
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Telefone { get; set; }

        // Caminho agora vem da configuração salva pelo usuário
        public string caminhoArquivoCliente => AppConfig.Instancia.CaminhoClientes;

        // Criamos uma lista vazia para armazenar os clientes na memória
        public List<Cliente> listaCliente = new List<Cliente>();
    }
}