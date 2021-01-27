using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            sbyte n1 = 127;
            byte n2 = 255;
            int n3 = 214578489;
            long n4 = 2145784812319L;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

            Console.WriteLine(byte.MinValue + " - " + byte.MaxValue);
            */

            string nome = "Antônio Felix";
            byte idade = 24;
            float saldo = 100.2578f;

            string saldoSaida = saldo.ToString("F2", CultureInfo.InvariantCulture);

            // Placeholder
            Console.WriteLine("{0} tem {1} anos e tem o saldo igual a {2:F2} reais.", nome, idade, saldoSaida);

            // Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem o saldo igual a {saldoSaida} reais.");

            // Concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem o saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais.");
        }
    }
} 
