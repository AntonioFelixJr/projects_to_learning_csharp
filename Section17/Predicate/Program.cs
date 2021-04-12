using Predicate.Entities;
using System;
using System.Collections.Generic;

namespace Predicate
{
    class Program
    {

        //public delegate bool Predicate<in T>(T obj);

        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00M));
            list.Add(new Product("Mouse", 50.00M));
            list.Add(new Product("Tablet", 350.50M));
            list.Add(new Product("HD Case", 80.90M));

            list.RemoveAll(ProductTest);
            // list.RemoveAll(p => p.Price >= 100.00M);

            list.ForEach(p => Console.WriteLine(p));
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.00M;
        }
    }
}
