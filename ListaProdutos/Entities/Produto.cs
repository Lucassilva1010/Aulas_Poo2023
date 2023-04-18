namespace ListaProdutos.Entities
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto()
        {

        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string EtiquetaProduto()
        {
            return $"Nome do Produto {Nome} - Valor: ${Preco} \n";
        }

    }
}
