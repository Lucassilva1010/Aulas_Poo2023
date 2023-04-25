using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;

namespace Xadrez
{
    internal class Torre:Peca
    {
        public Torre(Cor cor, Tabuleiroo tabuleiro): base(cor, tabuleiro)
        {
            
        }
        public override string ToString()
        {
            return "T";
        }
    }
}
