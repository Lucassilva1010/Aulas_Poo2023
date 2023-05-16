using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestricoesGenericas_AvaliaProdutos.Entities
{
    internal class Produto: IComparable
    {
        public String  Nome { get; set; }
        public double  Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return $"{Nome}, {Preco.ToString("f2",CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Produto))
            {
                throw new ArgumentException("Erro de Comparação: O objeto não é um argumento!");
            }    
            Produto outroP = obj as Produto;
            return Preco.CompareTo(outroP.Preco);
        }
    }
}
