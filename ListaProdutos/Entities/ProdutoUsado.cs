using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaProdutos.Entities
{
    internal class ProdutoUsado:Produto
    {
        public DateTime DataFabricante { get; set; }

        public ProdutoUsado()
        {
            
        }

        public ProdutoUsado(string nome, double preco,DateTime dataFabricante): base(nome,preco)
        {
            DataFabricante = dataFabricante;
        }
        public override string EtiquetaProduto()
        {
            return $"{Nome}(Usado) ${Preco}    Data de Fabricação: {DataFabricante.ToString("dd/MM/yyyy")}"+"\n";
        }
    }
}
