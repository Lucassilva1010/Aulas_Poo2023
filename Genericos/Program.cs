using Genericos.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
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
           
           for (int i = 0; i < numero; i++) {
                Console.Write($"Digite o {i} valor:");
                int valor = int.Parse(Console.ReadLine());
                service.AdicionaValor(valor);

            }
            service.Imprimir();
            Console.WriteLine();
            Console.WriteLine($"Primeiro valor digitado: {service.PrimeiroValor()}");

        }
    }
}
