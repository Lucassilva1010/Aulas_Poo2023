namespace HerancaPolimosrfismo.Entities
{
    internal class ContaEmpresarial : Conta
    {
        public double LimitEmprestimo { get; set; }

        public ContaEmpresarial()
        {

        }

        //uso de reaproveitamento com o BASE - da classe Herdada
        public ContaEmpresarial(int numero, string titular, double saldo, double limitEmprestimo) : base(numero, titular, saldo)
        {
            LimitEmprestimo = limitEmprestimo;
        }

        //Esse Construtor tem o mesmo efeito do de cima, mas sem o uso de REAPROVEITAMENTO DE CODIGO COM BASE
        /* public ContaEmpresarial(int numero, string titular, double saldo, double limitEmprestimo) 
         {
             Numero = numero;
             Titular = titular;
             Saldo = saldo;
             LimitEmprestimo = limitEmprestimo;
         }*/

        public void Emprestimo(double quantia)
        {
            if (quantia <= LimitEmprestimo)
            {
                Saldo = Saldo + quantia - 10.0;
            }
        }
    }
}
