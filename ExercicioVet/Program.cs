using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pensionato pensionato = new Pensionato();



            Console.WriteLine($"Quartos disponiveis: ");

            foreach (var quarto in pensionato.Quartos)
            {
                Console.WriteLine("Número: " + quarto.Numero);
            }


            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

           
            for (int i = 0; i < n; i++)
            {
                int quarto = 0;
                do
                {

                    Console.WriteLine();
                    Console.WriteLine("Alugel " + i + " ");
                    Console.Write("Qual o seu nome? ");
                    string nome = Console.ReadLine();
                    Console.Write("Qual o sue email? ");
                    string email = Console.ReadLine();

                    Console.WriteLine("Qual quarto deseja contratar? ");
                     quarto = int.Parse(Console.ReadLine());
                    
                    if (pensionato.Quartos[quarto - 1].Usuario == null)
                    {
                        pensionato.Quartos[quarto-1].Usuario = new Usuario(nome, email);
                        pensionato.Quartos[quarto-1].Ocupacao = true;

                    }
                    else
                    {
                        Console.WriteLine("Quarto já Ocupado!\n Escolha um novo quarto!");

                        Console.WriteLine($"Quartos disponiveis: ");

                        foreach (var quartoLista in pensionato.Quartos.Where(q => q.Ocupacao == false))
                        {
                            Console.WriteLine("Número: " + quartoLista.Numero);
                        }
                        quarto = 0;


                    }
                } while (quarto==0);

                

            }

            Console.WriteLine();
            Console.WriteLine("Quartos Ocupados");

           
            for (int i = 0; i < pensionato.Quartos.Length; i++)
            {
                if (pensionato.Quartos[i].Ocupacao  == true)
                {
                    Console.WriteLine( pensionato.Quartos[i].Numero);
                }

               

            }

        }
    }
}
