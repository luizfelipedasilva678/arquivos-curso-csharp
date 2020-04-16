using System;

namespace EXERCISE_MATRIX_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite M e N: ");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[m, n];
            
            Console.WriteLine("Digite o um número: ");
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i,j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Digite o número que você quer encontrar: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if(number == mat[i, j])
                    {
                        Console.WriteLine("Position: ");
                        if(j > 0)
                        {
                            Console.WriteLine("Left: "+ mat[i,j-1]);
                        }

                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i-1, j]);
                        }

                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }

        }
    }
}
