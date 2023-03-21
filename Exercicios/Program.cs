using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Retangulo dados = new Retangulo();

            Console.Write("Digite a Largura: ");
            dados.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a Altura: ");
            dados.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            dados.Area();
            dados.Perimetro();
            dados.Diagonal();

            Console.WriteLine(dados);
        }
    }
}
