using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoContribuintes.Entities
{
    internal class PFisica : Pessoa
    {
        public double GastoComSaude { get; set; }
      

        public PFisica()
        {

        }

        public PFisica(string nome, double rendaAnual, double gastoComSaude) : base(nome, rendaAnual)
        {
            GastoComSaude = gastoComSaude;
        }

        public override double CalculaImposto()
        {
            double taxaRenda = 0.0;
            double gastoSaude = 0.0;
            
            if (RendaAnual < 20000.00)
            {

                taxaRenda = RendaAnual * 0.15;


                if (GastoComSaude != 0.0)
                {
                    gastoSaude = GastoComSaude * 0.50;
                    taxaRenda -= gastoSaude;
                }
                RendaAnualDescontada = RendaAnual - taxaRenda;//Analisar para colocar em Pessoal em Juridica

            }
            else if (RendaAnual > 20000.00)
            {
                taxaRenda = RendaAnual * 0.25;

                if (GastoComSaude != 0.0)
                {
                    gastoSaude = GastoComSaude * 0.50;
                    taxaRenda -= gastoSaude;
                }

            }

            return taxaRenda;
        }

        public void ValorFinal(double rendaAnual)
        {

        }
    }
}
