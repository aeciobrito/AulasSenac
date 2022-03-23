using System;
using System.Collections.Generic;

namespace CadastroDePessoas
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe a idade: ");
            var idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o peso: ");
            var peso = int.Parse(Console.ReadLine());

            Pessoa novaPessoa = new Pessoa(nome, idade, peso);

            novaPessoa.ExibirDados();
        }
    }
}
