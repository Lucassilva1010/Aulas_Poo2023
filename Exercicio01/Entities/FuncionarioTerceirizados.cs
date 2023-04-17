using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Entities
{
    internal class FuncionarioTerceirizados:Funcionario
    {
        public double Adicionais { get; set; }

        public FuncionarioTerceirizados()
        {
            
        }
        public FuncionarioTerceirizados(string nome, int horasTrabalhadas, double valorDaHora, double horasAdicionais): base(nome,horasTrabalhadas,valorDaHora)
        {
            Adicionais = horasAdicionais;
        }

        public override double Pagamento()
        {
            
            return base.Pagamento() + 1.1 *Adicionais;
            

        }

        public override string ToString()
        {

            return $"Nome: {Nome}\n" +
                $" Total: {Pagamento()}";

        }


    }
}
