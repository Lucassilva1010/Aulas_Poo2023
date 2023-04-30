using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;
using Xadrez;

namespace JogoXadrez
{
    internal class Tela
    {
        public static void ImprimirPartida(PartidaDeXadrez partida)
        {
            ImprimirTabuleiro(partida.tab);
            Console.WriteLine();
            ImprimirPecasCapturadas(partida);
            Console.WriteLine();
            Console.WriteLine($"Turno: {partida.Turno}");
            if (!partida.Terminada)
            {

                Console.WriteLine($"Aguardando jogadoa: {partida.JogadorAtual}");
                if (partida.Xeque)
                {
                    Console.WriteLine("Você está em XEQUE!");
                }
            }
            else {
                Console.WriteLine("XEQUEMATE!");
                Console.WriteLine($"O vencedor é: {partida.JogadorAtual}");
            }

        } 
        public static void ImprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            
            Console.WriteLine($"Peças Capturadas: ");
            Console.Write($"Brancas: ");
            ImprimirConjunto(partida.PecasCapturadas(Cor.Branca));
            Console.WriteLine();

            Console.Write($"Pretas: ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            ImprimirConjunto(partida.PecasCapturadas(Cor.Preta));
            Console.ForegroundColor = aux;
        }

        public static void ImprimirConjunto(HashSet<Peca> conjunto)
        {
            
            Console.Write($"[");
            foreach (Peca x in conjunto) {
                Console.Write($"{x} ");
            }
            Console.Write($"]");
            Console.WriteLine();
        }


        public static void ImprimirTabuleiro(Tabuleiroo tabuleiro)
        {
            
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                Console.Write($"{8 - i} ");
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    
                    ImprimirPeca(tabuleiro.Pecaa(i,j));

                }
                Console.WriteLine();
            }
            Console.WriteLine($"  A B C D E F G H");
            
        }
        public static void ImprimirTabuleiro(Tabuleiroo tabuleiro, bool[,] posicoesPossiveis)
        {

            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.Blue;

            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                Console.Write($"{8 - i} ");
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if (posicoesPossiveis[i,j] )
                    {
                        Console.BackgroundColor = fundoAlterado;

                    }else{   
                        
                        Console.BackgroundColor = fundoOriginal;
                    }

                    ImprimirPeca(tabuleiro.Pecaa(i, j));
                    Console.BackgroundColor = fundoOriginal;

                }
                Console.WriteLine();
            }
            Console.WriteLine($"  A B C D E F G H");
            Console.BackgroundColor = fundoOriginal;

        }

        public static PosicaXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaXadrez(coluna, linha);
        }

        public static void ImprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.Cor == Cor.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;//pegando a cor do sistema
                    Console.ForegroundColor = ConsoleColor.Yellow; //mudando a cor para Amarelo
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }
    }
}
