using System;
using System.Collections.Generic;

namespace CadastroDePessoas
{
    class Program
    {
        static List<Pessoa> bancoDePessoas = new List<Pessoa>();

        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe a idade: ");
            var idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o peso: ");
            var peso = int.Parse(Console.ReadLine());
                        
            CadastrarPessoa(new Pessoa(nome, peso, idade));
        }

        public static void CadastrarPessoa(Pessoa pessoa)
        {
            bancoDePessoas.Add(pessoa);
        }
    }

    class Pessoa
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string CPF { get; private set; }
        public bool Solteiro { get; private set; }
        public double Peso { get; private set; }

        public Pessoa(string nome, int idade, double peso)
        {

        }
    }
}
