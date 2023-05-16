using ExercicioSET.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<RegistroDeLog> set = new HashSet<RegistroDeLog>();
            Console.WriteLine("Entre com o caminho do arquivo: ");
            string arquivo = Console.ReadLine();
            Console.WriteLine();

            try
            {
                using (StreamReader sr = File.OpenText(arquivo))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string nome = line[0];
                        DateTime instante = DateTime.Parse(line[1]);

                        set.Add(new RegistroDeLog { Usuario = nome, Instante = instante });
                      
                    }

                    Console.WriteLine($"Total de usuarios: {set.Count}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
