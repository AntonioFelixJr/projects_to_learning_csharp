using System;
using System.Globalization;

namespace ProdutoEstoque
{
    class Produto
    {
        private string _nome;
        // Auto properties - Usado quando não tem logica nos getters e setters da propriedade
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {
            Quantidade = 10;
        }

        public Produto(string nome, double preco) : this()
        {
            this._nome = nome;
            this.Preco = preco;
            this.Quantidade = 0;
        }


        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            this._nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        // Properties - Para substituir os Getters e Setters padrões
        public string Nome
        {
            get { return this._nome; }
            set { 
                if (value != null || value.Length > 1)
                {
                    this._nome = value; 
                }
            }
        }

 
        /*
        public string GetNome()
        {
            return this._nome;
        }

        public void SetNome(string nome)
        {
            this._nome = nome;
        }
        */

        public double ValorTotalEmEstoque()
        {
            return this.Preco * this.Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            this.Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            this.Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"{this._nome}, $ {this.Preco.ToString("F2", CultureInfo.InvariantCulture)}, {this.Quantidade} unidades, Total: $ { this.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
