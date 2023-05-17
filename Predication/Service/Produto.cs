using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predication.Service
{
    class Produto
    {
        public string  Nome { get; set; }
        public double Valor { get; set; }

        public Produto(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public override string ToString()
        {
            return $"{Nome}, {Valor.ToString("f2",CultureInfo.InvariantCulture)}";
        }
    }
}
