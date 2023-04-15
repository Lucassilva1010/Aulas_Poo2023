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
            //realizando a Stancia e solicitanto do Usuario
            ContaEmpresarial cP = new ContaEmpresarial();
            Console.Write("Digte qual o valor do LIMITE de Emprestimo?");
            cP.LimitEmprestimo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            //Upcasting

            Conta conta = new Conta(2031, "Lucas",100.00);
            ContaEmpresarial contaEmpresarial = new ContaEmpresarial(3031,"Antonella",300000.00,10.000);
            Poupanca ContaPoupanca = new Poupanca(1031,"Anastacia",20000.00,0.010);

            //Exemplo de um UpCasting

            Conta c2 = contaEmpresarial; //Recebendo dados da SUBClasse
            Conta cc3 = new ContaEmpresarial(1000,"Arlina",3000.000,2000.00);//Recebendo de um novo Objeto da SubClasse
            Conta cp01 = new Poupanca(2000,"Edna",5000.000,0.02);

        }
    } 
}
