using Exercicio01.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Funcionario>funcionarios = new List<Funcionario>();

            Console.Write("Quantos funcionario? ");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine($"Funcionario {i}");
                Console.Write("O funcioario é Terceirizado? ");
                string resposta = Console.ReadLine();

                if (resposta.ToLower()is "s" )
                {
                    Console.Write("Nome: ");
                    string nomee = Console.ReadLine();
                    Console.Write("Horas Trabalhadas: ");
                    int qantHoras = int.Parse(Console.ReadLine());
                    Console.Write("Valor da Hora: ");
                    double valorH = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Valor da Hora Adicional: ");
                    double valorHAdd = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


                    funcionarios.Add(new FuncionarioTerceirizados(nomee,qantHoras,valorH,valorHAdd));

                }
                else
                {
                    Console.Write("Nome: ");
                    string nomee = Console.ReadLine();
                    Console.Write("Horas Trabalhadas: ");
                    int qantHoras = int.Parse(Console.ReadLine());
                    Console.Write("Valor da Hora: ");
                    double valorH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                   
                    funcionarios.Add(new Funcionario(nomee, qantHoras, valorH));

                }
            }


           foreach (Funcionario funcionario in funcionarios)
            {
                if (funcionario is FuncionarioTerceirizados)
                {
                    Console.WriteLine($"  {(funcionario as FuncionarioTerceirizados).Nome}");
                }
               
                Console.WriteLine($"  {funcionario}");
           }
        }
    }
}
