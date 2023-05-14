using AluguelConInterface.Servicos;
using LocadoraI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraI.Servicos
{
    internal class ServicoAlugel
    {
        public double PrecoPorHora { get; private set; }
        public double PrecoPorDia { get; private set; }


        private  ITaxaDeServico _taxaServico;

        public ServicoAlugel(double precoPorHora, double precoPorDia, ITaxaDeServico taxaDeServico)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            _taxaServico = taxaDeServico;
        }

        public void ProcessoAluguel(AlugelDeCarro alugelDeCarro)
        {
            TimeSpan duracao = alugelDeCarro.SaidaDoCarro.Subtract(alugelDeCarro.EntradaDoCarro);

            double pagamentoBasico = 0.0;

            if (duracao.TotalHours <=12.0)
            {
                pagamentoBasico = PrecoPorHora * Math.Ceiling(duracao.TotalHours);

            }
            else   
            {
                pagamentoBasico = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
            }

            double taxa = _taxaServico.Taxa(pagamentoBasico);
            

            alugelDeCarro.Nota = new NotaPagamento(pagamentoBasico, taxa);

        }
    }
}
