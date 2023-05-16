using PrintServiceeT.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintServiceeT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // usando o generics
            PrintServiceT<string> service = new PrintServiceT<string>();
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


            var a = service.PrimeiroValor();
            var b = a + "+";
            Console.WriteLine($"O valor somado junto com o 1ª Numero digitado: {b}");
        }
    }
}
