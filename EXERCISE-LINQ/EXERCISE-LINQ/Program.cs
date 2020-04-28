using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using EXERCISE_LINQ.Entities;

namespace EXERCISE_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file path: ");
            string path = Console.ReadLine();
            List<Emplyee> employees = new List<Emplyee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] employee = sr.ReadLine().Split(',');
                        string nome = employee[0];
                        string email = employee[1];
                        double salary = double.Parse(employee[2]);
                        employees.Add(new Emplyee(nome, salary, email));
                    }
                }
            }catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Enter salary: ");
            double sa = double.Parse(Console.ReadLine());
            var ee = employees.Where(e => e.Salary > sa).Select(e => e.Email);
            foreach (string item in ee)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Sum: ");
            var sumSalary = employees.Where(e => e.Name[0] == 'M').Select(e => e.Salary).Sum();
            Console.Write(sumSalary);

        }
    }
}
