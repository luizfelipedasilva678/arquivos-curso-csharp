using System;

namespace EXERCISES_LIST_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXERCISE NUMBER ONE");
            Console.Write("DIGITE O NÚMERO: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------");
            
            for(int i = 1; i < x; i++)
            {
                if(i%2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("EXERCISE NUMBER TWO");
            int n = int.Parse(Console.ReadLine());

            for(int k = 0;k < n ; k++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                double n1 = double.Parse(vetor[0]);
                double n2 = double.Parse(vetor[1]);
                double n3 = double.Parse(vetor[2]);

                double media = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10;
                Console.WriteLine("MEDIA: "+media);
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("EXERCISE NUMBER THREE");
            int number = int.Parse(Console.ReadLine());
            
            for(int j = 0; j < number; j++)
            {
                double n1 = double.Parse(Console.ReadLine());
                double n2 = double.Parse(Console.ReadLine());

                if(n2 == 0)
                {
                    Console.WriteLine("Ímpossível dividir por zero");
                }
                else
                {
                    Console.WriteLine("RESULTADO -> "+(n1/n2));
                }
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("EXERCISE NUMBER FOUR");
            double n5 = double.Parse(Console.ReadLine());
            double fatorial = n5;

            for(double l = (n5-1);l != 0; l--)
            {
                fatorial *= l;    
            }
            Console.WriteLine("REASULTADO -> " + fatorial);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("EXERCISE NUMBER FIVE");
            int num = int.Parse(Console.ReadLine());

            for(int m = 1; m <= num; m++)
            {
                if (num % m == 0)
                {
                    Console.WriteLine(m);
                }
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("EXERCISE NUMBER SIX");
            int n10 = int.Parse(Console.ReadLine());

            for (int p = 1; p <= n10; p++)
            {

                int primeiro = p;
                int segundo = p * p;
                int terceiro = p * p * p;
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            }



        }
    }
}
