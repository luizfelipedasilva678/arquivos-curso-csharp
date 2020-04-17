using System;
using System.Collections.Generic;
using System.Text;
using COMPOSITION_EXERCISE.Entities.Enums;

namespace COMPOSITION_EXERCISE.Entities
{
    class Order
    {
        private List<OrderItem> items = new List<OrderItem>();
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        
        public Order()
        {
            Client = new Client();
        }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
            Client = new Client();
        }

        public void addItem(OrderItem item)
        {
            items.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            items.Remove(item);
        }

        public double total()
        {
            double  sum = 0;
            foreach(OrderItem listElem in items)
            {
                sum += listElem.subTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Moment: " + Moment);
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: "+ Client.Name + " ("+Client.BirthDate+") "+ " - " + Client.Email);
            sb.AppendLine("Order Items: ");
            foreach(OrderItem item in items)
            {
                sb.AppendLine(item.Product.Name +", "+ " " + " $" + item.Price+", "+ "Quantity: " + item.Quantity+", "+ "Subtotal: " + item.subTotal()+".");
            }
            sb.AppendLine();
            return sb.ToString();
        }

    }
}
