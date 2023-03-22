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
        public string Nome { get; private set; }
        public int NumeroConta { get; set; }
        public double Saldo { get; set; }

        public Conta(string nome, int numeroConta): this()
        {
            Nome = nome;
            NumeroConta = numeroConta;
        }

        public Conta()
        {
            Saldo = 0.0;
        }
        public Conta(Double saldo) : this()
        {
            Saldo = saldo;
        }

        public void Deposito(double saldo)
        {
            Saldo += saldo;
        }
        public void Saque(double saque)
        {
            Saldo = (Saldo - saque)-5;
        }

        public override string ToString()
        {
            return "Titular: "+Nome
                +", Conta:  "+NumeroConta+
                " Valor do Saldo é: $"+Saldo.ToString("f2",CultureInfo.CurrentCulture);
        }
    }
}
