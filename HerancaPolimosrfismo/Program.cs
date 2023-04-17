using HerancaPolimosrfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimosrfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Conta conta1 = new Conta(1010, "Lucas", 500.00);
            Conta conta2 = new Poupanca(20123, "Antonella", 1000.00, 0.03);
            Conta conta3 = new ContaEmpresarial(030, "Anastacia", 5000.00, 20000.00);
            
            conta1.Saque(100);
            conta2.Saque(150);
            
            conta3.Saque(100);

            Console.WriteLine(conta1.Saldo+" Aqui descontou da Conta Corrente");
            Console.WriteLine(conta2.Saldo+ " Aqui descontou da Conta Pupança");
            Console.WriteLine(conta3.Saldo+"  Aqui descontou da Conta Empresarial");



            //Aula 136

            /*
            //realizando a Stancia e solicitanto do Usuario
            ContaEmpresarial cP = new ContaEmpresarial();
            Console.Write("Digte qual o valor do LIMITE de Emprestimo?");
            cP.LimitEmprestimo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            //Upcasting

            Conta conta = new Conta(2031, "Lucas",100.00);
            ContaEmpresarial contaEmpresarial = new ContaEmpresarial(3031,"Antonella",300000.00,10.000);
            Poupanca ContaPoupanca = new Poupanca(1031,"Anastacia",20000.00,0.010);

            Conta c2 = contaEmpresarial; //Recebendo dados da SUBClasse
            Conta cc3 = new ContaEmpresarial(1000,"Arlina",3000.000,2000.00);//Recebendo de um novo Objeto da SubClasse
            Conta cp01 = new Poupanca(2000,"Edna",5000.000,0.02);

            //Novo tipo de Casting para Utilizar com classes
            Conta cC = cp01 as Conta;// 


            //DowCasting

            ContaEmpresarial cc4 = (ContaEmpresarial)cc3;//Recebendo de uma SubClasse para SubClasse
            Poupanca cc5 = (Poupanca)c2;
            cc4.Emprestimo(50.00);

            if (cc3 is Conta)
            {
                Console.WriteLine("è do Tipo Conta!");
            }
           */
        }
    } 
}
