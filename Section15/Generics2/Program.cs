using System.Collections.Generic;
using System.Globalization;
using Generics2.Services;
using System;
using Generics2.Entities;

namespace Generics2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                list.Add(new Product(vect[0], decimal.Parse(vect[1], CultureInfo.InvariantCulture)));
            }

            CalculationService cs = new CalculationService();
            Product max = cs.Max(list);

            Console.WriteLine($"Max: {max}");

        }
    }
}
