using System.Collections.Generic;
using Exercicio3.Entities.Enums;
using System.Globalization;
using System.Text;
using System;

namespace Exercicio3.Entities
{
    class Order
    {
        public Client Client;
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public void AddOrderItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }

        public void RemoveOrderItem(OrderItem orderItem)
        {
            OrderItems.Remove(orderItem);
        }

        public double Total()
        {
            double total = 0;
            
            foreach (OrderItem orderItem in OrderItems)
            {
                total += orderItem.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status.ToString());
            sb.AppendLine("Client: " + Client.ToString());
            sb.AppendLine("Order items:");

            foreach (OrderItem orderItem in OrderItems)
            {
                sb.AppendLine(orderItem.ToString());
            }

            sb.AppendLine("Total Price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
