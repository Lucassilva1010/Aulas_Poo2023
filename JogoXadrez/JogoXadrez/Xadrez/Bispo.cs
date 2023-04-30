using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;

namespace Xadrez
{
    internal class Bispo:Peca
    {

        public Bispo(Cor cor, Tabuleiroo tabuleiro) : base(cor, tabuleiro)
        {

        }
        public override string ToString()
        {
            return "B";
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = Tabuleiro.Pecaa(pos);
            return p == null || p.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];
            Posicao pos = new Posicao(0, 0);

            //NO
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna-1);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tabuleiro.Pecaa(pos) != null && Tabuleiro.Pecaa(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha - 1, pos.Coluna - 1);
            }

            //NE
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna+1);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tabuleiro.Pecaa(pos) != null && Tabuleiro.Pecaa(pos).Cor != Cor)
                {
                    break;
                }
               pos.DefinirValores(pos.Linha-1,pos.Coluna+1);
            }


            //A SE
            pos.DefinirValores(Posicao.Linha+1, Posicao.Coluna + 1);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tabuleiro.Pecaa(pos) != null && Tabuleiro.Pecaa(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha+1, pos.Coluna+1);
            }


            //SO
            pos.DefinirValores(Posicao.Linha+1, Posicao.Coluna - 1);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tabuleiro.Pecaa(pos) != null && Tabuleiro.Pecaa(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha + 1, pos.Coluna - 1);


            }

            return mat;
        }
    }
}

