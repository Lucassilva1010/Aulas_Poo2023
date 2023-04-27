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

                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab);
                    Console.WriteLine();

                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().TrasnformaPosicao();

                    bool[,] posicoesPossiveis = partida.tab.Pecaa(origem).MovimentosPossiveis();
                    
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab, posicoesPossiveis);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().TrasnformaPosicao();
                    partida.ExecutaMovimento(origem, destino);
                }




            }
            catch (TabuleiroExecption e)
            {
                Console.WriteLine(e.Message);
            }





        }
    }
}
