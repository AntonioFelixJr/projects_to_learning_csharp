using System.Collections.Generic;
using Action.Entities;
using System;

namespace Action
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

            //list.ForEach(UpdatePrice);

            //Action<Product> act = UpdatePrice;
            Action<Product> act = p => { p.Price += p.Price * 0.1M; };

            // list.ForEach(act);
            list.ForEach(p => { p.Price += p.Price * 0.1M; });

            list.ForEach(p => Console.WriteLine(p));
        }

        public static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1M;
        }
    }
}
