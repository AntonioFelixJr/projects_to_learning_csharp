using System;


namespace Generics2.Entities
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Product))
                throw new ArgumentException("Comparing error: argumnet is not a Product");

            Product other = obj as Product;

            return Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return $"{Name}, {Price}";
        }
    }
}
