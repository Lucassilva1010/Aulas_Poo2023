using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_Poo
{
     class ProdutoEncapsuladoAutoPro
    {
        private string _nome;
        public int Quantidade { get; private set; }
        public double Preco { get; private set; }

       
        //Construtores
        public ProdutoEncapsuladoAutoPro()
        {
            Quantidade = 1;
        }

        public ProdutoEncapsuladoAutoPro(string nome, double preco):this() 
        {
            _nome = nome;
            Preco = preco;
        }

        //Propriedades customizadas
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 3)
                {
                    _nome = value;

                }
                else
                {
                    Console.WriteLine("O nome do Produto não corresponde aos parametros do sistema");
                }
            }
        }
        //Metodos
        public void AdicionarProduto(int quant)
        {
            Quantidade +=quant; 
        }
        public void RemoverProdutos(int quant)
        {
            Quantidade -=quant;
        }
        public double SaldoEstoque()
        {
            return Preco * Quantidade;
        }


        //Saida personalizada com o ToString
        public override string ToString()
        {
            return"Produto: "+_nome +
                "Temos " + Quantidade + "no estoque."
                + " e o valor deles são:" + Preco+ " Por unidade"
                +"O seu total investido é de: "+SaldoEstoque().ToString("f2",CultureInfo.InvariantCulture);
        }
    }
}
