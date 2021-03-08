using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product;

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Price = product.Price;
            Quantity = quantity;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return $"{Product.Name}, ${Product.Price.ToString("F2", CultureInfo.InvariantCulture)}" +
                $", Quantity: {Quantity}, Subtotal: ${SubTotal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
