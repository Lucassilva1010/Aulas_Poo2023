using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Entities
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public int HorasTrabalhadas { get; set; }
        public double ValorDaHora { get; set; }

        public Funcionario()
        {
            
        }

        public Funcionario(string nome, int horasTrabalhadas, double valorDaHora)
        {
            Nome = nome;
            HorasTrabalhadas = horasTrabalhadas;
            ValorDaHora = valorDaHora;
        }

        public virtual double Pagamento()
        {

            return ValorDaHora * HorasTrabalhadas;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nome: {Nome}");
            sb.AppendLine($"Total: {Pagamento()}");

            return sb.ToString();

        }
    }
}
