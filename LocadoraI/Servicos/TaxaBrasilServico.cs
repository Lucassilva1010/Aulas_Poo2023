using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraI.Servicos
{
    internal class TaxaBrasilServico
    {
        public double TaxaB(double valor)
        {
            if(valor<=100) {

                return valor * 0.2;

            }else 
            {
                return valor  * 0.15;
            }
           
        }
    }
}
