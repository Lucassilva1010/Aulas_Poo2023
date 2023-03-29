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
            Pensionato[] pen = new Pensionato[10];

            Console.Write( "Quantos quartos serão alugados? ");
            int n = int.Parse( Console.ReadLine() );

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Alugel "+i+" ");
                Console.Write("Qual o seu nome? ");
                string nome = Console.ReadLine();
                Console.Write("Qual o sue email? ");
                string email = Console.ReadLine();

                Console.WriteLine("Qual quarto deseja contratar? ");
                int quarto = int.Parse(Console.ReadLine());
                pen[quarto] = new Pensionato(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos Ocupados");
            for (int i = 0;i < 10;i++)
            {
                if (pen[i] !=null)
                {
                    Console.WriteLine(i + " - " + pen[i] );
                }

            }
            
        }
    }
}
