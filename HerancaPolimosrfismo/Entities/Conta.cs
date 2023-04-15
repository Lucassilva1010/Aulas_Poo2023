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
         public void Saque(double quantia)
        {
            Saldo -= quantia;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }


    }
}
