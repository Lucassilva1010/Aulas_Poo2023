using ImpostoContribuintes.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoContribuintes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Pessoa> pessoas = new List<Pessoa>();

            Console.Write("Quantas pessoas? ");
            int numeroPessoa = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numeroPessoa; i++)
            {
                Console.WriteLine($"Pessoa {i}");

                Console.Write("Você é pessoa Fisica(F) ou Pessoa Juridica(J) ");
                string tipoP = Console.ReadLine();

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Valor Renda: ");
                double valorRenda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                if (tipoP.ToLower() is "f")
                {
                    Console.Write("Gastos com Saude: ");
                    double gastoComSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    pessoas.Add(new PFisica(nome, valorRenda, gastoComSaude));

                }
                else
                {
                    Console.Write("Funcionarios: ");
                    int nFuncionario = int.Parse(Console.ReadLine());
                    pessoas.Add(new Pjuridica(nome, valorRenda, nFuncionario));

                }
            }
            Console.WriteLine();
            Console.WriteLine("IMPOSTOS de PAGOS");
            Console.WriteLine();

            foreach (Pessoa pessoa in pessoas)
            {
                if (pessoa is PFisica)
                {

                    Console.WriteLine($" {(pessoa as PFisica).Nome}: " +
                        $@" ${(pessoa as PFisica).CalculaImposto().ToString("f2", CultureInfo.InvariantCulture)}");
                }
                else if (pessoa is Pjuridica)
                {
                    Console.WriteLine($" {(pessoa as Pjuridica).Nome}:  " +
                        $@" ${(pessoa as Pjuridica).CalculaImposto()}");
                }
                Console.WriteLine();
            }

            foreach (Pessoa p in pessoas)
            {
                Console.WriteLine();
                Console.WriteLine($"Total de Impostos: ${(p as PFisica).CalculaImposto() + (p as Pjuridica).CalculaImposto()}");
            }
        }
    }
}
