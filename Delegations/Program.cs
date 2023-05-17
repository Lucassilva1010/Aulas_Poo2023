using Delegations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegations
{
    delegate double OperacaNumerosBinarios(double n1, double n2);
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            double c = 500;
            double d = 100;


            OperacaNumerosBinarios op = Demosntração01.Maior;
            OperacaNumerosBinarios op2 = Demosntração01.Soma;
            OperacaNumerosBinarios op3= Demosntração01.Multiplica;

            Console.WriteLine("Operação com os Delegates: ");
            Console.WriteLine("Maior numero: ");
            double result01 = op(c, d);
            Console.WriteLine(result01);

            Console.WriteLine("Soma: ");
            double result02 = op2(c, d);
            Console.WriteLine(result01);

            Console.WriteLine("Valor do Quadrado: ");
            double result03 = op3(c);
            Console.WriteLine(result03);

            //Sem o Delegates
            double result = Demosntração01.Maior(a, b);
            Console.WriteLine(result);
            double result2 = Demosntração01.Soma(a, b);
            Console.WriteLine(result2);
            double result3 = Demosntração01.Multiplica(a);
            Console.WriteLine(result3);
        }
    }
}
