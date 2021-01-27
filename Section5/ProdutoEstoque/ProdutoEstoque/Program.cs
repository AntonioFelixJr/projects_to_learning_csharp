using System;
using System.Globalization;

namespace ProdutoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double preco;
            int quantidade;

            Console.WriteLine("Entre os dados do produto:");

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Preço: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto produto = new Produto(nome, preco, quantidade);

            Produto produto2 = new Produto(nome, preco);

            /*
            Produto produto3 = new Produto {
                Nome = "TV",
                Preco = 500.00,
                Quantidade = 20
            };
            */
            Console.WriteLine($"\nDados do produto: {produto}");

            Console.Write("\nDigite o número de produtos a ser adicionado ao estoque: ");
            produto.AdicionarProdutos(int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine($"\nDados atualizados: {produto}");

            Console.Write("\nDigite o número de produtos a ser removido do estoque: ");
            produto.RemoverProdutos(int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine($"\nDados atualizados: {produto}");


        }
    }
}
