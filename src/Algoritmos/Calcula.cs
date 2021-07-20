using System.Collections.Generic;
using System.Linq;

namespace Algoritmos
{
    public class Calcula
    {
        public int VerificaMaiorNumero(List<int> lista)
        {
            var maior = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                var item = lista[i];

                if (item > maior)
                {
                    maior = item;
                }
            }

            return maior;
        }

        public string VerificaMaiorNumeroMelhor(List<int> lista)
        { 
            return $@"MAIOR:{lista.Max()}  MENOR:{lista.Min()}";
        }

        public int VerificaMenorNumeroMelhor(List<int> lista)
        {
            return lista.Min();
        }

        public int VerificaMenorNumero(List<int> lista)
        {
            int max = int.MaxValue;

            for (int i = 0; i < lista.Count; i++)
            {
                var item = lista[i];

                if (item < max)
                {
                    max = item;
                }
            }

            return max;
        }




    }
}
