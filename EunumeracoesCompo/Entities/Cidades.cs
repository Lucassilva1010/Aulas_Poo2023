using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EunumeracoesCompo.Entities.Enums
{
    public class Cidades
    {
        public string Nome { get; set; }
        public string Regiao { get; set; }
        public Estados Estado { get; set; }

        

        public void ListaEstados()
        {
            for (int i = 0; i <4; i++)
            {
                 Console.WriteLine("Nova forma ->"+Estado);
                Estado++;
               
            }

        }

        public override string ToString()
        {
            return "O nome da Cidade Cadastrada é: " + Nome
                + " Ela é da região: " + Regiao
                + " E tem a sigla represetante do seu estado é: "+ Estado;
        }
    }
}
