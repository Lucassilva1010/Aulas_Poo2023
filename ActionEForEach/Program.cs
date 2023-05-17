using ActionEForEach.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionEForEach
{
    internal class Program
    {
        delegate void Acao<in t1, in t2>(t1 args1, t2 args2);
        static void Main(string[] args)
        {

            List<Produto> p = new List<Produto>();
            p.Add(new Produto("tv", 900.00));
            p.Add(new Produto("Mouse", 50.00));
            p.Add(new Produto("Tablet", 350.00));
            p.Add(new Produto("HD Case", 80.90));

            Console.WriteLine("Com a Lambada em Funcção: 10%");
            Action<Produto> pro = (x => { x.Valor += x.Valor * 0.1; });//aumenta 10% no valor do produto

            p.ForEach(pro);
            foreach (Produto item in p)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("Aumento por Delegates: 20%");
            p.ForEach(Aumento);
            foreach (Produto produc in p)
            {
                Console.WriteLine(produc);
            }
            Console.WriteLine();

            
           
            Console.WriteLine("Aumento por o ForEach: 20%");
            p.ForEach(Aumento);

            foreach (Produto produto in p)
            {
                Console.WriteLine(produto);
            }
        }

        public static void Aumento(Produto p)
        {
            p.Valor += p.Valor * 0.2;
        }
    }
}
