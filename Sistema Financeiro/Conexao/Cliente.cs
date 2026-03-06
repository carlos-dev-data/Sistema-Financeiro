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

        public string caminhoArquivoCliente = @"C:\PROJETO\Financeiro\Sistema Financeiro\Sistema Financeiro\DataBase\Clientes.json";

        // Criamos uma lista vazia para armazenar os cliente na memória
        public List<Cliente> listaCliente = new List<Cliente>();

    }
}
