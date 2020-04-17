using System;
namespace COMPOSITION_EXERCISE.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
            Product = new Product();
        }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
            Product = new Product();
        }

        public double subTotal()
        {
            return Price * Quantity;
        }

    }
}
