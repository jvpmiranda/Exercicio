using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteExercicio1.Util
{
    public class Exercicio2
    {
        private Dictionary<string, int> QuantidadeOcorrencias;

        private List<string> ListaUrls;

        public Exercicio2(List<string> pListaUrls)
        {
            QuantidadeOcorrencias = new Dictionary<string, int>();
            ListaUrls = pListaUrls;
        }

        public int NumeroVezesStringOcorreDentroDeLista(string pUrl)
        {
            if (QuantidadeOcorrencias.ContainsKey(pUrl))
            {
                return QuantidadeOcorrencias[pUrl];
            }
            else
            {
                int iQuantidade = 0;

                int iIndicePrimeiraOcorrencia = ListaUrls.IndexOf(pUrl);

                while (iIndicePrimeiraOcorrencia >= 0)
                {
                    iQuantidade++;
                    ListaUrls.RemoveAt(iIndicePrimeiraOcorrencia);
                    iIndicePrimeiraOcorrencia = ListaUrls.IndexOf(pUrl);
                }

                QuantidadeOcorrencias.Add(pUrl, iQuantidade);

                return iQuantidade;
            }
        }
    }
}
