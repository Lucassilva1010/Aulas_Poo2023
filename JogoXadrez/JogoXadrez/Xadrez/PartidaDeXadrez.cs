using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Security.Authentication.ExtendedProtection;
using Tabuleiro;

namespace Xadrez
{
    internal class PartidaDeXadrez
    {
        public Tabuleiroo tab { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool Terminada { get; private set; }
        private HashSet<Peca> Pecas;
        private HashSet<Peca> Capturadas;



        public PartidaDeXadrez()
        {
            tab = new Tabuleiroo(8,8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            Pecas = new HashSet<Peca>();
            Capturadas = new HashSet<Peca>();
            ColocarPecas();
           

        }
        public void ExecutaMovimento( Posicao origem, Posicao destino)
        {
            Peca p = tab.RetirarPeca(origem);
            p.IncrementaQuantMovimentos();
            Peca pecaCapturada = tab.RetirarPeca(destino);
            tab.ColocarPeca(p, destino);
            if (pecaCapturada != null)
            {
                Capturadas.Add(pecaCapturada);
            }

        }
        public void RealizaJogada(Posicao origem,Posicao destino)
        {
            ExecutaMovimento(origem, destino);
            Turno++;
            MudaJogador();
        }
        public void ValidarPosicaoDeOrigem(Posicao pos)
        {
            if (tab.Pecaa(pos)==null)
            {
                throw new TabuleiroExecption("Não existe peça na posição de origem escolhida!");
            }
            if (JogadorAtual != tab.Pecaa(pos).Cor)
            {
                throw new TabuleiroExecption("A peça de origem escolhida não é sua!");
            }
            if (!tab.Pecaa(pos).ExisteMovimentosPossiveis())
            {
                throw new TabuleiroExecption("Não há movimentos possiveis para a peça de origem escolhida!");
            }
        }


        public  void ValidarPosicaoDestino(Posicao origem, Posicao destino)
        {
            if (!tab.Pecaa(origem).PodeMoverParaUmaDadaPosicao(destino)) {
                throw new TabuleiroExecption("Posição de destino inválida!");
            }
        }
        public void MudaJogador()
        {
            if(JogadorAtual == Cor.Branca)
            {
                JogadorAtual = Cor.Preta;
            }
            else
            {
                JogadorAtual = Cor.Branca;
            }
        }

        public HashSet<Peca> PecasCapturadas(Cor cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca x in Capturadas)
            {
                if (x.Cor == cor)
                {
                    aux.Add(x);
                }
            }
            return aux;
        }

        public HashSet<Peca> PecasEmJogo(Cor cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca x in Capturadas)
            {
                if (x.Cor == cor)
                {
                    aux.Add(x);
                }
            }
            aux.ExceptWith(PecasCapturadas(cor));
            return aux;
        }


        public void ColocarNovaPeca(char coluna, int linha, Peca peca )
        {
            tab.ColocarPeca(peca, new PosicaXadrez(coluna, linha).TrasnformaPosicao());
            Pecas.Add(peca);
        }

        private void ColocarPecas()
        {

            ColocarNovaPeca('c',1, new Torre(Cor.Branca, tab));
            ColocarNovaPeca('c',2, new Torre(Cor.Branca,tab));
            ColocarNovaPeca('d',2, new Torre(Cor.Branca,tab));
            ColocarNovaPeca('e',2, new Torre(Cor.Branca,tab));
            ColocarNovaPeca('e',1, new Torre(Cor.Branca,tab));
            ColocarNovaPeca('d',1, new  Rei(Cor.Branca,tab));


            ColocarNovaPeca('c',7, new Torre(Cor.Preta,tab));
            ColocarNovaPeca('c',8, new Torre(Cor.Preta,tab));
            ColocarNovaPeca('d',7, new Torre(Cor.Preta,tab));
            ColocarNovaPeca('e',7, new Torre(Cor.Preta,tab));
            ColocarNovaPeca('e',8, new Torre(Cor.Preta,tab));
            ColocarNovaPeca('d',8, new Rei(Cor.Preta,tab));
            

        }

    }
}
