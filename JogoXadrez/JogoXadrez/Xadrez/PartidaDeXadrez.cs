using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Policy;
using Tabuleiro;

namespace Xadrez
{
     class PartidaDeXadrez
    {
        public Tabuleiroo tab { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool Terminada { get; private set; }
        private HashSet<Peca> Pecas;
        private HashSet<Peca> Capturadas;
        public bool Xeque { get; private set; }
        public Peca VulneravelEmPassant { get;  set; }
       



        public PartidaDeXadrez()
        {
            tab = new Tabuleiroo(8,8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            Xeque = false;
            Pecas = new HashSet<Peca>();
            Capturadas = new HashSet<Peca>();
            ColocarPecas();
           

        }
        public Peca ExecutaMovimento( Posicao origem, Posicao destino)
        {
            Peca p = tab.RetirarPeca(origem);
            p.IncrementaQuantMovimentos();
            Peca pecaCapturada = tab.RetirarPeca(destino);
            tab.ColocarPeca(p, destino);
            if (pecaCapturada != null)
            {
                Capturadas.Add(pecaCapturada);
            }
            //#Jogada Especial Roque pequeno
            if (p is Rei && destino.Coluna == origem.Coluna +2)
            {
                Posicao origemT = new Posicao(origem.Linha, origem.Coluna + 3);
                Posicao destinoT = new Posicao(origem.Linha, origem.Coluna + 1);
                Peca t = tab.RetirarPeca(origemT);
                t.IncrementaQuantMovimentos();
                tab.ColocarPeca(t, destinoT);
            }

            //#Jogada Especial Roque pequeno
            if (p is Rei && destino.Coluna == origem.Coluna - 2)
            {
                Posicao origemT = new Posicao(origem.Linha, origem.Coluna -4 );
                Posicao destinoT = new Posicao(origem.Linha, origem.Coluna -1 );
                Peca t = tab.RetirarPeca(origemT);
                t.IncrementaQuantMovimentos();
                tab.ColocarPeca(t, destinoT);
            }

            //#jogada especial en passant
            if (p is Peao)
            {
                if (origem.Coluna != destino.Coluna && pecaCapturada == null)
                {
                    Posicao posP;
                    if (p.Cor == Cor.Branca)
                    {
                        posP = new Posicao(destino.Linha + 1, destino.Coluna);

                    }
                    else
                    {
                        posP = new Posicao(destino.Linha -1, destino.Coluna);
                    }
                    pecaCapturada = tab.RetirarPeca(posP);
                    Capturadas.Add(pecaCapturada);
                }
            }

            return pecaCapturada;
        }
       

        public void DesFazMooviment(Posicao origem ,Posicao destino, Peca pecaCapturada)
        {
            Peca p = tab.RetirarPeca(destino);
            p.DecrementaQuantMovimentos();
           
            if (pecaCapturada != null)
            {
                tab.ColocarPeca(pecaCapturada, destino);
                Capturadas.Remove(pecaCapturada);
            }
            tab.ColocarPeca(p, origem);
            //#Jogada Especial Roque pequeno
            if (p is Rei && destino.Coluna == origem.Coluna + 2)
            {
                Posicao origemT = new Posicao(origem.Linha, origem.Coluna + 3);
                Posicao destinoT = new Posicao(origem.Linha, origem.Coluna + 1);
                Peca t = tab.RetirarPeca(destinoT);
                t.DecrementaQuantMovimentos();
                tab.ColocarPeca(t, origemT);
            }

            //#Jogada Especial Roque Grande
            if (p is Rei && destino.Coluna == origem.Coluna - 2)
            {
                Posicao origemT = new Posicao(origem.Linha, origem.Coluna -4);
                Posicao destinoT = new Posicao(origem.Linha, origem.Coluna - 1);
                Peca t = tab.RetirarPeca(destinoT);
                t.DecrementaQuantMovimentos();
                tab.ColocarPeca(t, destinoT);
            }

            //#jogada especial en passant
            if (p is Peao)
            {
                if (origem.Coluna != destino.Coluna && pecaCapturada == VulneravelEmPassant)
                {
                    Peca peao = tab.RetirarPeca(destino);
                    Posicao posP;
                    if (p.Cor == Cor.Branca){
                        posP = new Posicao(3, destino.Coluna);
                    }
                    else
                    {
                        posP = new Posicao(4, destino.Coluna);
                    }
                    tab.ColocarPeca(peao,posP);
                }
            }
           
        }

        public void RealizaJogada(Posicao origem,Posicao destino)
        {
          Peca  pecaCapturada = ExecutaMovimento(origem, destino);
            if (EstaEmXeque(JogadorAtual))
            {
                DesFazMooviment(origem, destino, pecaCapturada);
                throw new TabuleiroExecption("Você nãao pode se  coloccar em XEQUE!");

            }
            Peca p = tab.Pecaa(destino);

            //# Jogada especial promoção 
            if (p is Peao)
            {
                if ((p.Cor == Cor.Branca && destino.Linha == 0) ||  (p.Cor ==Cor.Preta && destino.Linha == 7))
                {
                    p = tab.RetirarPeca(destino);
                    Pecas.Remove(p);

                    Peca dama = new Dama(tab, p.Cor);
                    tab.ColocarPeca(dama, destino);
                    Pecas.Add(dama);
                }
            }


            if (EstaEmXeque(Adiversario(JogadorAtual)))
            {
                Xeque = true;

            }
            else
            {
                Xeque=false;
            }
            if (TesteXequeMate(Adiversario(JogadorAtual)))
            {
                Terminada = true;
            }
            else
            {

             Turno++;
                MudaJogador();
            }

           
            //#jogada Especial em Passant 
            if (p is Peao && (destino.Linha == origem.Linha -2 || destino.Coluna == origem.Coluna+2))
            {
                VulneravelEmPassant = p;
            }
            else
            {
                VulneravelEmPassant =null;
            }

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
            if (!tab.Pecaa(origem).MovimentoPossivel(destino)) {
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
            foreach (Peca x in Pecas)
            {
                if (x.Cor == cor)
                {
                    aux.Add(x);
                }
            }
            aux.ExceptWith(PecasCapturadas(cor));
            return aux;
        }

        private Cor Adiversario(Cor cor)
        {
            if (cor == Cor.Branca)
            {
                return Cor.Preta;
            }
            else{
                return Cor.Branca;
            }

        }
        private Peca Rei(Cor cor )
        {
            foreach (Peca x in PecasEmJogo(cor))
            {
                if (x is Rei)
                {
                    return x;
                }
            }
            return null;    
        }

        public bool EstaEmXeque(Cor cor)
        {
            Peca R = Rei(cor);
            if (R == null)
            {
                throw new TabuleiroExecption($"Não tem Rei da cor {cor} no tabuleiro!");
            }
            foreach (Peca x in PecasEmJogo(Adiversario(cor)))
            {
                bool[,] mat = x.MovimentosPossiveis();
                if (mat[R.Posicao.Linha, R.Posicao.Coluna])
                {
                    return true;
                }
            }
            return false;
        }

        public bool TesteXequeMate(Cor cor)
        {
            if (!EstaEmXeque(cor))
            {
                return false;
            }
            foreach (Peca x in PecasEmJogo(cor))
            {
                bool[,] mat = x.MovimentosPossiveis();
                for (int i = 0; i < tab.Linhas; i++)
                {
                    for (int j = 0; j < tab.Colunas; j++)
                    {
                        if (mat[i,j])
                        {
                            Posicao origem = x.Posicao;
                            Posicao destino = new Posicao(i,j);
                            Peca pecaCapturada = ExecutaMovimento(origem, destino);
                            bool testeXeque = EstaEmXeque(cor);
                            DesFazMooviment(origem, destino,pecaCapturada);
                            if (!testeXeque)
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }





        public void ColocarNovaPeca(char coluna, int linha, Peca peca )
        {
            tab.ColocarPeca(peca, new PosicaXadrez(coluna, linha).TrasnformaPosicao());
            Pecas.Add(peca);
        }

        private void ColocarPecas()
        {


            ColocarNovaPeca('a', 1, new Torre(Cor.Branca, tab));
            ColocarNovaPeca('b', 1, new Cavalo(Cor.Branca, tab));
            ColocarNovaPeca('c', 1, new Bispo(Cor.Branca, tab));
            ColocarNovaPeca('d', 1, new Dama(Cor.Branca, tab));
            ColocarNovaPeca('e', 1, new Rei(Cor.Branca, tab, this));
            ColocarNovaPeca('f', 1, new Bispo(Cor.Branca, tab));
            ColocarNovaPeca('g', 1, new Cavalo(Cor.Branca, tab));
            ColocarNovaPeca('h', 1, new Torre(Cor.Branca, tab));
            ColocarNovaPeca('a', 2, new Peao(Cor.Branca, tab, this));
            ColocarNovaPeca('b', 2, new Peao(Cor.Branca, tab, this));
            ColocarNovaPeca('c', 2, new Peao(Cor.Branca, tab, this));
            ColocarNovaPeca('d', 2, new Peao(Cor.Branca, tab, this));
            ColocarNovaPeca('e', 2, new Peao(Cor.Branca, tab, this));
            ColocarNovaPeca('f', 2, new Peao(Cor.Branca, tab, this));
            ColocarNovaPeca('g', 2, new Peao(Cor.Branca, tab, this));
            ColocarNovaPeca('h', 2, new Peao(Cor.Branca, tab, this));


            ColocarNovaPeca('a', 8, new Torre(Cor.Preta, tab));
            ColocarNovaPeca('b', 8, new Cavalo(Cor.Preta, tab));
            ColocarNovaPeca('c', 8, new Bispo(Cor.Preta, tab));
            ColocarNovaPeca('d', 8, new Dama(Cor.Preta, tab));
            ColocarNovaPeca('e', 8, new Rei(Cor.Preta, tab, this));
            ColocarNovaPeca('f', 8, new Bispo(Cor.Preta, tab));
            ColocarNovaPeca('g', 8, new Cavalo(Cor.Preta, tab));
            ColocarNovaPeca('h', 8, new Torre(Cor.Preta, tab));
            ColocarNovaPeca('a', 7, new Peao(Cor.Preta, tab, this));
            ColocarNovaPeca('b', 7, new Peao(Cor.Preta, tab, this));
            ColocarNovaPeca('c', 7, new Peao(Cor.Preta, tab, this));
            ColocarNovaPeca('d', 7, new Peao(Cor.Preta, tab, this));
            ColocarNovaPeca('e', 7, new Peao(Cor.Preta, tab, this));
            ColocarNovaPeca('f', 7, new Peao(Cor.Preta, tab, this));
            ColocarNovaPeca('g', 7, new Peao(Cor.Preta, tab, this));
            ColocarNovaPeca('h', 7, new Peao(Cor.Preta, tab, this));


        }

    }
}
