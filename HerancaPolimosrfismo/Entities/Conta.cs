using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimosrfismo.Entities
{
    internal class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; protected set; }


        public Conta()
        {
            
        }
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
         public virtual void Saque(double quantia)
        {
            Saldo -= quantia+5.0;//TaXA DE 5 reais para saques
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }


    }
}
