using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;

namespace JogoXadrez
{
    internal class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiroo tabuleiro)
        {
            for (int i = 0; i <tabuleiro.Linhas; i++)
            {
                for(int j = 0; j <tabuleiro.Colunas; j++)
                {
                    if (tabuleiro.Pecaa(i,j)==null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                    Console.Write(tabuleiro.Pecaa(i,j) +" ");

                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
