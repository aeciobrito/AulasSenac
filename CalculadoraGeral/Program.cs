using System;
using System.Collections.Generic;

namespace CalculadoraGeral
{
    public class Program
    {
        static void Main(string[] args)
        {
            BancoDeDados.AdicionarContato("João");

            Funcionario funcionario1 = new Funcionario();
            funcionario1.BaterOPonto();
        }

        public class Pessoa
        {
            public virtual void BaterOPonto()
            {
                Console.WriteLine($"Horário marcado em {System.DateTime.Now}");
            }
        }

        public class Funcionario : Pessoa
        {

        }

        public class Aluno : Pessoa
        {
            public override void BaterOPonto()
            {
                //antes
                base.BaterOPonto();
                //depois
                Console.WriteLine("Aluno marcou presença");
            }
        }

        public class Calculadora
        {
            public static int numero;

            public static int Soma(int a, int b)
            {
                return a + b;
            }
        }

        public static class BancoDeDados
        {
             static List<string> contatos = new List<string>();

            public static void AdicionarContato(string nome)
            {
                contatos.Add(nome);
            }
        }
    }
}
