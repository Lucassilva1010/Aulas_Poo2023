using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasSetESortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("Lucas");
            set.Add("Maria");
            set.Add("Antonella");
            set.Add("Marina");
            Console.WriteLine(set.Contains("Antonella"));
            Console.WriteLine();
            Console.WriteLine("Essa é uma coleção de conjutos do HasSet");
            foreach (string item in set)
            {

                Console.WriteLine(item);

            }

            Console.WriteLine();
            Console.WriteLine("Essa é uma coleção de conjuntos do SortedSet");
            Console.WriteLine();
            SortedSet<int> numeros = new SortedSet<int>();
            SortedSet<int> numeros2 = new SortedSet<int>() { 10, 20, 40, 50, 100 };
            SortedSet<int> n = new SortedSet<int>() { 30, 40, 50, 60, 70, 80, 90, 100 };
            numeros.Add(10);
            numeros.Add(20);
            numeros.Add(30);

            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            ImprimindoColecoes(numeros2);


            Console.WriteLine();
            Console.WriteLine("unindo conjuntos: ");
            Console.WriteLine();
            SortedSet<int> novo = new SortedSet<int>(numeros2);
            novo.UnionWith(n);
            novo.Union(n);
            ImprimindoColecoes(novo);
            Console.WriteLine();
            ImprimindoColecoes(novo);

            Console.WriteLine();
            Console.WriteLine("Intersecção deconjuntos: ");
            Console.WriteLine();
            SortedSet<int> inter = new SortedSet<int>(numeros2);
            inter.IntersectWith(n);
            Console.WriteLine();
            ImprimindoColecoes(numeros2);
            ImprimindoColecoes(inter);

        }
        static void ImprimindoColecoes<T>(IEnumerable<T> colecao)
        {
            foreach (T obj in colecao)
            {
                Console.Write(obj + " - ");
            }
        }
    }
}
