using AluguelConInterface.Servicos;
using LocadoraI.Entidades;
using LocadoraI.Servicos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraConInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Entre com os registro dos carros: ");
            Console.Write("Modelo do carro:  ");
            string carro = Console.ReadLine();

            Console.Write("Entrada do carro: (dd/MM/yyyy hh:ss) ");
            DateTime dataEntrada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:ss", CultureInfo.InvariantCulture);
            Console.Write("Saida do carro: (dd/MM/yyyy hh:ss) ");
            DateTime dataSaida = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:ss", CultureInfo.InvariantCulture);

            Console.Write("Valor por Hora: ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Valor por Dia: ");
            double valorDia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            AlugelDeCarro alugelDeCarro = new AlugelDeCarro(dataEntrada, dataSaida, new Veiculo(carro));
            ServicoAlugel servicoAlugel = new ServicoAlugel(valorHora, valorDia, new TaxaBrasilServico());


            servicoAlugel.ProcessoAluguel(alugelDeCarro);

            Console.WriteLine();
            Console.WriteLine("--------- Valor do Aluguel ---- ");
            Console.WriteLine(alugelDeCarro.Nota);
            Console.ReadLine();

        }
    }
}
