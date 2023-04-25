using System;
using Tabuleiro;
using Xadrez;

namespace JogoXadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiroo tabuleiro = new Tabuleiroo(8, 8);

                PosicaXadrez pos = new PosicaXadrez('c',7);
                Console.WriteLine(pos);

                Console.WriteLine(pos.TrasnformaPosicao());

            }
            catch (TabuleiroExecption e)
            {
                Console.WriteLine(e.Message);
            }
       
           

           
           
        }
    }
}
 