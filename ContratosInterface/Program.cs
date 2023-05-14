using ContratosInterface.Entidades;
using ContratosInterface.Servicos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratosInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Entre com os dados do contrato:  ");
            Console.Write("Numero do contrato: ");
            int numeContrato = int.Parse(Console.ReadLine());
            Console.Write("Data (dia/mês/ano): ");
            DateTime dataContrato = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",CultureInfo.InvariantCulture);
            Console.Write("Valor do contrato: ");
            double valorContrato = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Numero de messes para prestações: ");
            int mesesPrestacao = int.Parse(Console.ReadLine());

            Contrato meuContrato = new Contrato(numeContrato,dataContrato,valorContrato);

            ContratoServico contratoServico = new ContratoServico(new PaypalServico());
            contratoServico.ProcessoContrato(meuContrato,mesesPrestacao);

            Console.WriteLine(); 
            Console.WriteLine("Prestações: ");
            foreach (Prestacao p in meuContrato.Prestacoes)
            {
                Console.WriteLine(p);
            }
        }
    }
}
