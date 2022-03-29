using System;

namespace JogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {            
            Guerreiro guerreiro1 = new Guerreiro("Aragorn", 100, 10, 40, 5);
            Mago mago1 = new Mago("Gendalf", 100, 10, 40);

            Console.WriteLine($"{guerreiro1.Nome} atacou com {guerreiro1.Atacar()}");
            guerreiro1.ReceberDano(20);
            Console.WriteLine($"{guerreiro1.Nome} apanhou e ficou com {guerreiro1.PontosDeVida}");

            Console.WriteLine("-----------------------------------");

            Console.WriteLine($"{mago1.Nome} atacou com {mago1.Atacar()}");
            mago1.ReceberDano(20);
            Console.WriteLine($"{mago1.Nome} apanhou e ficou com {mago1.PontosDeVida}");
        }
    }
}
