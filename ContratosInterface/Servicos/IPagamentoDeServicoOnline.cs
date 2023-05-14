using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratosInterface.Servicos
{
     interface IPagamentoDeServicoOnline
    {
         double TaxaDePagamento(double quantia);
        double Interesse(double quantia, int meses);
    }
}
