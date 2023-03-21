using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
           return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura+Altura)*2 ;
        }

        public double Diagonal()
        {
            return Math.Sqrt((Largura*2)+(Largura*2)) ;
        }

        public override string ToString()
        {
            return "A area é: "+Area().ToString("f2",CultureInfo.InvariantCulture)+"\n"
                +"O perimetro é: "+Perimetro().ToString("f2",CultureInfo.InvariantCulture)+"\n"
                +"A diaginal do Quadrado é: "+Diagonal().ToString("f2",CultureInfo.InvariantCulture);
        }

    }
}
