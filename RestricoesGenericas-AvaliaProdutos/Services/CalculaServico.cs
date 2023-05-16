using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestricoesGenericas_AvaliaProdutos.Services
{
    internal class CalculaServico
    {

        public T MaiorValor<T>(List<T> lista) where T : IComparable
        {
            if (lista.Count == 0)
            {
                throw new InvalidOperationException("O vetor já está Vazio.");
            }

            T max = lista[0];
            for (int i = 1; i < lista.Count; i++)
            {
                if (lista[i].CompareTo(max) > 0)
                {
                    max = lista[i];
                } 
            }
            return max;
        }


    }
}
