using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoContribuintes.Entities
{
    abstract class Pessoa
    {
        public string  Nome { get; set; }
        public double RendaAnual { get; set; }
        public Pessoa()
        {
            
        }

        public Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double CalculaImposto();


    }
}
