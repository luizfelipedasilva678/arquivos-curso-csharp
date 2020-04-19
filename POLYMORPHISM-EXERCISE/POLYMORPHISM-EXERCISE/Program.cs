using System;
using System.Collections.Generic;
using POLYMORPHISM_EXERCISE.Entities;

namespace POLYMORPHISM_EXERCISE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of the products: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> list = new List<Product>();
            Product prod;
            
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i) ?");
                char l = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (l == 'c')
                {
                    prod = new Product(name, price);
                }else if(l == 'u')
                {
                    Console.Write("Manufacture date (MM/DD/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    prod = new UsedProduct(name, price, date);
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine());
                    prod = new ImportedProduct(name, price, fee);
                }

                list.Add(prod);
            }

            Console.WriteLine("Price TAG: ");
            foreach(Product elem in list)
            {
                Console.WriteLine(elem.priceTag());
            }
        }
    }
}
