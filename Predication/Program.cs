using Predication.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto>p = new List<Produto>();
            p.Add(new Produto("tv", 900.00));
            p.Add(new Produto("Mouse", 50.00));
            p.Add(new Produto("Tablet", 350.00));
            p.Add(new Produto("HD Case", 80.90));
           
            p.RemoveAll(ProdutoTeste);
            p.RemoveAll(x=> x.Valor >=50 && x.Valor <80.90);
            
            foreach(Produto produto in p)
            {
                Console.WriteLine(produto);
            }
        }

        public static bool ProdutoTeste(Produto p)
        {
            return p.Valor >= 100;
        }
    }
}
