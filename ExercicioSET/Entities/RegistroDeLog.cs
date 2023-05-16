using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSET.Entities
{
    internal class RegistroDeLog
    {
        public string Usuario { get; set; }
        public DateTime Instante { get; set; }

        public override int GetHashCode()
        {
            return Usuario.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is RegistroDeLog))
            {
                return false;
            }
            RegistroDeLog outro = obj as RegistroDeLog;
            return Usuario.Equals(outro.Usuario);
        }
    }
}
