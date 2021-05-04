using System.Collections.Generic;
using System.Globalization;
using Exercicio1.Entities;
using System.Linq;
using System.IO;
using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\Products.csv";

            List<Product> products = new List<Product>();

            string delimiter = ",";

            Console.WriteLine($"Read {path}");

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            string[] product = line.Split(delimiter);
                            string name = product[0];
                            decimal price = decimal.Parse(product[1], CultureInfo.InvariantCulture);

                            products.Add(new Product(name, price));
                        }
                    }
                }

                decimal avg =
                    (from p in products select p.Price).DefaultIfEmpty(0.0M).Average();

                Console.WriteLine($"Average price: {avg.ToString("F2", CultureInfo.InvariantCulture)}");

                var showProducts =
                    from p in products
                    where p.Price < avg
                    orderby p.Name descending
                    select p.Name;

                foreach (var product in showProducts)
                {
                    Console.WriteLine(product);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error in read file: " + e.Message);
            }

        }
    }
}
