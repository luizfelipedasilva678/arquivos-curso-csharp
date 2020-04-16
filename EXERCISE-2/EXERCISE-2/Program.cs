using System;

namespace EXERCISE_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("---------------------");

            Console.Write("Quantos quartos você tem na sua casa: ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("---------------------");

            Console.Write("Entre com o preço de um produto: ");
            float preco = float.Parse(Console.ReadLine());

            Console.WriteLine("---------------------");

            Console.Write("Entre seu último nome, idade e altura: ");
            string[] informacoes = Console.ReadLine().Split(' ');
            string ultimoNome = informacoes[0];
            int idade = int.Parse(informacoes[1]);
            float altura = float.Parse(informacoes[2]);

            Console.WriteLine("---------------------");

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}
