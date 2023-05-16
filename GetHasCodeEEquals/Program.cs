using GetHasCodeEEquals.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHasCodeEEquals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente a = new Cliente();
            Cliente b = new Cliente();
            a.Nome = "Lucas";
            a.Cpf = 123;

            b.Nome = "Antonella";
            b.Cpf = 123;
            
            Console.WriteLine($"{a.Equals(b)} - Comparado em tempo de execução a partir de um objeto");
            Console.WriteLine($"{a==b} - Compara o conteudo em memoria");
            Console.WriteLine($"{a.GetHashCode()} - Numero do GetHashCode");
            Console.WriteLine($"{b.GetHashCode()} - Numero do GetHashCode");



        }
    }
}
