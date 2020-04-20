using System;
using System.Collections.Generic;
using EXERCISE_ABSTRACT_CLASS.Entities;

namespace EXERCISE_ABSTRACT_CLASS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            TaxPayer payer;
            Console.Write("Enter the numbers of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.WriteLine("Individual or Company(i/c) ?");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIcome = double.Parse(Console.ReadLine());

                if(c == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    payer = new Individual(name, anualIcome, healthExpenditures);
                }
                else
                {
                    Console.Write("Numbe of Employees: ");
                    int numbersOfEmployees = int.Parse(Console.ReadLine());
                    payer = new Company(name, anualIcome, numbersOfEmployees);
                }

                list.Add(payer);
            }

            double sum = 0;
            Console.WriteLine("Taxes Paid: ");
            foreach(TaxPayer elem in list)
            {
                Console.WriteLine(elem.Name+":"+" "+elem.tax());
                sum += elem.tax();
            }
            Console.WriteLine("Total Tax: " + sum);
        }
    }
}
