using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Arquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminhoEntrada = @"C:\Users\pc3co\Pictures\teste1.txt";
            string caminhoSaida = @"C:\Users\pc3co\Pictures\teste2.txt";
            
            
            string fotoEntrada = @"C:\Users\pc3co\Pictures\eu .jpg";
            string fotoSaida = @"C:\Users\pc3co\Pictures\eu2 .jpg";
             

            try
            {
                FileInfo fileInfo = new FileInfo(caminhoEntrada);
                fileInfo.CopyTo(caminhoSaida);

                string[] linhas = File.ReadAllLines(caminhoEntrada);

                foreach (string l in linhas)
                {
                    Console.WriteLine(l);
                }

                FileInfo arquivo = new FileInfo(fotoEntrada);
                arquivo.CopyTo(fotoSaida);


            }catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
