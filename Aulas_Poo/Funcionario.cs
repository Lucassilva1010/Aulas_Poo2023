using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_Poo
{
    internal class Funcionario
    {
        public string nome;
        public double salrio { get; private set; }

        public Funcionario()
        {
            salrio = 0.0;
        }


    }
}
