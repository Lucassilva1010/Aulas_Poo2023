using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Entities
{
    internal class HorasContrato
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double ValorDaHora { get; set; }
        public int Horas { get; set; }
        public Trabalhador trabalhador { get; set; }

        public HorasContrato()
        {
            
        }

        public HorasContrato(DateTime data, double valorDaHora, int horas)
        {
            Data = data;
            ValorDaHora = valorDaHora;
            Horas = horas;
        }

        public double ValorTotalReceber(){

            return  ValorDaHora * Horas;

        }
    }
}
