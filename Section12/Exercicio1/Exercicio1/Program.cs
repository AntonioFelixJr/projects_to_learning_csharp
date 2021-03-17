using Exercicio1.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\wamp64\www\dev\projects_to_learning_csharp\Section12\Exercicio1\Exercicio1\Resources\products.csv";
            string targetPath = @"C:\wamp64\www\dev\projects_to_learning_csharp\Section12\Exercicio1\Exercicio1\Resources\out\summary.csv";

            List<Product> products = new List<Product>();

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                Console.WriteLine("Read start");


                foreach (string line in lines)
                {
                    string[] items = line.Split(",");
                    string name = items[0];
                    decimal price = decimal.Parse(items[1], CultureInfo.InvariantCulture);
                    int quantity = int.Parse(items[2]);

                    products.Add(new Product(name, price, quantity));
                }

                Console.WriteLine("Read complete");

                if (!Directory.Exists(Path.GetDirectoryName(targetPath)))
                {
                    Console.WriteLine($"Create directory: {Path.GetDirectoryName(targetPath)}");
                    Directory.CreateDirectory(Path.GetDirectoryName(targetPath));
                }

                using (StreamWriter sr = File.CreateText(targetPath))
                {
                    Console.WriteLine("Write start");

                    foreach (Product product in products)
                    {
                        sr.WriteLine(product.ToCSV(','));
                    }
                    Console.WriteLine("Write complete");
                }

            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
