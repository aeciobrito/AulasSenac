using System;

namespace JogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {            
            Guerreiro guerreiro1 = new Guerreiro();
            guerreiro1.Nome = "Aragorn";
            guerreiro1.Forca = 10;
            guerreiro1.Defesa = 40;
            guerreiro1.DefesaEscudo = 10;
            guerreiro1.PontosDeVida = 100;

            Mago mago1 = new Mago();
        }
    }
}
