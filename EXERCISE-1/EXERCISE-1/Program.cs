using System;

namespace EXERCISE_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2;
            double preco2 = 2;
            double media = 4;

            Console.WriteLine("Produtos: ");
            Console.WriteLine("Computador, cujo preço é "+ preco1);
            Console.WriteLine("Mesa de escritório cujo preço é" + preco2);
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine($"Medida com casas decimais: {media}");
            Console.WriteLine($"Arredondado: {media}");
            Console.WriteLine($"Separador com invariant culture: {media}");
        }
    }
}
