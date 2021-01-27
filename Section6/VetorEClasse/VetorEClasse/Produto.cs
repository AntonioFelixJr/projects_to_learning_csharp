using System;
using System.Collections.Generic;
using System.Text;

namespace VetorEClasse
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; private set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
