using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG
{
    class Guerreiro : Personagem
    {
        public int DefesaEscudo { get; private set; }

        public Guerreiro(string nome, int pontosDeVida, int forca, int defesa, int defesaDoEscudo)
            : base(nome, pontosDeVida, forca, defesa)
        {
            DefesaEscudo = defesaDoEscudo;
        }

        public override void ReceberDano(int danoRecebido)
        {
            danoRecebido -= DefesaEscudo;
            base.ReceberDano(danoRecebido);
        }
    }
}
