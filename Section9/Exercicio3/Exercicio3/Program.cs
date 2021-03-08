using Exercicio3.Entities.Enums;
using System.Globalization;
using Exercicio3.Entities;
using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");

            Console.Write("\tName: ");
            string name = Console.ReadLine();

            Console.Write("\tEmail: ");
            string email = Console.ReadLine();

            Console.Write("\tBirth date (DD/MM/YYYY): ");
            string birthDate = Console.ReadLine();

            Client client = new Client()
            {
                Name = name,
                Email = email,
                BirthDate = DateTime.Parse(birthDate)
            };

            Console.WriteLine("\nEnter order data: ");
            
            Console.Write("\tStatus: ");
            string status = Console.ReadLine();

            Console.Write("\nHow many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            Order order = new Order()
            {
                Moment = DateTime.Now,
                Status = Enum.Parse<OrderStatus>(status),
                Client = client
            };

            for (int i = 1;i <= n; i++)
            {
                Console.WriteLine($"\n\tEnter #{i} item data:");

                Console.Write("\tProduct name: ");
                string nameProduct = Console.ReadLine();

                Console.Write("\tProduct price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("\tQuantity: ");
                int quantityProduct = int.Parse(Console.ReadLine());

                order.AddOrderItem(new OrderItem(new Product(nameProduct, priceProduct), quantityProduct));
            }

            Console.WriteLine();

            Console.WriteLine(order);
        }
    }
}
