using System;
using System.Collections.Generic;
using System.Text;

namespace NomeEIdadeDePessoa
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public string NomePessoaMaisVelha (Pessoa pessoa1, Pessoa pessoa2)
        {
            if (pessoa1.Idade > pessoa2.Idade)
            {
                return pessoa1.Nome;
            }

            return pessoa2.Nome;
        }
    }
}
