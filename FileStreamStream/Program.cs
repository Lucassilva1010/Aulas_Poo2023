using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arquivo = @"C:\Users\pc3co\Pictures\teste1.txt";
            string arquivo2 = @"C:\Users\pc3co\Pictures\teste2.txt";

            FileStream fs = null;
            StreamReader sr = null;

            StreamReader teste = null;


            try
            {
                fs = new FileStream(arquivo, FileMode.Open);
                sr = new StreamReader(fs);

                teste = File.OpenText(arquivo2);//Instancia explicita, mais de uma classe sendo utlizada

                while (!sr.EndOfStream)
                {
                  

                    string ler = sr.ReadLine();
                    string ler2 = teste.ReadLine();


                    Console.WriteLine(ler);
                    Console.WriteLine(ler2);
                }
               


            }
            catch (IOException e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                if(fs!=null) fs.Close();
                if(sr!=null) sr.Close();
            }
        }
    }
}
