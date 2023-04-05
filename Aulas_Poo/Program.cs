 using System;
using System.Globalization;
using System.Net.NetworkInformation;
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

            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Produto p = new Produto();
            
            ProdutoEncapsulado produto2 = new ProdutoEncapsulado("lucas",200.00);
            ProdutoEncapsulado produto3 = new ProdutoEncapsulado();

            ProdutoEncapsuladoAutoPro produtoAuto = new ProdutoEncapsuladoAutoPro("Antonella",200.00);

           
            ProdutoEncapsuladoProperties produtoP = new ProdutoEncapsuladoProperties {
              
            Nome = Console.ReadLine()
            
            };

            //ProdutoEncapsuladoAutoPro produtoAuto = new ProdutoEncapsuladoAutoPro
            //{
              
            //Nome = Console.ReadLine()
            
            //};

            Console.WriteLine( produtoAuto.Nome );







            /*Console.WriteLine(  produto2.GetNome());
        
            Console.WriteLine("Qual  o nome do prduto?");
            string nomee = Console.ReadLine();
            produto.SetNome(nomee);
            Console.WriteLine(produto.GetNome());8?



            /* ProdutoEncapsulado p3 = new ProdutoEncapsulado();
             // cadastro de produtos Com Construtores da classe produto2
             System.Console.Write("Qual o nome do produto que deseja cadastrar: ");
             p3.Nome = Console.ReadLine();
             Console.Write("Qual o valor do Produto: ");
             p3.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             Console.Write("Quantos Produto a ser vadastrados: ");
             p3.Quantidade = int.Parse(Console.ReadLine());*/

            // cadastro de produtos Com Construtores da classe produto2
            /* System.Console.Write("Qual o nome do produto que deseja cadastrar: ");
             string nome = Console.ReadLine();
             Console.Write("Qual o valor do Produto: ");
             double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);*/



            // ProdutoEncapsulado p3 = new ProdutoEncapsulado(nome,preco);
            //Produto3 p3 = new Produto3(nome, preco);
            // Produto2 p3 = new Produto2(nome,preco);
            // Produto2 p2 = new Produto2 { Nome = nome,
            // Preco = preco,
            // Quantidade=30
            // };

            /*Console.WriteLine("\t--------");

            //Atualização de Estoque
            Console.Write("Quantidade em Estoque: " + p3.Quantidade + "\n");
            Console.WriteLine();
            Console.WriteLine("\t---Resumo do Estoque-----");
            Console.WriteLine("Dados do Atualizados: " + p3);
            Console.WriteLine("---------------------------");

            //Movimentação de Estoque
            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser Adicionado: ");
            int quantidade = int.Parse(Console.ReadLine());
            p3.AdicionarProduto(quantidade);
            Console.WriteLine();

            Console.WriteLine("\t---Resumo do Estoque-----");
            Console.WriteLine("Dados do Atualizados: " + p3);
            Console.WriteLine("---------------------------");

            Console.Write("Digite o numero de produtos a ser Removidos: ");
            quantidade = int.Parse(Console.ReadLine());
            p3.RemoverProdutos(quantidade);

            Console.WriteLine();
            Console.WriteLine("\t---Resumo do Estoque-----");
            Console.WriteLine("Dados do Atualizados: " + p3);
            Console.WriteLine("---------------------------");

            Console.ReadLine();*/







            /*

            // cadastro de produtos sem construtores
            System.Console.Write("Qual o nome do produto que deseja cadastrar: ");
            p.Nome = Console.ReadLine();
            Console.Write("Qual o valor do Produto: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write($"Quantos {p.Nome} vão ser cadastrados: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("\t--------");

            //Atualização de Estoque
            Console.Write("Quantidade em Estoque: " + p.Quantidade + "\n");
            Console.WriteLine();
            Console.WriteLine("\t---Resumo do Estoque-----");
            Console.WriteLine("Dados do Atualizados: " + p);
            Console.WriteLine("---------------------------");

            //Movimentação de Estoque
            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser Adicionado: ");
            int quantidade = int.Parse(Console.ReadLine());
            p.AdicionarProduto(quantidade);
            Console.WriteLine();
            
            Console.WriteLine("\t---Resumo do Estoque-----");
            Console.WriteLine("Dados do Atualizados: " + p);
            Console.WriteLine("---------------------------");

            Console.Write("Digite o numero de produtos a ser Removidos: ");
            quantidade = int.Parse(Console.ReadLine());
            p.Removerprodutos(quantidade);

            Console.WriteLine();
            Console.WriteLine("\t---Resumo do Estoque-----");
            Console.WriteLine("Dados do Atualizados: " + p);
            Console.WriteLine("---------------------------");

            Console.ReadLine();*/



            //Comparação salario entre 2 funcionarios
            /* Console.WriteLine("Qual o nome do funcionario 01? ");
             funcionario1.nome = Console.ReadLine();
             Console.WriteLine("Qual o valor salarial do 2ª funcionario? ");
             funcionario1.salrio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

             Console.WriteLine("Qual o nome do funcionario 02? ");
             funcionario2.nome = Console.ReadLine();
             Console.WriteLine("Qual o valor salarial do 2ª funcionario? ");
             funcionario2.salrio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

             double media = (funcionario1.salrio + funcionario2.salrio) / 2;

             if (funcionario1.salrio>funcionario2.salrio)
             {
                 Console.WriteLine($"{funcionario1.nome}, Tem o maior salario.");
             }
             else
             {
                 Console.WriteLine($"{funcionario2.nome}, Tem o maior Salario.");
             }

             Console.WriteLine($"A media salarial entre os 2 funcionarios são: {media.ToString("f3",CultureInfo.InvariantCulture)}");
            */






            //Programa que compara e verifica a pessoa mais velha
            /*Console.WriteLine("Qual o seu nome? ");
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
            }*/



            //Dados para calcular um Triangulo
            /*Console.WriteLine("Entre com as medidas do triagulo X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triagulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double areaX = x.Area();
            double areaY = y.Area();
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
