using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimosrfismo.Entities
{
    sealed class Poupanca:Conta// classe Selada - não pode ser Herdada
    {
        public double TaxaDeJuros { get; set; }

        public Poupanca()
        {
            
        }

        public Poupanca(int numero, string titular, double saldo, double taxaDeJuros): base(numero,titular,saldo)
        {
            TaxaDeJuros = taxaDeJuros;
        }

        public void AtualizaSaldo()
        {
            Saldo +=Saldo * TaxaDeJuros;
        }


        //Sem  usar o BASE, e é a a melhor forma
        /* public override void Saque(double quantia)
         {
             Saldo -= quantia;
         }*/

        
        //Usando o BASE
        public  sealed override void Saque(double quantia)
        {
            base.Saque(quantia);
            
        }
    }
}
