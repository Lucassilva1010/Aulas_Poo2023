using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificador
{
    public class TesteModificador
    {


        public static int TesteModificado(int n1, int n2)
        {
             return  n1 + n2;
        }
        public static double Modd( int n1, int n2, int n3)
        {
            double result;
            return result = n1 + n2+n3;
        }
        public static double Modd2( int[] n1)
        {
            double result=0;
            for (int i = 0; i < n1.Length; i++)
            {
                result += n1[i];
            }
            return result;
        }

        public static int Modd3( params int[] n1)
        {
            int result = 0;
            for(int i = 0;i < n1.Length; i++)
            {
                result += n1[i];
            }

            return result;
        }
        

        

    }
}
