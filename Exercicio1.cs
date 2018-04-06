using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteExercicio1.Util
{
    public class Exercicio1
    {
        public int VerificaMenorDiferençaEntreNumeros(List<int> pLista1, List<int> pLista2)
        {
            if (pLista1.Count == 0 || pLista2.Count == 0)
                return -1;
            
            int? iMenorNumero = null;

            foreach (int NumeroLista1 in pLista1)
            {
                foreach (int NumeroLista2 in pLista2)
                {
                    if (iMenorNumero == null)
                        iMenorNumero = Math.Abs(NumeroLista1 - NumeroLista2);
                    else if (iMenorNumero > Math.Abs(NumeroLista1 - NumeroLista2))
                        iMenorNumero = Math.Abs(NumeroLista1 - NumeroLista2);

                    if (iMenorNumero == 0)
                        return iMenorNumero.Value;
                }
            }

            return iMenorNumero.Value;
        }

        public int VerificaMenorDiferençaEntreNumerosListaOrdenada(List<int> pLista1, List<int> pLista2)
        {
            if (pLista1 == null || pLista2 == null || pLista1.Count == 0 || pLista2.Count == 0)
                return -1;

            int iMenorNumero = Math.Abs(pLista1[0] - pLista2[0]);
            int iIndiceLista2 = 0;

            foreach (int NumeroLista1 in pLista1)
            {
                if (iMenorNumero == 0)
                    return iMenorNumero;

                while (iIndiceLista2 < pLista2.Count && pLista2[iIndiceLista2] <= NumeroLista1) 
                    iIndiceLista2++;

                if (iIndiceLista2 == pLista2.Count && pLista2.Count > 1)
                    iIndiceLista2--;

                if (iMenorNumero > Math.Abs(pLista2[iIndiceLista2] - NumeroLista1))
                    iMenorNumero = Math.Abs(pLista2[iIndiceLista2] - NumeroLista1);

                if (iIndiceLista2 > 0 && iMenorNumero > Math.Abs(pLista2[iIndiceLista2 - 1] - NumeroLista1))
                    iMenorNumero = Math.Abs(pLista2[iIndiceLista2 - 1] - NumeroLista1);
            }

            return iMenorNumero;
        }
        
    }
}
