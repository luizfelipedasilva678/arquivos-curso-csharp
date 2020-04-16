using System;
using System.Collections.Generic;

namespace HASHSET_EXERCISE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            HashSet<int> cursoA = new HashSet<int>();
            HashSet<int> cursoB = new HashSet<int>();
            HashSet<int> cursoC = new HashSet<int>();
            

            Console.WriteLine("Dite quantos alunos o curso A tem: ");
            int numAlunosCursoA = int.Parse(Console.ReadLine());
            int codsAlunosCursoA = 0;

            Console.WriteLine("Digite os códigos dos alunos do curso A: ");
            for(int i = 0; i < numAlunosCursoA; i++)
            {
                codsAlunosCursoA = int.Parse(Console.ReadLine());
                cursoA.Add(codsAlunosCursoA);
            }

            Console.WriteLine("Dite quantos alunos o curso B tem: ");
            int numAlunosCursoB = int.Parse(Console.ReadLine());
            int codsAlunosCursoB = 0;

            Console.WriteLine("Digite os códigos dos alunos do curso B: ");
            for (int i = 0; i < numAlunosCursoB; i++)
            {
                codsAlunosCursoB = int.Parse(Console.ReadLine());
                cursoB.Add(codsAlunosCursoB);
            }

            Console.WriteLine("Dite quantos alunos o curso C tem: ");
            int numAlunosCursoC = int.Parse(Console.ReadLine());
            int codsAlunosCursoC = 0;

            Console.WriteLine("Digite os códigos dos alunos do curso C: ");
            for (int i = 0; i < numAlunosCursoC; i++)
            {
                codsAlunosCursoC = int.Parse(Console.ReadLine());
                cursoC.Add(codsAlunosCursoC);
            }
            Console.WriteLine("---------------------------------------");
            cursoA.UnionWith(cursoB);
            cursoA.UnionWith(cursoC);

            Console.WriteLine("Total de alunos: " + cursoA.Count);
        }
    }
}
