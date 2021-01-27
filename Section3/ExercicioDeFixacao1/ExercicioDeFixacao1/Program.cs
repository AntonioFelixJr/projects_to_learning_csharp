using System;
using System.Globalization;

namespace ExercicioDeFixacao1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeCompleto;
            int qtdQuartos;
            double precoProduto;
            string[] vetor;


            Console.WriteLine("Entre com seu nome completo:");
            nomeCompleto = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            qtdQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");
            vetor = Console.ReadLine().Split(' ');

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(qtdQuartos);
            Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(vetor[0]);
            Console.WriteLine(vetor[1]);
            Console.WriteLine(vetor[2]);
        }
    }
}
