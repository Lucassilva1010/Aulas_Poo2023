using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaProdutos.Entities
{
    internal class ProdutoImportado:Produto
    {
        public double TaxaAlfandega { get; set; }

        public ProdutoImportado()
        {
            
        }

        public ProdutoImportado(string nome, double preco, double taxaAlfandega) : base(nome,preco)
        {
            TaxaAlfandega = taxaAlfandega;
        }

        public override string EtiquetaProduto()
        {
            return base.Nome + $" ${PrecoTotal()} (Taxa da Alfandega: {TaxaAlfandega}) \n ";
        }

        public double PrecoTotal()
        {
            return TaxaAlfandega + Preco;
        }

    }
}
