using System;
using Tabuleiro;

namespace JogoXadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Tabuleiroo tabuleiro = new Tabuleiroo(8,8);
            Tela.ImprimirTabuleiro(tabuleiro);

           
        }
    }
}
 