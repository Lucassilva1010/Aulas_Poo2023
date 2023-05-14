using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriterr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arquivoOriginal = @"C:\Users\pc3co\Pictures\teste1.txt";
            string arquivoDestino = @"C:\Users\pc3co\Pictures\teste2.txt";

            try
            {
                string[] linhas = File.ReadAllLines(arquivoOriginal);
                using (StreamWriter sw = File.AppendText(arquivoDestino))
                {
                    foreach (string line in linhas)
                    {
                        sw.WriteLine(line.ToUpper());
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
