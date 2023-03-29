using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Conta
    {
        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }
        public string Nome { get; set; }
       

        public Conta(string nome, int numeroConta) : this()
        {
            Nome = nome;
            NumeroConta = numeroConta;
        }

        public Conta()
        {
            Saldo = 0.0;
        }
        public Conta(Double depositoInicial) : this()
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }
        public void Saque(double saque)
        {
            Saldo = (Saldo - saque) - 5;
        }

        public override string ToString()
        {
            return "Titular: " + Nome
                + ", Conta:  " + NumeroConta +
                " Valor do Saldo é: $" + Saldo.ToString("f2", CultureInfo.CurrentCulture);
        }
    }
}
