using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraI.Entidades
{
    internal class AlugelDeCarro
    {
        public DateTime EntradaDoCarro { get; set; }
        public DateTime SaidaDoCarro { get; set; }
        public Veiculo Veiculo { get; set; }
        public NotaPagamento Nota { get; set; }

        public AlugelDeCarro(DateTime entradaDoCarro, DateTime saidaDoCarro, Veiculo veiculo)
        {
            EntradaDoCarro = entradaDoCarro;
            SaidaDoCarro = saidaDoCarro;
            Veiculo = veiculo;
            Nota = null;
        }
    }
}
