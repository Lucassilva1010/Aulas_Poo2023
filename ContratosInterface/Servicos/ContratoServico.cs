using ContratosInterface.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratosInterface.Servicos
{
    internal class ContratoServico
    {
        private IPagamentoDeServicoOnline _pagamentoDeServicoOnline;

        public ContratoServico(IPagamentoDeServicoOnline pagamentoDeServicoOnline)
        {
            _pagamentoDeServicoOnline = pagamentoDeServicoOnline;
        }


        public void ProcessoContrato(Contrato contrato, int meses)
        {
            double quotaBasica = contrato.ValorTotal / meses;
            for (int i = 0; i < meses; i++)
            {
                DateTime data = contrato.Data.AddMonths(i);
                double atualizaQuota = quotaBasica + _pagamentoDeServicoOnline.Interesse(quotaBasica, i);
                double cotaCompleta = atualizaQuota + _pagamentoDeServicoOnline.TaxaDePagamento(atualizaQuota);
                contrato.AdicionaParcela(new Prestacao(data,cotaCompleta));
            }

        }
    }
}
