using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_Poo
{
    public class ProdutoEncapsuladoProperties
    {
        private string _nome;
        private int _quantidade;
        private double _preco;

        public string Nome {
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
       


        //Construtores
        public ProdutoEncapsuladoProperties()
        {
            _quantidade = 1;
        }

        public ProdutoEncapsuladoProperties(string nome, double preco):this() 
        {
            _nome = nome;
            _preco = preco;
        }


        //Metodos
        public void AdicionarProduto(int quant)
        {
            _quantidade +=quant; 
        }
        public void RemoverProdutos(int quant)
        {
            _quantidade -=quant;
        }
        public double SaldoEstoque()
        {
            return _preco * _quantidade;
        }


        //Saida personalizada com o ToString
        public override string ToString()
        {
            return"Produto: "+_nome +
                "Temos " + _quantidade + "no estoque."
                + " e o valor deles são:" + _preco+ " Por unidade"
                +"O seu total investido é de: "+SaldoEstoque().ToString("f2",CultureInfo.InvariantCulture);
        }
    }
}
