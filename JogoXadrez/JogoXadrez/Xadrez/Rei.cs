using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;

namespace Xadrez
{
    internal class Rei:Peca
    {
        public Rei(Cor cor,Tabuleiroo tabuleiro) : base(cor, tabuleiro)
        {
            
        }
        public override string ToString()
        {
            return "R";
        }
    }
}
