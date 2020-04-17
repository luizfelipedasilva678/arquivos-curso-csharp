using System;
using COMPOSITION_EXERCISE.Entities;
using COMPOSITION_EXERCISE.Entities.Enums;
using System.Globalization;

namespace COMPOSITION_EXERCISE
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            Console.WriteLine("------------------------------------------");
            
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (MM/DD/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            
            order.Client.Name = name;
            order.Client.Email = email;
            order.Client.BirthDate = birthDate;
            
            Console.WriteLine("------------------------------------------");
            
            Console.WriteLine("Enter Order Data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order: ");
            int itemsOrder = int.Parse(Console.ReadLine());

            order.Moment = DateTime.Now;
            order.Status = status;
            
            Console.WriteLine("------------------------------------------");

            for(int i = 0; i < itemsOrder; i++)
            {
                Console.WriteLine($"Enter #{i+1} item data: ");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                
                OrderItem orderItem = new OrderItem(quantity,productPrice);
                orderItem.Product.Name = productName;
                orderItem.Product.Price = productPrice;
                order.addItem(orderItem);
            }

            Console.WriteLine("Order Summary: ");
            Console.WriteLine(order);
            Console.WriteLine("Total Price: " + order.total());
        }
    }
}
