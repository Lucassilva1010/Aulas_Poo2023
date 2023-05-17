using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegates.Services
{
     class CalculaServicos
    {
        public static void Maior(double x , double y)
        {
            double max = (x>y)?x:y;
            Console.WriteLine(max);
        }

        public static void Soma(double x, double y)
        {
            double max = x + y;
            Console.WriteLine(max);
        }

    }
}
