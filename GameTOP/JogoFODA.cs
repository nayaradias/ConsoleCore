using System;
using GameTop.Interface;
namespace GameTOP
{
   public class JogoFODA
    {
        private readonly Ijogador jogador1;
        private readonly Ijogador jogador2;

        public JogoFODA(Ijogador jogador1,Ijogador jogador2){
            this.jogador1 = jogador1;
            this.jogador2 = jogador2;
        }
        public void IniciarJogo(){
            Console.Write(jogador1.Corre());
            Console.Write(jogador2.Corre());
            Console.Write(jogador1.Chuta());
            Console.Write(jogador2.Chuta());
            Console.Write(jogador1.Passe());
            Console.Write(jogador2.Passe());
        }

    }

}