using AluguelConInterface.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraI.Servicos
{
     class TaxaBrasilServico:ITaxaDeServico
    {
        public double Taxa(double valor)
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
