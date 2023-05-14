using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratosInterface.Entidades
{
    internal class Prestacao
    {
        public DateTime  DataDeVencimento { get; set; }
        public double  Quantia { get; set; }

        public Prestacao(DateTime dataDeVencimento, double quantia)
        {
            DataDeVencimento = dataDeVencimento;
            Quantia = quantia;
        }

        public override string ToString()
        {
            return DataDeVencimento.ToString("dd/MM/yyyy")
                +" -"
                + Quantia.ToString("f2",CultureInfo.InvariantCulture);
        }
    }
}
