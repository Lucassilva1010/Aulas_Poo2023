using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;

namespace Xadrez
{
    internal class Peao:Peca
    {
        public Peao(Cor cor, Tabuleiroo tabuleiro) : base(cor, tabuleiro)
        {

        }
        public override string ToString()
        {
            return "P";
        }
        private bool ExisteInimigo(Posicao pos)
        {
            Peca p = Tabuleiro.Pecaa(pos);
            return p != null && p.Cor != Cor;
        }
        private bool Livre(Posicao pos)
        {
            return Tabuleiro.Pecaa(pos)==null;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];
            Posicao pos = new Posicao(0, 0);

            if (Cor == Cor.Branca)
            {
                //NO
                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna );
                if (Tabuleiro.PosicaoValida(pos) && Livre(pos) )
                {
                    mat[pos.Linha, pos.Coluna] = true;

                }
                pos.DefinirValores(Posicao.Linha - 2, Posicao.Coluna );
                if (Tabuleiro.PosicaoValida(pos) && Livre(pos) && QuantidadeMovimento==0)
                {
                    mat[pos.Linha, pos.Coluna] = true;

                } 
                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna -1);
                if (Tabuleiro.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;

                }
                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna +1);
                if (Tabuleiro.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;

                }
                else
                {
                    pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
                    if (Tabuleiro.PosicaoValida(pos) && Livre(pos))
                    {
                        mat[pos.Linha, pos.Coluna] = true;

                    }
                    pos.DefinirValores(Posicao.Linha + 2, Posicao.Coluna);
                    if (Tabuleiro.PosicaoValida(pos) && Livre(pos) && QuantidadeMovimento == 0)
                    {
                        mat[pos.Linha, pos.Coluna] = true;

                    }
                    pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
                    if (Tabuleiro.PosicaoValida(pos) && ExisteInimigo(pos))
                    {
                        mat[pos.Linha, pos.Coluna] = true;

                    }
                    pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
                    if (Tabuleiro.PosicaoValida(pos) && ExisteInimigo(pos))
                    {
                        mat[pos.Linha, pos.Coluna] = true;

                    }
                }

            }
            return mat;
        }
    }
}
