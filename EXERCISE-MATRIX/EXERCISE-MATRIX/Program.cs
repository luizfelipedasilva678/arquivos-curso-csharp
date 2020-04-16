using System;

namespace EXERCISE_MATRIX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número para gerar a matriz quadrada: ");
            int n = int.Parse(Console.ReadLine());
            int negativeNumbers = 0;
            int[,] matriz = new int[n,n];

            
           Console.WriteLine("Digite os números para preencher a matriz: ");
           for(int i = 0; i < matriz.GetLength(0); i++)
           {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
           }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        Console.WriteLine("Diagonal Principal -> " + matriz[i,j]);
                    }

                    if(matriz[i,j] < 0)
                    {
                        negativeNumbers++;
                    }
                }
            }
            Console.WriteLine("Numeros negativos -> " + negativeNumbers);
        }
    }
}
