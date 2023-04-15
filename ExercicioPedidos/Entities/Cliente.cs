using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPedidos.Entities
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string  Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();


        public Cliente()
        {
            
        }
        public Cliente(string nome, string email, DateTime dataNascimento)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
        }

        public void AdicionarPedido(Pedido pedido)
        {
            Pedidos.Add(pedido);
        }

        public int QuantidadePedidos()
        {
            return Pedidos.Count;
        }

        public override string ToString()
        {
            return $" {Nome} - {DataNascimento.ToString("dd/MM/yyyy")} - {Email}";
        }
    }
}
