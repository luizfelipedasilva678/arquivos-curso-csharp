using System;
using System.Globalization;

namespace DATA_INPUT
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                string frase = Console.ReadLine();
                Console.WriteLine(frase);

                string num = Console.ReadLine();
            */

            Console.WriteLine("-----------------------");

            Console.Write("Digite seu número aqui: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine(n1);

            string x;
            int y;
            double z;
            char w;

            x = Console.ReadLine();
            y = int.Parse(Console.ReadLine());
            z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            w = char.Parse(Console.ReadLine());

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(w);

            Console.ReadLine();
        }
    }
}

