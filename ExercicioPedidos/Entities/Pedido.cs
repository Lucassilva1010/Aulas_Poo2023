using ExercicioPedidos.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPedidos.Entities
{
    internal class Pedido
    {
        public DateTime Momento { get; set; } = DateTime.Now;
        public StatusPedido StatusPedido { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemDoPedido> Itens { get; set; } = new List<ItemDoPedido>();

        public Pedido()
        {
            
        }
        public Pedido(DateTime momento, StatusPedido statusPedido, Cliente cliente)
        {
            Momento = momento;
            StatusPedido = statusPedido;
            Cliente = cliente;
        }

        public void AdicionaItem(ItemDoPedido item)
        {
           Itens.Add(item);
        }
        public void RemoveItem(ItemDoPedido item)
        {
            Itens.Remove(item);
        }
        public double TotalPedido()
        {
            double total = 0;

            foreach  (ItemDoPedido i in Itens)
            {
                
                total += i.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Momento do Pedido: ");
            sb.Append(Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status do pedido: ");
            sb.Append(StatusPedido.ToString());
            sb.AppendLine("Cliente: ");
            sb.Append(Cliente.ToString());//Sobrescrito na classe cliente
            sb.AppendLine("Itens do Pedido: ");
            foreach (ItemDoPedido item in Itens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.Append("Preço Total: ");
            sb.Append(TotalPedido().ToString("C",CultureInfo.InvariantCulture));
            return sb.ToString();
        }




    }
}
