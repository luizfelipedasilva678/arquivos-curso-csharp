using System;
using System.Globalization;

namespace COURSE
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 100;
            bool completo = false;
            char genero = 'F';
            float n5 = 4.5f;
            double n6 = 4.5;
            string maria = "MARIA";
            object obj1 = "Alex Bown";
            
            Console.WriteLine(obj1);
            Console.WriteLine(x);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(maria);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            Console.WriteLine("-------------------------------------");

            int idade = 32;
            double salario = 10.35768;
            string nome = "Maria";
            
            Console.WriteLine("Nome: "+nome+"Salario: "+salario+"Idade: "+idade);
            Console.WriteLine("Nome: ");
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais",nome,idade,salario);
            Console.WriteLine($"{nome} tem {idade} e tem saldo igual a {salario} reais");

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Operações aritméticas");

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            Console.WriteLine(n1);
            Console.WriteLine(n2); ;

        }
    }
}
