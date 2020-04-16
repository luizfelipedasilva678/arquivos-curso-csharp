using System;

namespace EXERCISES_LIST_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXERCISE NUMBER ONE");

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
           
            while (x != 0 && y!= 0)
            {
                if (x > 0.0 && y > 0.0)
                {
                    Console.WriteLine("PRIMEIRO");
                }
                else if (x < 0.0 && y > 0.0)
                {
                    Console.WriteLine("SEGUNDO");
                }
                else if (x < 0.0 && y < 0.0)
                {
                    Console.WriteLine("TERCEIRO");
                }
                else
                {
                    Console.WriteLine("QUARTO");
                }
                
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("------------------------------------------------------------------------");

            Console.WriteLine("EXERCISE NUMBER TWO");
            
            Console.Write("Digite o código do combustível ou 4 para encerrar: ");
            int code = int.Parse(Console.ReadLine());
            int alcool = 0;
            int diesel = 0;
            int gasolina = 0;
           
            while (code != 4 || (code<1 && code>4))
            {
                if(code == 1)
                {
                    alcool++;
                }else if(code == 2)
                {
                    diesel++;
                }
                else if(code == 3)
                {
                    gasolina++;
                }

                Console.Write("Digite o código do combustível ou 4 para encerrar: ");
                code = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Álcool: "+alcool);
            Console.WriteLine("Gasolina: "+gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
