namespace Tabuleiro
{
    internal class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

     

        public Posicao(int linha, int coluna)
        {
           this. Linha = linha;
            this.Coluna = coluna;
        }
        public void DefinirValores(int linha, int coluna)
        {
           this.Linha = linha; //Aqui teve um erro
            this.Coluna = coluna;
        }
        public override string ToString()
        {
            return $"{Linha},"
                + $"{Coluna}";
        }
    }
}
