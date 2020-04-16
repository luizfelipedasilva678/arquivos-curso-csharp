using System;

namespace EXERCISES_LIST_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise number one");

            int n = int.Parse(Console.ReadLine());

            if(n >= 0)
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }

            Console.WriteLine("Exercise number two");

            int n1 = int.Parse(Console.ReadLine());

            if (n1 % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Ímpar");
            }

            Console.WriteLine("Exercise number three");

            string[] vet = Console.ReadLine().Split(' ');
            int n3 = int.Parse(vet[0]);
            int n4 = int.Parse(vet[1]);
            int maior = 0;
            int menor = 0;

            if (n4 > n3)
            {
                maior = n4;
                menor = n3;
            }
            else
            {
                maior = n3;
                menor = n4;
            }

            if (maior % menor == 0)
            {
                Console.WriteLine("São múltiplos");
            }
            else
            {
                Console.WriteLine("Não são múltiplos");
            }

            Console.WriteLine("Exercise number four");

            string[] vet2 = Console.ReadLine().Split(' ');
            int initialHour = int.Parse(vet2[0]);
            int finalHour   = int.Parse(vet2[1]);
            int duracao;

            duracao = 24 - initialHour + finalHour;
            if (duracao > 1)
            {
                Console.WriteLine("O jogo durou "+duracao+" horas ");
            }

            Console.WriteLine("Exercise number five");

            double value = double.Parse(Console.ReadLine());
            
            if(value < 0 || value>100)
            {
                Console.WriteLine("Fora do Intervalo");
            }
            else if(value <= 25)
            {
                Console.WriteLine("Intervalo[0,25]");
            }else if (value <= 50)
            {
                Console.WriteLine("Intervalo[25,50]");
            }else if(value <= 75){
                Console.WriteLine("Intervalo[50,75]");
            }else if (value<=100)
            {
                Console.WriteLine("Intervalo[75,100]");
            }

            Console.WriteLine("Exercise number six");

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if (x == 0 && y == 0){
                Console.WriteLine("Origem");
            }
            else if(x>0 && y>0)
            {
                Console.WriteLine("Q1");
            }else if(x<0 && y>0)
            {
                Console.WriteLine("Q2");
            }else if (x>0 && y<0)
            {
                Console.WriteLine("Q4");
            }
            else
            {
                Console.WriteLine("Q3");
            }



        }
    }
}
