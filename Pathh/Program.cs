using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathh
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string pasta = @"C:\Users\pc3co\Pictures\TesteDirectory\Fotos\eu.txt";
            Console.WriteLine($@"DirectorySeparatorChar:{Path.DirectorySeparatorChar}");
            Console.WriteLine($@"PathSeparator:"+Path.PathSeparator);
            Console.WriteLine($@"GetDirectoryName:{ Path.GetDirectoryName(pasta)}");
            
        }
    }
}
