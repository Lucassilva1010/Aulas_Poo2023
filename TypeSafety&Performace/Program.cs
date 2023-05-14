using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeSafety_Performace.Service;

namespace TypeSafety_Performace
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PrintService service = new PrintService();
            Console.WriteLine("Esse programa só trabalha com até no maximo 10 numeros.");
            Console.WriteLine();
            Console.Write("Quantos numeros?");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero; i++)
            {
                Console.Write($"Digite o {i} valor:");
                string valor = Console.ReadLine();
                service.AdicionaValor(valor);

            }
            service.Imprimir();
            Console.WriteLine();
            Console.WriteLine($"Primeiro valor digitado: {service.PrimeiroValor()}");


            int a = (int)service.PrimeiroValor();
            int b = a + 10;
            Console.Write($"O valor somado junto com o 1ª Numero digitado: {b}");
        }
    }
}
