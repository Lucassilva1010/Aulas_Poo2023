using System;
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


        public PartidaDeXadrez()
        {
            tab = new Tabuleiroo(8,8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            ColocarPecas();
            Terminada = false;
        }
        public void ExecutaMovimento( Posicao origem, Posicao destino)
        {
            Peca p = tab.RetirarPeca(origem);
            p.IncrementaQuantMovimentos();
            Peca pecaCapturada = tab.RetirarPeca(destino);
            tab.ColocarPeca(p, destino);
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

        private void ColocarPecas()
        {
            tab.ColocarPeca(new Torre(Cor.Branca,tab), new PosicaXadrez('c', 1).TrasnformaPosicao());
            tab.ColocarPeca(new Torre(Cor.Branca,tab), new PosicaXadrez('c', 2).TrasnformaPosicao());
            tab.ColocarPeca(new Torre(Cor.Branca,tab), new PosicaXadrez('d', 2).TrasnformaPosicao());
            tab.ColocarPeca(new Torre(Cor.Branca,tab), new PosicaXadrez('e', 1).TrasnformaPosicao());
            tab.ColocarPeca(new Torre(Cor.Branca,tab), new PosicaXadrez('e', 2).TrasnformaPosicao());
            tab.ColocarPeca(new Rei(Cor.Branca,tab), new PosicaXadrez('d', 1).TrasnformaPosicao());

            tab.ColocarPeca(new Torre(Cor.Preta, tab), new PosicaXadrez('c', 7).TrasnformaPosicao());
            tab.ColocarPeca(new Torre(Cor.Preta, tab), new PosicaXadrez('c', 8).TrasnformaPosicao());
            tab.ColocarPeca(new Torre(Cor.Preta, tab), new PosicaXadrez('d', 7).TrasnformaPosicao());
            tab.ColocarPeca(new Torre(Cor.Preta, tab), new PosicaXadrez('e', 7).TrasnformaPosicao());
            tab.ColocarPeca(new Torre(Cor.Preta, tab), new PosicaXadrez('e', 8).TrasnformaPosicao());
            tab.ColocarPeca(new Rei(Cor.Preta, tab), new PosicaXadrez('d', 8).TrasnformaPosicao());
        }

    }
}
