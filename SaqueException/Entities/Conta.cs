using SaqueException.Entities.MinhasExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaqueException.Entities
{
    internal class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; } = 50;
        public double LimiteDeSaque { get; set; }
        public Conta()
        {
            
        }

        public Conta(int numero, string titular, double limiteDeSaque)
        {
            Numero = numero;
            Titular = titular;
            LimiteDeSaque = limiteDeSaque;
        }


        public void Deposito(double valor)
        {
            if (valor == 0.0)
            {
                throw new DominioException("O valor depositado precisa ser maior que 0");
            }
            Saldo += valor;
           
        }

        public void Saque(double valor) {
           
            if (valor > Saldo || valor >LimiteDeSaque)
            {
                throw new DominioException("O valor do Saque é maior que o Saldo Atual!");
            }
            if (valor <= Saldo)
            {
               // valor -= Saldo;
                Saldo -= valor;
               
            }
        }

        public override string ToString()
        {
            return $"{Titular} "+$"O seu saldo Atual é: {Saldo}";
        }


    }
}
