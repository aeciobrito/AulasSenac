using System;

/// <summary>
//1 - Criar Classe Personagem
//Propriedades: nome, pontosDeVida, forca, defesa
//Métodos: Atacar(), ReceberDano(), Morrer()

//2 - Criar Classe Guerreiro()
//Propriedades: defesaEscudo
//Métodos: Defender();

//3 - Criar Clase Mago()
//Propriedades: pontosDeMagia
//Métodos: ConjurarMagia();

//3 - Criar Classe Arqueiro()
//Propreidades: totalFlechas
//Métodos: AtacarDistante()
/// </summary>

namespace CadastroEscola
{
    class Program
    {
        static void Main(string[] args)
        {
            var novoProfessor = new Professor();
            var novoAluno = new Aluno();

            novoAluno.Senha = "45678";

            novoProfessor.FazerChamada();
            novoAluno.Login("1234");
        }
    }
}
