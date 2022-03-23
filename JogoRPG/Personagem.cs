using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG
{

    /*
     * Propriedades: nome, pontosDeVida, forca, defesa
        Métodos: Atacar(), ReceberDano(), Morrer()*/
    abstract class Personagem
    {
        public string Nome { get; set; }
        public int PontosDeVida { get; set; }
        public int Forca { get; set; }
        public int Defesa { get; set; }

        public void Atacar()
        {

        }

        public void ReceberDano()
        {
            
        }

        public void Morrer()
        {

        }

    }
}
