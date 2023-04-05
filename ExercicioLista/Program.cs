using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ExercicioLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int numeroEscolhido = new Random().Next(1,4);
            List<Dados> dados = new List<Dados>();


            Console.WriteLine("Quantos funcionarios: ");
            int numeroFun = int.Parse(Console.ReadLine());


            for (int i = 0; i < numeroFun; i++)
            {

                Console.WriteLine("Digite os dados do " + i + " Funcionario: ");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("valor do Salario: ");
                double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                dados.Add(new Dados() { Nome = nome, Salario = sal });

            }
            Console.Clear();
            var grupos = dados.GroupBy(dado => dado.ID);


            Console.WriteLine("Lista de Funcionarios cadastrados ");
            foreach (var grupo in grupos)
            {
                if (grupo.Count() > 1)
                {

                    foreach (var dado in grupo)
                    {
                        dado.Aumento(dado.Salario, dado.Nome);
                        Console.WriteLine(dado);
                    }
                }else
                {

                    foreach (var dado in grupo)
                    { 
                        Console.WriteLine($"{dado.Nome} Não possui aumento: ");
                    }
                }


            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
