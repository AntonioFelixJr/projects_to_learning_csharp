using System;
using System.Globalization;

namespace VetorEClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalProdutos = 0;

            totalProdutos = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[totalProdutos];

            for (int i = 0; i < totalProdutos; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                produtos[i] = new Produto(nome, preco);
            }

            double soma = 0.0;

            for (int i = 0; i < produtos.Length; i++)
            {
                soma += produtos[i].Preco;
            }

            double media = soma / produtos.Length;

            Console.WriteLine($"AVERAGE PRICE: {media.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
