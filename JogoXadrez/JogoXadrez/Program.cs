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
                    try {

                        Console.Clear();
                        Tela.ImprimirPartida(partida);
                        

                        Console.Write("Origem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().TrasnformaPosicao();
                        partida.ValidarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.Pecaa(origem).MovimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().TrasnformaPosicao();
                        
                        partida.ValidarPosicaoDestino(origem, destino);
                        partida.RealizaJogada(origem, destino);

                       

                    }catch(TabuleiroExecption ex) { 
                        Console.WriteLine(ex.Message);
                        Console.ReadLine();
                    }
                }




            }
            catch (TabuleiroExecption e)
            {
                Console.WriteLine(e.Message);
            }





        }
    }
}
