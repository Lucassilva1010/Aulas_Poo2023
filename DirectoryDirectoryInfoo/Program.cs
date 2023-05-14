using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryDirectoryInfoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pasta = @"C:\Users\pc3co\Pictures\TesteDirectory";


            try
            {
                //Cria coleção de Pastas 
                IEnumerable<string> arquivos =  Directory.EnumerateDirectories(pasta,"*.*",SearchOption.AllDirectories);

                //Listando todas as pastas de um mesmo diretorio
                Console.WriteLine("Aruvos:");
                foreach (string s in arquivos)
                {
                    Console.WriteLine(s);
                }
                    //Lista todos os arquivos das pastas e inclusive das subPastas
                IEnumerable<string> arquivos2 = Directory.EnumerateFiles(pasta, "*.*", SearchOption.AllDirectories);

                //Listando todas as pastas de um mesmo diretorio
                Console.WriteLine("Aruvos:");
                foreach (string ss in arquivos2)
                {
                    Console.WriteLine(ss);
                }
                //criando pastas
                Directory.CreateDirectory(pasta+@"\stream");
                Directory.CreateDirectory(@"C:\Users\pc3co\Pictures\TesteDirectory\Videos");
                Directory.CreateDirectory($@"{pasta}\Downloads");



            }
            catch (IOException e)
            {

                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(e.Message);
            }

        }
    }
}
