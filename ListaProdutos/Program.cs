using ListaProdutos.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaProdutos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Produto> produtos = new List<Produto>();

            Console.Write("Quantos produtos a cadastrar? ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine($"\nProduto {i}: \n");
                Console.WriteLine("Qual o tipo do Produto?");
                Console.Write("Comun - Usado - Importado  (c/u/i):");
                string tp = Console.ReadLine();

                Console.Write("Nome: ");
                string nomeP = Console.ReadLine();
                Console.Write("Valor: ");
                double valorP = double.Parse( Console.ReadLine(),CultureInfo.InvariantCulture);

                if (tp.ToLower() is "c" )
                {
                    produtos.Add(new Produto(nomeP, valorP));

                }else if (tp.ToLower() is "u")
                {
                    Console.Write("Data de frabricação: (DD/MM/YYYY) ");
                    string data = Console.ReadLine();
                    DateTime dataP  = DateTime.Parse(data);
                    produtos.Add(new ProdutoUsado(nomeP, valorP, dataP));
                }
                else
                {
                    Console.Write("Valor da Taxa: ");
                    double taxaP = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    produtos.Add(new ProdutoImportado(nomeP, valorP,taxaP));
                }
                
            }

            
                foreach (Produto produto in produtos)
            {
                if (produto is Produto)
                {

                    Console.WriteLine($@"{(produto as Produto).EtiquetaProduto()}");

                }
                else if (produto is ProdutoImportado)
                {
                    Console.WriteLine($@"{(produto as ProdutoImportado).EtiquetaProduto()} ");

                }
                else
                {
                    Console.WriteLine($"{(produto as ProdutoUsado).EtiquetaProduto()}  ");

                }
            }

        }
    }
}
