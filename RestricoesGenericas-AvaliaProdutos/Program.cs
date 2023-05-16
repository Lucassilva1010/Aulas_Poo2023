using RestricoesGenericas_AvaliaProdutos.Entities;
using RestricoesGenericas_AvaliaProdutos.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestricoesGenericas_AvaliaProdutos
{
    internal class Program
    {
        static void Main(string[] args)
        {

           // List<int> list = new List<int>();
            List<Produto> listP = new List<Produto>();

            Console.WriteLine("Esse programa só trabalha com até no maximo 10 numeros.");
            Console.WriteLine();
            Console.Write("Quantos numeros?");
            int numero = int.Parse(Console.ReadLine());



            for (int i = 0; i < numero; i++)
            {
                Console.Write($"Digite os dados do {i} produto (nome, valor): ");
                string[] vet = Console.ReadLine().Split(',');
                Console.Write("");
                string nome = vet[0];
               
                double preco = double.Parse(vet[1],CultureInfo.InvariantCulture);
                listP.Add(new Produto(nome,preco  ));
                
            }
           

            //for (int i = 0; i < numero; i++)
            //{
            //    Console.Write($"Digite o {i} valor:");
            //    int valor = int.Parse(Console.ReadLine());
            //    list.Add(valor);

            //}
            CalculaServico calculaServico = new CalculaServico();
            //int max = calculaServico.MaiorValor(list);

            Produto maxx = calculaServico.MaiorValor(listP);

            Console.WriteLine();
            Console.WriteLine($"Maior Valor: {maxx}");


            ;
        }
    }
}
