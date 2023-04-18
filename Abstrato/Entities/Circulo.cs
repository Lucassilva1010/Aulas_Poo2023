using Abstrato.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrato.Entities
{
    internal class Circulo:Figura
    {
        public double Raio { get; set; }

      
        public Circulo(Cor cor, double raio): base(cor)
        {
            Raio = raio;
        }
        public override double Area()
        {
            return Math.PI *Raio*Raio;
        }
    }
}
