using Comparison1.Entities;
using System;
using System.Collections.Generic;

namespace Comparison1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            // Lambda - função anônima
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));
            

            foreach (Product product in list)
            {
                Console.WriteLine(product);
            }
        }
        // Delegate
        // list.Sort(CompareProducts);
        //static int CompareProducts(Product p1, Product p2)
        //{
        //    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        //}
    }
}
