using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ExercicioLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dados> dado = new List<Dados>();
            Dados dados1 = new Dados();

            Console.WriteLine("Quantos funcionarios: ");
            int numeroFun = int.Parse(Console.ReadLine());

            string nome="";
            double sal=0;

            for (int i=0; i<numeroFun;i++)
            {
                Console.WriteLine("Digite os dados do "+i+" Funcionario: ");
               
                Console.Write("Nome: ");
                 nome =Console.ReadLine();
                Console.Write("valor do Salario: ");
                 sal = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                dado.Add(new Dados() { Nome = nome, Salario = sal });
               
            }
            Console.Clear();

            Console.WriteLine("Lista de Funcionarios cadastrados ");
            foreach (Dados dados in dado)
            {
                Console.WriteLine(dados);
            }

             Console.WriteLine();
            Console.WriteLine();
            dados1.Aumento(sal,nome);
        }
    }
}
