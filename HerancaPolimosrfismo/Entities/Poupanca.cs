using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimosrfismo.Entities
{
    internal class Poupanca:Conta
    {
        public double TaxaDeJuros { get; set; }

        public Poupanca()
        {
            
        }

        public Poupanca(int numero, string titular, double saldo, double taxaDeJuros): base(numero,titular,saldo)
        {
            TaxaDeJuros = taxaDeJuros;
        }
    }
}
