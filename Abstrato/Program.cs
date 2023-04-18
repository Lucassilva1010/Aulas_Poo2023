using Abstrato.Entities;
using Abstrato.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Abstrato
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Figura> figuras = new List<Figura>();
            Console.Write("Entre com o numero de Figuras: ");
            int numerF = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numerF; i++)
            {
                Console.WriteLine($"Figura #{i}\n");
                Console.WriteLine("Retangulo ou Circulo (r/c)? ");
                string tipoFigura = Console.ReadLine();

                Console.WriteLine("Cor (Preto/Azul/Vermelho)");
                Cor cor = (Cor)Enum.Parse(typeof(Cor), Console.ReadLine(), true);
                               

                if (tipoFigura.ToLower() is "r")
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    figuras.Add(new Retangulo(cor,largura, altura));

                }
                else
                {
                    Console.WriteLine("Valor do Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    figuras.Add(new Circulo(cor,raio));
                }
            }
            
            Console.WriteLine();
            foreach (Figura fig in figuras)
            {

                Console.WriteLine(fig.Area().ToString("f2", CultureInfo.InvariantCulture));
            }
        }
    }
}
