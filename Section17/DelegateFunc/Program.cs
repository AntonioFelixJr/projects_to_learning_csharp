using System.Collections.Generic;
using DelegateFunc.Entities;
using System.Linq;
using System;

namespace DelegateFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00M));
            list.Add(new Product("Mouse", 50.00M));
            list.Add(new Product("Tablet", 350.50M));
            list.Add(new Product("HD Case", 80.90M));

            // Func<Product, string> funcProd = GetProductNameToUpper;
            Func<Product, string> funcProd = p => p.Name.ToUpper();

            // List<string> result = list.Select(GetProductNameToUpper).ToList();
            // List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            List<string> result = list.Select(funcProd).ToList();

            result.ForEach(p => Console.WriteLine(p));
        }

        static string GetProductNameToUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
