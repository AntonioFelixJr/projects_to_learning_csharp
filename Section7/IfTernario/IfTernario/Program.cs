using System;
using System.Globalization;

namespace IfTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto;

            desconto = valor < 20.0 ? valor * 0.1: valor * 0.05;

            Console.WriteLine($"Total de desconto: {desconto.ToString("F2", CultureInfo.InvariantCulture)}");
            
        }
    }
}
