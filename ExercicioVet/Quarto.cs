using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVet
{
    internal class Quarto
    {
        public string Descricao { get; set; }
        public string Andar { get; set; }
        public bool Ocupacao { get; set; }
        public int  Numero { get; set; }
        public Usuario  Usuario { get; set; }

    }
}
