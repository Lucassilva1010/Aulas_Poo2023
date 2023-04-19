using SaqueException.Entities;
using SaqueException.Entities.MinhasExceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaqueException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Dados da Conta");

                Console.Write("Numero da Conta: ");
                int conta = int.Parse(Console.ReadLine());
                Console.Write("Titular: ");
                string titualar = Console.ReadLine();
                Console.WriteLine("Limite de Saque: ");
                double limiteSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                Conta conta1 = new Conta(conta, titualar, limiteSaque);

                Console.WriteLine("O que deseja Realizar?\n" +
                    "Deposito(d) - Saque(s)\n");
                string opc = Console.ReadLine();


                if (opc.ToLower() is "d")
                {

                    Console.Write("Digite o valor para ser depositado: ");
                    double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta1.Deposito(valorDeposito);
                    Console.WriteLine(conta1);

                }
                else
                {

                    Console.Write("Valor do Saque: ");
                    double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    conta1.Saque(valorSaque);
                    Console.WriteLine(conta1);

                }
            }
            catch (DominioException e)
            {

                Console.WriteLine($"Erro: {e.Message}");
            }catch (FormatException e) {

                Console.WriteLine($"Erro: O formato do dado digitado é incoerente.{e.Message}");

            }
            finally { 
                Console.WriteLine("Obrigado por Usar o Nosso sistema!"); 
            }


        }
    }
}
