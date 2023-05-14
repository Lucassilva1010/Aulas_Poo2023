using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraI.Entidades
{
    internal class NotaPagamento
    {
        public double ValorBasicoPagamento { get; set; }
        public double Taxa { get; set; }


        public NotaPagamento(double valorBasicoPagamento, double taxa )
        {
            ValorBasicoPagamento = valorBasicoPagamento;
            Taxa = taxa;
        }

        public double TotalPagamento {
            get { return ValorBasicoPagamento + Taxa; }
            
        }

        public override string ToString()
        {
            return $"Pagamento Baisco: {ValorBasicoPagamento.ToString("f2", CultureInfo.InvariantCulture)} "
                + $"\nTaxa: {Taxa.ToString("f2",CultureInfo.InvariantCulture)}"
                + $"\n Pagemento total: {TotalPagamento.ToString("f2",CultureInfo.InvariantCulture)}";               ;
        }
    }
}
