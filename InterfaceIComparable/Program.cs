using InterfaceIComparable.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceIComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string arquivo = @"C:\Users\pc3co\Pictures\Suporte\nomes.txt";
            try
            {
                using (StreamReader sr = File.OpenText(arquivo))
                {

                    //List<string> list = new List<string>();
                    List<Funcionario> list = new List<Funcionario>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Funcionario(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Funcionario fun in list)
                    {
                        Console.WriteLine(fun);
                    }
                }
            }
            catch (IOException e)
            {

                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
