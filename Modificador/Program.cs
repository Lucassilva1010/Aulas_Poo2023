using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Modificador
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            //TesteModificador t = new TesteModificador(10,20);

            Listas listas = new Listas();


            int numero = 3;
            for (int i = 0; i < numero; i++)
            {
                Console.Write("Digite o nome a pra add na lista: ");
                string nome = Console.ReadLine();
                
                listas.AdiconaInsert(i,nome);

                Console.Write("Digite o nome a pra add na lista: ");
                nome = Console.ReadLine();
                listas.AdicinaLista(nome);

            }
            Console.WriteLine("Os nomes cadastrados foram: ");
            listas.MostrarLista();

            
            

           /* string[] vectt = new string[]{"Lucas", "Antonella", "Anastacia" };

            foreach (string item in vectt)
            { 
                Console.WriteLine(item);
                
            }
            Console.WriteLine();*/
            /*
            int tt4 = TesteModificador.TesteModificado(20,30);

            double t = TesteModificador.Modd(3,2,3);
            double t2 = TesteModificador.Modd2(new int[] { 10, 20 ,100});
            int t3 = TesteModificador.Modd3(10,60,10,300);
           

            Console.WriteLine("O restultado é: "+ tt4);
            Console.WriteLine("O restultado é: "+ t);
            Console.WriteLine("O restultado é: "+ t2);
            Console.WriteLine("O resultado é: " + t3);*/
        }


        
    }
}
