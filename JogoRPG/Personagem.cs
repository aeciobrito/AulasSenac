using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG
{
    abstract class Personagem
    {
        public string Nome { get; set; }
        public int PontosDeVida { get; set; }
        public int Forca { get; set; }
        public int Defesa { get; set; }

        public int Atacar()
        {
            return Forca;
        }

        public void ReceberDano(int danoRecebido)
        {
            PontosDeVida -= danoRecebido;

            if (PontosDeVida <= 0)
            {
                Morrer();
            }
        }

        public void Morrer()
        {
            Console.WriteLine($"{Nome} morreu!");
        }

    }
}
