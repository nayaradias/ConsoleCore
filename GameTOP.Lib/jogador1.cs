using System;
using GameTop.Interface;
namespace GameTOP.Lib
{
    public class jogador1 : Ijogador
    {
        public string Chuta()
        {
            return "Jogador 1: está chutando \n";
        }
        public string Corre()
        {
            return "Jogador 1: está correndo \n";
        }
        public string Passe()
        {
            return "Jogador 1: está passando \n";
        }
    }
}