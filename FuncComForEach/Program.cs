using ActionEForEach.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncComSelect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> p = new List<Produto>();
            p.Add(new Produto("tv", 900.00));
            p.Add(new Produto("Mouse", 50.00));
            p.Add(new Produto("Tablet", 350.00));
            p.Add(new Produto("HD Case", 80.90));

            Console.WriteLine("Adicionando novos produtos usando o FUNC");

           

            //Primeira forma
            List<string> list = p.Select(AlteraNome).ToList();
            //segunda forma com um Delegates
            Func<Produto, string> func = AlteraNome;
            List<string> list1 = p.Select(func).ToList();
        
            foreach (string item in list1)
            {
                Console.WriteLine(item);
            }
            // Terceira forma com Expressão 
            Console.WriteLine();
          

            Console.WriteLine("Com a expressão Lambda");

            Func<Produto, string> func2 = x => x.Nome.ToUpper();

            List<string> list3 = p.Select(func2).ToList();

            foreach (string item in list3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Com a expressão Lambda InLine");

            

            List<string> list4 = p.Select(x => x.Nome.ToUpper()).ToList();

            foreach (string item in list4)
            {
                Console.WriteLine(item);
            }

        }

        static string AlteraNome(Produto p)
        {
            return p.Nome.ToUpper();
        }
    }
}
