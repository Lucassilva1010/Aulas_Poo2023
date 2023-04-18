using Abstrato.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrato.Entities
{
    internal class Retangulo:Figura 
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

       

        public Retangulo(Cor cor, double altura, double largura): base(cor)
        {
            Altura = altura;
            Largura = largura;
        }

        public override double Area()
        {
           return Largura*Altura;
        }
    }
}
