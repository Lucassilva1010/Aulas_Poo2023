using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Conta
    {
        public string Nome { get; private set; }
        public int NumeroConta { get; set; }
        public double Saldo { get; set; }

        public Conta(string nome, int numeroConta)
        {
            Nome = nome;
            NumeroConta = numeroConta;
        }

        public Conta()
        {
            Saldo = 0.0;
        }

        public void Deposito(double saldo)
        {
            Saldo += saldo;
        }
    }
}
