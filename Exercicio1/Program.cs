using Exercicio1.Entities;
using Exercicio1.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.Write("Qual o Nome do seu Departamento? ");
            string departamento = Console.ReadLine();
            Console.WriteLine("Entre com uma data:  ");//Pensar como seria aqui.
            Console.Write("Seu nome é: ");
            string nome = Console.ReadLine();
            Console.Write("Qual o seu nivel? (Junio - Pleno - Sênior):   ");
            NivelTrabalhador nivel = (NivelTrabalhador)Enum.Parse(typeof(NivelTrabalhador), Console.ReadLine(),true);
            Console.Write("Salario Base: ");
            double salBase = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Departamento dep = new Departamento(departamento);
            Trabalhador trabalhador = new Trabalhador(nome,nivel,salBase,dep);

            Console.WriteLine("Quantos contratos a ser criado(s)? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Digite os dados do {i} Contrato."  );

                Console.WriteLine("Data (Dia/Mês/Ano): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Valor da Hora Trabalhada: ");
                double valorH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Quantas Horas foram trabalhadas? ");
                int hora = int.Parse(Console.ReadLine());
                HorasContrato contrato = new HorasContrato(data,valorH,hora);
                trabalhador.AdicionarContrato(contrato);
            }

            Console.WriteLine(  );
            Console.WriteLine("Entre com o Mês e o Ano para calcular o seu ganho Referente ao mês");
            string mesAno = Console.ReadLine();

            int mes = int.Parse(mesAno.Substring(0,2));
            int ano = int.Parse(mesAno.Substring(3));

            Console.WriteLine("Nome: " + trabalhador.Nome);
            Console.WriteLine("Departamento: " + trabalhador.Departamento.Nome);
            Console.WriteLine("Valor calculado é: " + trabalhador.Ganho(mes,ano));

        }
    }
}
