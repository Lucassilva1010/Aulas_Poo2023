using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EunumeracoesCompo.Entities.Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cidades c = new Cidades();
            c.Estado = new Estados();

            Estados ee = new Estados();
            Cidades novo = new Cidades();

            novo.ListaEstados();




            Console.WriteLine("\n oi->" + c.Estado + "\n");

            Console.WriteLine("Listando os Enums: ");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"O {i} estado é: ->" + ee);
                ee++;
            }

            Console.WriteLine("novo demonstração: ");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"O {i} estado é: ->" + c.Estado);
                c.Estado++;
            }

            //converter os enums para string 
            string vari = Estados.Pe.ToString();
            Console.WriteLine("Aqui está transformado: " + vari);

            //convertendo DE STRINGS para tipo enums

                    //int valorInteiro = 1;
                    //MeuEnum valorEnum = (MeuEnum)Enum.ToObject(typeof(MeuEnum), valorInteiro);

            Estados meuEsta = (Estados)Enum.ToObject(typeof(Estados), 2);
            Console.WriteLine("Veio do Chat: " + meuEsta);




            /*
            Console.WriteLine( "Vamos cadastrar cidades!" );

            Console.Write("Qual o nome da sua Cidade? "  );
            c.Nome = Console.ReadLine();
            Console.Write("Qual a região da sua cidade: ");
            c.Regiao = Console.ReadLine();

            Console.WriteLine( "Qual o desses é a sigla do seu Estado? ");
            Console.WriteLine(  " 0 - Pe\n 1 - Pi\n 3 -Ce ");
           int es = int.Parse( Console.ReadLine());
            if (es == 0)
            {
                 
            }

            Console.WriteLine(c.Estado.ToString());
           

           
            Console.WriteLine(c);*/



        }
    }
}
