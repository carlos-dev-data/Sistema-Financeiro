using System;
using System.Collections.Generic;
using System.Linq;

namespace Sistema_Financeiro.Conexao
{
    public class ContaReceber
    {
        public int IdTitulo { get; set; }
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime? DataPagamento { get; set; }  // nullable pois pode não ter sido pago ainda
        public decimal ValorAReceber { get; set; }
        public decimal ValorRecebido { get; set; } = 0;
        public decimal Diferenca => ValorAReceber - ValorRecebido; // calculado automaticamente
        public string Status { get; set; } = "Aberto"; // Aberto / Pago Parcial / Pago

        // Caminho agora vem da configuração salva pelo usuário
        public string caminhoArquivoContaReceber => AppConfig.Instancia.CaminhoContaReceber;

        // Gerar próximo ID automaticamente
        public int GerarProximoId(List<ContaReceber> lista)
        {
            if (lista == null || lista.Count == 0) return 1;
            return lista.Max(c => c.IdTitulo) + 1;
        }

        // Estornar pagamento (total ou parcial)
        public string EstornarPagamento(decimal valorEstorno)
        {
            if (Status == "Aberto")
                return "Este título não possui pagamentos para estornar.";
            if (valorEstorno <= 0)
                return "Informe um valor válido para estorno.";
            if (valorEstorno > ValorRecebido)
                return $"Valor de estorno ({valorEstorno:C2}) é maior que o valor já recebido ({ValorRecebido:C2}).";

            ValorRecebido -= valorEstorno;
            DataPagamento = ValorRecebido > 0 ? DataPagamento : (DateTime?)null;

            if (ValorRecebido == 0)
                Status = "Aberto";
            else
                Status = "Pago Parcial";

            return "OK";
        }

        // Registrar pagamento (total ou parcial)
        public string RegistrarPagamento(decimal valorPagamento, DateTime value)
        {
            if (Status == "Pago")
                return "Este título já está totalmente pago.";
            if (valorPagamento <= 0)
                return "Informe um valor válido.";
            if (valorPagamento > Diferenca)
                return $"Valor informado ({valorPagamento:C2}) é maior que o saldo restante ({Diferenca:C2}).";

            ValorRecebido += valorPagamento;
            DataPagamento = DateTime.Now;

            if (Diferenca == 0)
                Status = "Pago";
            else
                Status = "Pago Parcial";

            return "OK";
        }
    }
}