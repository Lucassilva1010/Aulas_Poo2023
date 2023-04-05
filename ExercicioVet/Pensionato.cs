using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVet
{
    internal class Pensionato
    {
        public int Nome { get; set; }
        public Quarto[] Quartos { get; set; }

        public Pensionato()
        {
            
            Quartos = new Quarto[10];
            PrepararQuartos();
        }

        void PrepararQuartos()
        {
            for (int i = 0; i < Quartos.Length; i++)
            {
                Quartos[i] = new Quarto { 
                Numero = i+1,
                };

            }
        }


    }
}
