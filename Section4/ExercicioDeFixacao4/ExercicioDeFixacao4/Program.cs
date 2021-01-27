using System;
using System.Globalization;

namespace ExercicioDeFixacao4
{
    class Program
    {
        static void Main(string[] args)
        {
            double cotacao, totalDolares;
            Console.Write("Qual é a cotação do dólar? ");
            cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            totalDolares= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Valor a ser pafo em reais = {ConversorDeMoeda.ReaisEmDolares(cotacao, totalDolares).ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
