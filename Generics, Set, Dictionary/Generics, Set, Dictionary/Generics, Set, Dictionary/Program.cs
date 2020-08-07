using System;
using System.Linq;



namespace Generics__Set__Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<string> nums = new PrintService<string>();
            
            Console.WriteLine("How many values ? ");
            int qtd = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for(int i = 0; i< qtd; i++)
            {
                //int num = int.Parse(Console.ReadLine());
                string nome = Console.ReadLine();
                nums.addValue(nome);
            }

            nums.print();
            Console.WriteLine();
            Console.WriteLine("First: " + nums.first()); 
             
        }
    }
}
