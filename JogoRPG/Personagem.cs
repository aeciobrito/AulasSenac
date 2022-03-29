using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG
{
    abstract class Personagem
    {
        protected Personagem(string nome, int pontosDeVida, int forca, int defesa)
        {
            Nome = nome;
            PontosDeVida = pontosDeVida;
            Forca = forca;
            Defesa = defesa ;
            EstaVivo = true;
        }

        public string Nome { get; private set; }
        public int PontosDeVida { get; private set; }
        public int Forca { get; private set; }
        public int Defesa { get; private set; }
        public bool EstaVivo { get; private set; }

        public int Atacar()
        {
            return Forca;
        }

        public virtual void ReceberDano(int danoRecebido)
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
