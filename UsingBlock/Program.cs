using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingBlock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patch =  @"C:\Users\pc3co\Pictures\teste1.txt";
            try
            {
               
                    using (StreamReader sr = File.OpenText(patch))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
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
