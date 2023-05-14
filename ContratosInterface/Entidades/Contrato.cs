using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratosInterface.Entidades
{
     class Contrato
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }
        public List<Prestacao> Prestacoes { get; set; }

        public Contrato(int numero, DateTime data, double valorTotal)
        {
            Numero = numero;
            Data = data;
            ValorTotal = valorTotal;
            Prestacoes = new List<Prestacao>();
        }

        public void AdicionaParcela(Prestacao prestacao)
        {
            Prestacoes.Add(prestacao);
        }
    }
}
