using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string nameProduct, double priceProduct)
        {
            Name = nameProduct;
            Price = priceProduct;
        }
    }
}
