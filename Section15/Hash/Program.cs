using Hash.Entities;
using System;
using System.Collections.Generic;

namespace Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>() { "Maria", "Alex", "Eduardo", "Vitória", "Antônio" };


            Console.WriteLine(set.Contains("Maria"));

            foreach(var i in set)
            {
                Console.WriteLine(i);
            }

            HashSet<Product> hsProduct = new HashSet<Product>();

            hsProduct.Add(new Product("TV", 1999.99));
            hsProduct.Add(new Product("Notebook", 3999.99));
            hsProduct.Add(new Product("Mouse", 40.99));

            HashSet<Point> hsPoint = new HashSet<Point>();
            hsPoint.Add(new Point(2, 4));
            hsPoint.Add(new Point(-2, 0));
            hsPoint.Add(new Point(0, 12));

            Product product = new Product("Notebook", 3999.99);
            Point point = new Point(0, 12);

            Console.WriteLine(hsProduct.Contains(product));
            Console.WriteLine(hsPoint.Contains(point));
        }
    }
}
