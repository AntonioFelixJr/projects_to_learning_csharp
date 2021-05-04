using System.Collections.Generic;
using Linq2.Entities;
using System.Linq;
using System;
using System.Globalization;

namespace Linq2
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> colletions)
        {
            Console.WriteLine(message);
            foreach(T obj in colletions)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            var rs1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.00);
            var rs1sql = 
                from p in products 
                where p.Category.Tier == 1 && p.Price < 900.00
                select p;
            Print("TIER 1 AND PRICE < 900: ", rs1);
            Print("SQL LIKE: TIER 1 AND PRICE < 900: ", rs1sql);

            var rs2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            var rs2sql = 
                from p in products
                where p.Category.Name == "Tools"
                select p.Name;

            Print("NAMES OF PRODUCTS FROM TOOLS", rs2);
            Print("SQL LIKE: NAMES OF PRODUCTS FROM TOOLS", rs2sql);

            var rs3 = products.Where(p => p.Name.StartsWith("c", true, CultureInfo.InvariantCulture)).Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            var rs3sql =
                from p in products
                where p.Name.StartsWith("c", StringComparison.InvariantCultureIgnoreCase)
                select new { 
                    p.Name, 
                    p.Price, 
                    CategoryName = p.Category.Name 
                };

            Print("PRODUCTS STARTING WITH 'C'", rs3);
            Print("SQL LIKE:PRODUCTS STARTING WITH 'C'", rs3sql);

            var rs4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var rs4sql =
                from p in products
                where p.Category.Tier == 1
                orderby p.Name ascending
                orderby p.Price ascending
                select p;

            Print("TIER 1 ORDER BY PER PRICE THEN BY NAME", rs4);
            Print("SQL LIKE: TIER 1 ORDER BY PER PRICE THEN BY NAME", rs4sql);

            var rs5 = rs4.Skip(2).Take(4);
            var rs5sql =
                (from p in rs4
                    select p).Skip(2).Take(4);
            Print("TIER 1 ORDER BY PER PRICE THEN BY NAME, SKIP 2 TAKE 4", rs5);
            Print("SQL LIKE: TIER 1 ORDER BY PER PRICE THEN BY NAME, SKIP 2 TAKE 4", rs5sql);

            var rs6 = products.First();
            Console.WriteLine($"First teste1: {rs6}\n");

            var rs7 = products.Where(p => p.Price > 3000.00).FirstOrDefault();
            Console.WriteLine($"FirstOrDefault teste1: {rs7}\n");

            var rs8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine($"SingleOrDefault teste1: {rs8}");

            var rs9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine($"SingleOrDefault teste2: {rs9}\n");

            var rs10 = products.Max(p => p.Price);
            Console.WriteLine($"Max: {rs10.ToString("F2", CultureInfo.InvariantCulture)}");

            var rs11 = products.Min(p => p.Price);
            Console.WriteLine($"Min: {rs11.ToString("F2", CultureInfo.InvariantCulture)}");

            var rs12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine($"Category 1 Sum Price: {rs12.ToString("F2", CultureInfo.InvariantCulture)}");

            var rs13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine($"Category 1 Average Price: {rs13.ToString("F2", CultureInfo.InvariantCulture)}");

            var rs14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine($"Category 5 DefaultIfEmpty Average Price: {rs14.ToString("F2", CultureInfo.InvariantCulture)}");

            var rs15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine($"Category 1 Aggregate(Reduce) Price: {rs15.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("\nGroupBy:\n");

            var rs16 = products.GroupBy(p => p.Category);
            var rs16sql = 
                from p in products
                group p by p.Category;
            foreach (IGrouping<Category, Product> group in rs16)
            {
                Console.WriteLine($"Category: {group.Key.Name}");
                foreach (Product product in group)
                {
                    Console.WriteLine(product);
                }
                Console.WriteLine();
            }

            foreach (IGrouping<Category, Product> group in rs16sql)
            {
                Console.WriteLine($"SQL LIKE: Category: {group.Key.Name}");
                foreach (Product product in group)
                {
                    Console.WriteLine(product);
                }
                Console.WriteLine();
            }
        }
    }
}
