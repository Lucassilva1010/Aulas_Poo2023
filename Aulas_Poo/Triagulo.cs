using System;

namespace Aulas_Poo
{
    internal class Triagulo
    {
        //Essa classe vai representar os lados de um triangulo
        public double A;
        public double B;
        public double C;

        //metodos para calcular os lados de um triagulo
        public double Area()
        {
            double p = (A+B+C)/2.0;
            double area = Math.Sqrt(p*(p-A)*(p-B)*(p-C));
            return area;
        }

    }
}
