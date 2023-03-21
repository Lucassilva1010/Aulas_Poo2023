using System;
using System.Globalization;
using System.Security.Principal;

namespace Aulas_Poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triagulo x = new Triagulo();
            Triagulo y = new Triagulo();

            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Qual o seu nome? ");
            pessoa1.nome =Console.ReadLine();
            Console.WriteLine("Qual a sua Idade? ");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o seu nome? ");
            pessoa2.nome = Console.ReadLine();
            Console.WriteLine("Qual a sua Idade? ");
            pessoa2.idade = int.Parse(Console.ReadLine());


            if (pessoa1.idade>pessoa2.idade)
            {
                Console.WriteLine($"{pessoa1.nome}, é Pessoa mais vehla!");
            }
            else
            {
                Console.WriteLine($"{pessoa2.nome}, é a Pessoa masi velha!");
            }



            //Dados para calcular um Triangulo
           /* Console.WriteLine("Entre com as medidas do triagulo X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triagulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine($"Area de X: {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area de y: {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areaX > areaY)
            {
                Console.WriteLine($"A marior area é X, com o valor: {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine($"A marior area é Y, com o valor: {areaY.ToString("F4", CultureInfo.InvariantCulture)}");
            }*/
        }
    }
}
