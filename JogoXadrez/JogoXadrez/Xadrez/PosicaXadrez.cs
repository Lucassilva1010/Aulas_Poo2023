using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;

namespace Xadrez
{
    internal class PosicaXadrez
    {
        public char Coluna { get; set; }
        public int  Linha { get; set; }

        public PosicaXadrez( char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public Posicao TrasnformaPosicao()
        {
            return new Posicao(8 - Linha, Coluna -'a');
        }

        public override string ToString()
        {
            return $"{Coluna}{Linha}";
        }


    }
}
