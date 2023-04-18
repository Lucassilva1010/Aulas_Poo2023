using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoContribuintes.Entities
{
    internal class Pjuridica : Pessoa
    {
        public int NumeroDeFuncionario { get; set; }

        public Pjuridica()
        {

        }

        public Pjuridica(string nome, double rendaAnual, int numeroDeFuncionario) : base(nome, rendaAnual)
        {
            NumeroDeFuncionario = numeroDeFuncionario;
        }
        public override double CalculaImposto()
        {
            double taxaRenda = 0.0;


            if (NumeroDeFuncionario >= 10)
            {
                taxaRenda = RendaAnual * 0.14;

            }
            else
            {

                taxaRenda = RendaAnual * 0.16;

            }


            return taxaRenda;
        }
    }
}
