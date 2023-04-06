using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Entities
{
    internal class Departamento
    {
        public string Nome { get; set; }
        public Departamento()
        {
            
        }
        public Departamento(string nome):this() 
        {
            Nome = nome;
        }
    }
}
