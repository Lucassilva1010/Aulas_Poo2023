using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensaoDeMetodos.Extension
{
    static class ExtensionsDeMetodos
    {
        public static string TempoDecorrido(this DateTime mesmoObjeto)
        {
            TimeSpan tempo = DateTime.Now.Subtract(mesmoObjeto);
            if (tempo.TotalHours <24.0) {
                return tempo.TotalHours.ToString("f1", CultureInfo.InvariantCulture)+" - Horas";            
            }
            return tempo.TotalDays.ToString("f1", CultureInfo.InvariantCulture) + " - Dias";
        }
    }
}
