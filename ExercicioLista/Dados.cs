using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLista
{
    public class Dados
    {
        public int ID { get; set; }
        public string  Nome { get; set; }
        public double Salario { get; set; }

        Random numeroAle = new Random();

        public int GeraId()
        {
            return numeroAle.Next(1,4);
        }

        public Dados()
        {
            ID = GeraId();
        }
        public void Aumento(double sal, string nome)
        {
            Salario = sal;
            Nome = nome;
           
            if(ID.Equals(ID))
            {
                Console.WriteLine("Aumento concedido pra você: "+nome);
                sal += (Salario * 0.05);
                Console.WriteLine($"Seu novo salario é de: {sal}");
                
            }else if (ID!= ID)
            {
                Console.WriteLine("Não possui aumento");
            }
        }

      
        public override string ToString()
        {
            return "O ID: " + ID
                + " Nome: "+Nome
                +" Salario: "+Salario.ToString("f2",CultureInfo.InvariantCulture);
        }


    }
}
