using System;
using System.Collections.Generic;

namespace EXERCISE_EMPLOYEES
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios func;
            List<Funcionarios> funcionarios = new List<Funcionarios>();

            Console.WriteLine("Quantos funcionários você que registrar: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Salário: ");
                double salario = double.Parse(Console.ReadLine());

                func = new Funcionarios(id, nome, salario);
                funcionarios.Add(func);
            }

            Console.WriteLine("Digite o id do funcionário que receberá o aumento: ");
            int idFunc = int.Parse(Console.ReadLine());
            Console.WriteLine("Porcentagem do aumento: ");
            double porcent = double.Parse(Console.ReadLine());

            Funcionarios func2 = funcionarios.Find(x => x.Id == idFunc);
            func2.Aumento(porcent);
            
            /*
                foreach (Funcionarios employee in funcionarios)
                {
                    if (employee.Id == idFunc)
                    {
                        employee.Aumento(porcent);
                    }
                }
            */

            Console.WriteLine("Lista Atualizada dos Funcionários: ");
            foreach (Funcionarios employee in funcionarios)
            {
                Console.WriteLine(employee.Id+", "+employee.Nome+", "+employee.Salario);
            }

        }
    }
}
