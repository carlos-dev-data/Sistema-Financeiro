using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Financeiro.Conexao
{
    public static class Uteis
    {
        public static List<T> CarregarDoJson<T>(string caminhoArquivo) where T : class
        {
            if (!System.IO.File.Exists(caminhoArquivo))
                return new List<T>();

            string json = System.IO.File.ReadAllText(caminhoArquivo);
            return JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();
        }

        public static void SalvarNoJson<T>(string caminhoArquivo, T novoItem) where T : class
        {
            List<T> lista = CarregarDoJson<T>(caminhoArquivo);

            lista.Add(novoItem);

            string jsonResult = JsonConvert.SerializeObject(lista, Formatting.Indented);
            System.IO.File.WriteAllText(caminhoArquivo, jsonResult);
        }
    }
}
