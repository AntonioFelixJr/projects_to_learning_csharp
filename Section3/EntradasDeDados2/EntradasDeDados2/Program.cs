using System;
using System.Globalization;

namespace EntradasDeDados2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double db = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Você digitou: {n1} {ch} {db.ToString("F2", CultureInfo.InvariantCulture)}");

            string[] vetor = Console.ReadLine().Split(" ");

            string nome = vetor[0];
            char sexo = char.Parse(vetor[1]);
            int idade = int.Parse(vetor[2]);
            float altura = float.Parse(vetor[3], CultureInfo.InvariantCulture);

            Console.WriteLine($"Nome: {nome}, Sexo: {sexo}, Idade: {idade} anos, Altura: {altura.ToString("F2", CultureInfo.InvariantCulture)}cm");
        }
    }
}
