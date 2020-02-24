using System;
using GameTop.Interface;
namespace GameTOP.Lib
{
    public class jogador2 : Ijogador
    {
        public string Chuta()
        {
            return "Jogador 2: está chutando \n";
        }
        public string Corre()
        {
            return "Jogador 2: está correndo \n";
        }
        public string Passe()
        {
            return "Jogador 2: está passando \n";
        }
    }
}