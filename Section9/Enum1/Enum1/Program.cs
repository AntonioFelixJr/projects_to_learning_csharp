using Enum1.Entities.Enums;
using Enum1.Entities;
using System;

namespace Enum1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 112,
                Moment = DateTime.Now.ToLocalTime(),
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}
