using ExtensaoDeMetodos.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensaoDeMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dTime = new DateTime(2023,05,16,11,45,20);
            Console.WriteLine(dTime.TempoDecorrido());

            string s1 = "Bom dia Estudantes!";
            Console.WriteLine(s1.Cut(8));
        }
    }
}
