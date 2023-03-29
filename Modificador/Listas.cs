using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Modificador
{
    public class Listas
    {
        List<string> nome = new List<string>();


        public void AdicinaLista(string nome)
        {
           this.nome.Add(nome);
           
        }
        public void AdiconaInsert(int n, string nome )
        {
            this.nome.Insert(n,nome);
           
        }

        public void MostrarLista()
        {
            foreach (var item in nome)
            {
                Console.WriteLine(item.ToUpper());
            }
            Console.WriteLine(nome.Count);

            string nome1 = nome.Find(x=> x[0] =='A');
            Console.Write( "A primeira pessoa com a letra A é: " + nome1);


        }

    }
}
