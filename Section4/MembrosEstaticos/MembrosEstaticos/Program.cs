﻿using System;
using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio;

            Console.Write("Entre o valor do raio: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Circunferência: {Calculadora.Circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {Calculadora.Volume(raio).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
