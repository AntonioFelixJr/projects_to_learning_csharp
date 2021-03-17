using System.Globalization;

namespace Exercicio1.Entities
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product (string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public decimal Total()
        {
            return Quantity * Price;
        }

        public string ToCSV(char separator = ',')
        {
            return $"{Name}{separator}{Total().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
