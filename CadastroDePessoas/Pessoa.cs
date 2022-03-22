﻿namespace CadastroDePessoas
{
    class Pessoa
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string CPF { get; private set; }
        public bool Solteiro { get; private set; }
        public double Peso { get; private set; }

        public Pessoa(string nome, int idade, double peso)
        {
            Nome = nome;
            Idade = idade;
            Peso = peso;
        }

        public Pessoa(string nome, int idade, double peso, string cpf)
        {
            Nome = nome;
            Idade = idade;
            Peso = peso;
            CPF = cpf;
        }
    }
}
