using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write( "Qua o nome do titular da conta? ");
            string nome = Console.ReadLine();
            Console.Write("Qua o numero da conta? ");
            int numeroConta  =int.Parse(Console.ReadLine());

            Conta c = new Conta(nome, numeroConta);


            Console.Write("Você deseja realizar o seu priemeiro deposito? S/N ");
            string resp = Console.ReadLine();
            if (resp == "s"|| resp == "S")
            {
                Console.Write("Digite o valor do Deposito: ");
                double deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                c.Deposito(deposito);
                Console.Clear();
            }
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(c);

            Console.Write("Digite um valor para Deposito: ");
            double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            c.Deposito(valor);
            Console.WriteLine(c);

            Console.WriteLine(  );
            Console.WriteLine(  );
            Console.Write("Você deseja realizar algum Saque? S/N ");
            string respota = Console.ReadLine();
            if (respota=="S"|| respota=="s")
            {
                Console.Write("Qual vai ser o valor do Seu saque? ");
                double saque = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                c.Saque(saque);
                Console.WriteLine();
                Console.WriteLine(c);
            }

            Console.Clear();


            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
