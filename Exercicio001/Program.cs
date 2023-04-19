using Exercicio001.Entities;
using Exercicio001.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.Write("Numero do quarto: ");
                int quarto = int.Parse(Console.ReadLine());


                Console.Write("Data de Check-IN: ");
                DateTime dataCIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de Check-Out: ");
                DateTime dataOut = DateTime.Parse(Console.ReadLine());


                Reserva reserva = new Reserva(quarto, dataCIn, dataOut);
                Console.WriteLine($"Reserva concluida com suesso! {reserva}");

                Console.WriteLine();
                Console.WriteLine("Atualizando as datas da Reserva!");


                Console.Write("Data de Check-IN: ");
                dataCIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de Check-Out: ");
                dataOut = DateTime.Parse(Console.ReadLine());

                reserva.AtualizacaoDeDatas(dataCIn, dataOut);
                Console.WriteLine($"Atualização concluida com suesso! {reserva}");

            }
            catch (DominioException e)
            {

                Console.WriteLine($"Erro na reserva: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Formato de dado Errado: '{e.Message} ");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro inesperado! {e}");
            }
            finally { 
                //roda toda vez
                Console.WriteLine("Thau Brasil!!!!"); 
            }
        }
    }
}
