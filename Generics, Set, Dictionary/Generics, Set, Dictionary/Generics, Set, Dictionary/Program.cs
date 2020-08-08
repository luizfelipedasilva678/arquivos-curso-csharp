using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;

namespace Generics__Set__Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
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
            */

            string path = @"C:\tmp\in.txt";
            string[] lines;
            Dictionary<string, int> candidates = new Dictionary<string, int>();
            int sum = 0;
            int sum2 = 0;
            int sum3 = 0;

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                         lines  = sr.ReadLine().Split(',');
                         if(lines[0] == "Alex Blue")
                         {
                            sum += int.Parse(lines[1]);
                            candidates["Alex Blue"] = sum;
                         }
                         else if(lines[0] == "Maria Green")
                         {
                            sum2 += int.Parse(lines[1]);
                            candidates["Maria Green"] = sum2;
                         }
                         else
                         {
                            sum3 += int.Parse(lines[1]);
                            candidates["Bob Brown"] = sum3;
                         }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
            
            foreach(KeyValuePair<string, int> candidate in candidates)
            {
                Console.WriteLine(candidate.Key + ": " + candidate.Value);
            }
        }
    }
}
