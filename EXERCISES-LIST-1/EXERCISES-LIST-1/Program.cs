using System;

namespace EXERCISES_LIST_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Sum of the Numbers--------");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int sum = n1 + n2;

            Console.WriteLine("Resultado: " + sum);

            Console.WriteLine("-------Circle Area----------");

            const float pi = 3.14159f;

            float radius = float.Parse(Console.ReadLine());
            float area =  pi*((float)Math.Pow(radius, 2));

            Console.WriteLine("Área: "+area);

            Console.WriteLine("-----Product Difference-----");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int difference = (a * b - c * d);

            Console.WriteLine("Difference: "+ difference);

            Console.WriteLine("-----Employee Salary-----");

            int code = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            float valueHour = float.Parse(Console.ReadLine());
            float salary = valueHour * hours;

            Console.WriteLine("Number: " + code);
            Console.WriteLine("Salary: " +" U$ "+salary);

            Console.WriteLine("-----Amount payable-----");

            string[] vet  = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(vet[0]);
            int quantity = int.Parse(vet[1]);
            float price = float.Parse(vet[2]);

            string[] vet1 = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(vet1[0]);
            int quantity2 = int.Parse(vet1[1]);
            float price2 = float.Parse(vet1[2]);

            float totalPrice = (price * quantity) + (price2 * quantity2);

            Console.WriteLine("Total Price: "+ totalPrice);

            Console.WriteLine("-----Area of the geometrical forms-----");

            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double number3 = double.Parse(Console.ReadLine());

            double triangle = (number1 * number3) / 2;
            double circle = pi * Math.Pow(number3,2);
            double trapeze = (number1 + number2) * number3 / 2;
            double square = Math.Pow(number2, 2);
            double rectangle = number1 * number2;

            Console.WriteLine("Triangle: "+triangle);
            Console.WriteLine("Circle: "+circle);
            Console.WriteLine("Trapeze: "+trapeze);
            Console.WriteLine("Square: "+square);
            Console.WriteLine("Rectangle: "+rectangle);
        }
    }
}
