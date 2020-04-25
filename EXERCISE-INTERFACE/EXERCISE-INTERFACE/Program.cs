using EXERCISE_INTERFACE.Entities;
using EXERCISE_INTERFACE.Services;
using System;
using System.Globalization;

namespace EXERCISE_INTERFACE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy):");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract Value: ");
            double contractValue = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            Console.WriteLine("------------------------------------");

            Contract contract = new Contract(number, date, contractValue);
            ContractService contractService = new ContractService(new PaypalService());
            contractService.processContract(contract, installments);

            Console.WriteLine("Installments");

            Console.WriteLine(contract);
        }
    }
}
