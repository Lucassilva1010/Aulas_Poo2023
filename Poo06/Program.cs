using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Poo06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(  "Quantas vezes deseja rodar o programa? ");
            int n = int.Parse( Console.ReadLine() );
            Vetor2[] vet = new Vetor2[n];

            //cadastrando produtos com 2 Atributos
            for (int i = 0; i < n; i++)
            {
                Console.Write("Produto: ");
                string nome = Console.ReadLine();
                Console.Write("Valor do Produto: ");
                double valor = double.Parse( Console.ReadLine(),CultureInfo.InvariantCulture );

                vet[i] = new Vetor2 {Nome= nome, Preco=valor };

            }

            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                soma += vet[i].Preco;
            }
                soma = soma/n;
            Console.Write(  " A Média dos produtos é: "+soma);
            Console.WriteLine(  );




            //praticando Vetores
            /*Console.WriteLine("Quantos numero você quer cadastrar? ");
            int n = int.Parse(Console.ReadLine());
            double[] altura = new double[n];

            double resultado = 0.0;
        
                for (int i = 0; i < n; i++)
                {

                    Console.WriteLine("Digite o numero: " + i);
                    altura[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                }

            for (int i = 0; i < n; i++)
            {
                resultado += altura[i];
            }
            Console.WriteLine("O resultado da soma é: " + resultado.ToString("f2",CultureInfo.InvariantCulture));
            resultado = resultado / n;

            Console.WriteLine("A media é: " + resultado.ToString("f2", CultureInfo.InvariantCulture));*/






        }
    }
}
