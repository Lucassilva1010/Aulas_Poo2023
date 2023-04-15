using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEnun2.Entities
{
    internal class Comentario
    {
        public string  Texto { get; set; }

        public Comentario()
        {
            
        }
        public Comentario( string texto)
        {
            Texto = texto;
        }
    }
}
