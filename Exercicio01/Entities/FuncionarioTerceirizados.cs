using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Entities
{
    internal class FuncionarioTerceirizados:Funcionario
    {
        public double HorasAdicionais { get; set; }

        public FuncionarioTerceirizados()
        {
            
        }
        public FuncionarioTerceirizados(string nome, int horasTrabalhadas, double valorDaHora, double horasAdicionais): base(nome,horasTrabalhadas,valorDaHora)
        {
            HorasAdicionais = horasAdicionais;
        }

        public override double Pagamento()
        {
            
            double valorTotal = base.Pagamento();
            valorTotal += HorasAdicionais;

            double porcentagem = valorTotal * 0.1;

            valorTotal += porcentagem;
            return valorTotal;

        }

        public override string ToString()
        {

            return $"Nome: {Nome}\n" +
                $" Total: {Pagamento()}";

        }


    }
}
