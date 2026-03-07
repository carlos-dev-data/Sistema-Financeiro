using System;
using System.Collections.Generic;

namespace Sistema_Financeiro.Conexao
{
    public class ContaRecebido
    {
        public int IdTitulo { get; set; }
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataBaixa { get; set; }
        public decimal ValorRecebido { get; set; }

        public string caminhoArquivoContaRecebido =
            @"C:\PROJETO\Financeiro\Sistema Financeiro\Sistema Financeiro\DataBase\ContaRecebido.json";
    }
}