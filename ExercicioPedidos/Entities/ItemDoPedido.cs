using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPedidos.Entities
{
    internal class ItemDoPedido
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; }

        public ItemDoPedido()
        {
            
        }

        public ItemDoPedido(int quantidade, double preco, Produto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public double SubTotal()
        {
            return  Quantidade *  Preco;
        }

        public override string ToString()
        {
            return $"{Produto.Nome}, {Produto.Preco}, Quantidade: {Quantidade}, Subtotal: {SubTotal().ToString("C",CultureInfo("pt-BR"))} ";
        }


    }
}
