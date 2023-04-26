using System.Security.Authentication.ExtendedProtection;
using Tabuleiro;

namespace Xadrez
{
    internal class PartidaDeXadrez
    {
        public Tabuleiroo tab { get; private set; }
        private int turno;
        private Cor JogadorAtual;
        public bool Terminada { get; private set; }


        public PartidaDeXadrez()
        {
            tab = new Tabuleiroo(8,8);
            turno = 1;
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
