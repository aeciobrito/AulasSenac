using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroEscola
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }

        public bool Login(string senha)
        {
            if (senha == Senha)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
