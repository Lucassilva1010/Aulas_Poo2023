using ExercicioPedidos.Entities;
using ExercicioPedidos.Enums;
using System;
using System.Globalization;
using System.Security.Cryptography;

namespace ExercicioPedidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente();
            Console.Write("Nome: ");
            c1.Nome = Console.ReadLine();
            Console.Write("Email: ");
            c1.Email = Console.ReadLine();
            Console.Write("Data de Nascimento - (Dia/Mê/Ano): ");
            c1.DataNascimento = DateTime.Parse(Console.ReadLine());

            Pedido pedido = new Pedido();
            Console.Write("Defina o Status do pedido: ");
            pedido.StatusPedido = (StatusPedido)Enum.Parse(typeof(StatusPedido), Console.ReadLine(),true);
            pedido.Cliente = c1;
            Console.Write("Quantos Itens possui nessa Pedido? ");
            var num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Nome do Produto: ");
                var nome = Console.ReadLine();
                Console.WriteLine("Preço do Produto: ");
                var preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.WriteLine("Quantidade: ");
                var quant = int.Parse(Console.ReadLine());
                var item = new ItemDoPedido(quant, preco, new Produto(nome, preco));
                pedido.AdicionaItem(item);
                    }
            Console.WriteLine("Resumo Do pedido!");
            Console.WriteLine(pedido);




        }
    }
}
