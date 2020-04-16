using System;

namespace EXERCISE_ROOMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospede[] quartos = new  Hospede[10];
            Hospede hospede;

            Console.Write("Digite a quantidade de quartos a serem alugados: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------");

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Rent #"+i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------");

                hospede = new Hospede(nome, email, quarto);
                quartos[quarto] = hospede;
            }

            Console.WriteLine("Quartos Ocupados:");
            for(int i = 0; i < quartos.Length; i++)
            {
                if(quartos[i] != null)
                {
                    Console.WriteLine("#" + i + ": " + quartos[i].Nome + ", " + quartos[i].Email);
                }
            }
        }
    }
}
