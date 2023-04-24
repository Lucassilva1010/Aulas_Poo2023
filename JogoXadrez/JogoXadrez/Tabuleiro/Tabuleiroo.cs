namespace Tabuleiro
{
     class Tabuleiroo
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public Tabuleiroo()
        {

        }

        public Tabuleiroo(int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }

        public Peca Pecaa( int linhas, int colunas)
        {
            return Pecas[linhas,colunas];
        }
    }
}
