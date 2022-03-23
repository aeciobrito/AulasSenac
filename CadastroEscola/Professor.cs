using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroEscola
{
    class Professor : Pessoa
    {
        public string Disciplina { get; set; }

        public void FazerChamada()
        {
            Console.WriteLine("Chamada feita com sucesso!");
        }
    }
}
