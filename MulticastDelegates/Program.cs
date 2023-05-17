using MulticastDelegates.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegates
{
    delegate void OperacaoDeNumeroBinario(double n1, double n2);
    internal class Program
    {
        static void Main(string[] args)
        {

            double num1 = 15;
            double num2 = 25;
            OperacaoDeNumeroBinario a = CalculaServicos.Maior;
            a += CalculaServicos.Soma;
            a.Invoke(num1, num2);
            a(num1, num2);
            Console.WriteLine(a); 
        }
    }
}
