using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceIComparable.Entities
{
    internal class Funcionario: IComparable
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public Funcionario(string csvFuncionario) {

            string[] vect = csvFuncionario.Split(',');
            Nome = vect[0];
            Salario = double.Parse(vect[1],CultureInfo.InvariantCulture);
      
        }
        public override string ToString()
        {
            return Nome +" - " + Salario.ToString("f2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Funcionario)){

                throw new ArgumentException("Erro de comparação");
            }   
            Funcionario outro = obj as Funcionario;
            return Nome.CompareTo(outro.Nome);
        }
    }
}
