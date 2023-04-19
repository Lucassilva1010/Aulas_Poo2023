using Exercicio001.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio001.Entities
{
    internal class Reserva
    {
        public int NumeroDoQuarto { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reserva()
        {
            
        }

        public Reserva(int numeroDoQuarto, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
            {

                throw new DominioException("Erro na reserva!  Data de Saida menor que a date de Entrada!");
            }
            NumeroDoQuarto = numeroDoQuarto;
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public int Duracao()
        {

            TimeSpan duracao = CheckOut.Subtract(CheckIn);//pega o intervalo entre datas
            return (int)duracao.TotalDays;//total de dias e convertendo para inteiro
        }

        public void AtualizacaoDeDatas(DateTime checkin, DateTime checkuout)
        {
            DateTime dataDoDia = DateTime.Now;

            if (checkin < dataDoDia || checkuout < dataDoDia)
            {
                throw new DominioException( "Erro na Atualização da reserva!  Datas para atualização precisam ser datas futuras!");
            }
            if (checkuout <= checkin)
            {

                throw new DominioException("Erro na reserva!  Data de Saida menor que a date de Entrada!");
            }
            CheckIn = checkin;
            CheckOut = checkuout;
        }

        public override string ToString()
        {
            return $"Quarto {NumeroDoQuarto},"
                + $" check-In: {CheckIn.ToString("dd/MM/yyyy")},"
                + $" chek-Out: {CheckOut.ToString("dd/MM/yyyy")},"
                + $" {Duracao()} - Noites";
        }
    }
}
