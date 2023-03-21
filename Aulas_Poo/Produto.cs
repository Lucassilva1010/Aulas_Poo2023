﻿using Microsoft.SqlServer.Server;
using System;
using System.Globalization;

namespace Aulas_Poo
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public double ValorTotalEstoque()
        {
            return Preco*Quantidade;
        }
              
        public void AdicionarProduto(int quant)
        {
            Quantidade = Quantidade + quant;
        }

        public void Removerprodutos(int quant)
        {
            Quantidade = Quantidade - quant;
        }

        //Sobreporsição
        public override string ToString()
        {
            return Nome
                + ", $"
                + Preco.ToString("f2",CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, total $"
                + ValorTotalEstoque().ToString("f2", CultureInfo.InvariantCulture);
        } 
    }
}
