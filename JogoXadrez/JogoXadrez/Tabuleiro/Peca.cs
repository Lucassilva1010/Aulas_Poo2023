namespace Tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantidadeMovimento { get; protected set; }
        public Tabuleiroo Tabuleiro { get; protected set; }

        public Peca()
        {

        }

        public Peca(Cor cor, Tabuleiroo tabuleiro)
        {
            Posicao = null;
            Cor = cor;
            Tabuleiro = tabuleiro;
            QuantidadeMovimento = 0;
        }

        public void IncrementaQuantMovimentos()
        {
            QuantidadeMovimento++;
        }
        public void DecrementaQuantMovimentos()
        {
            QuantidadeMovimento--;
        }


        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for (int i = 0; i < Tabuleiro.Linhas; i++)
            {
                for (int j = 0; j < Tabuleiro.Colunas; j++)
                {
                    if (mat[i,j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool PodeMoverParaUmaDadaPosicao(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimentosPossiveis();

    }
}
