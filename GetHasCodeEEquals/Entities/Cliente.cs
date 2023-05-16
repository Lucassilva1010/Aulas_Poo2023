using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHasCodeEEquals.Entities
{
     class Cliente
    {

        public string Nome  { get; set; }
        public int Cpf  { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Cliente))
            {
                return false;
            }
            Cliente OutroCliente = obj as Cliente;
            return Cpf.Equals(OutroCliente.Cpf);
        }

        public override int GetHashCode()
        {
            return Cpf.GetHashCode();
        }
    }
}
