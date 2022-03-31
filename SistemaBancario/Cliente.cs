using System;

namespace SistemaBancario
{
    public class Cliente
    {
        private static int _contador = 0;
        public Cliente(string nome, DateTime nascimento, string cpf)
        {
            Nome = nome;
            Nascimento = nascimento;
            Cpf = cpf;
            _contador++;
            Codigo = _contador;
        }

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public Endereco Endereco { get; set; }
    }
}
