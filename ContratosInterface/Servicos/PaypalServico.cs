using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratosInterface.Servicos
{
    internal class PaypalServico: IPagamentoDeServicoOnline
    {
        private const double ProcentagemDaTaxa = 0.02;
        private const double JurosMensais = 0.01;

        public double TaxaDePagamento(double quantia)
        {
            return quantia * ProcentagemDaTaxa;
        }

        public double Interesse(double quantia, int meses)
        {
            return quantia * JurosMensais * meses;

        }

    }
}
