using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantidadeMovimento { get;protected set; }
        public Tabuleiroo Tabuleiro { get; protected set; }

        public Peca()
        {
            
        }

        public Peca(Posicao posicao, Cor cor, Tabuleiroo tabuleiro)
        {
            Posicao = posicao;
            Cor = cor;
            Tabuleiro = tabuleiro;
            QuantidadeMovimento = 0;
        }
    }
}
