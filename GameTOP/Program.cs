using System;
using GameTOP;
using GameTOP.Lib;
namespace GameTOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(
                new jogador1(),
                new jogador2()
            );
            var teste1 = 100;
            var teste2 = 200;
            Console.Write($"{teste1}teste\n");
            jogo.IniciarJogo();
            Console.Write($"{teste2}teste\n");
        }

    }
}
