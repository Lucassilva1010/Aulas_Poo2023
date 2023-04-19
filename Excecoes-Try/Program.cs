using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecoes_Try
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Programa para tratar Exceções ");

                Console.Write("Digite um valor Inteiro:");
                int v1 = int.Parse(Console.ReadLine());
                Console.Write("Digite outro valor Inteiro:");
                int v2 = int.Parse(Console.ReadLine());

                double resultado = v1 / v2;

                Console.WriteLine();
                Console.WriteLine(resultado);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("ERRO!!!! ");
                Console.WriteLine("Você quer dividir por 0 e não pode cara");
            }
            catch (FormatException )
            {
                Console.WriteLine("\nErroooo!!");
                Console.WriteLine("Verifique se o tipo de dado digitado está correto!");
            }
        }
    }
}
