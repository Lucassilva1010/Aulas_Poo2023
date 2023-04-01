using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SwitchEVar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite uma das opções para Iniciar o prograa!");
            Console.WriteLine("1 - Tela de boas vindas!");
            Console.WriteLine("2 - Tela de Soma!");
            Console.WriteLine("3 - Tela de Frase e Numero!");
            Console.WriteLine("4 - sair!");
            int  resultado = int.Parse(Console.ReadLine());
            var nome="";

            switch (resultado)
            {

                case 1:
                    Console.Write("Qual o seu nome? ");
                     nome = Console.ReadLine();

                    Console.WriteLine($"Seja bem vindo{nome}");

                    break;

                case 2:
                    Console.Write("Digite o 1 Numero da soma: ");
                    int numero1 = int.Parse(Console.ReadLine());
                    Console.Write("Digite o 1 Numero da soma: ");
                    int numero2 = int.Parse(Console.ReadLine());
                    int  result = numero1 + numero2;
                    Console.Write($"A SOMA entra os 2 numeros é: {result}");
                    break;

                case 3:
                    Console.Write("Qual a sua idade? ");
                    var idade = Console.ReadLine();

                    Console.Write($"Vovê digitou que tem {idade}, é isso mesmo {nome}");
                    break;

                default:

                    Console.WriteLine("Finalizado!");
                    break;
            }
           Console.WriteLine();

        }
    }
}
