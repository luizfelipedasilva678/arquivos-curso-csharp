using System;
using EXCEPTION_EXERCISE.Entities;
using EXCEPTION_EXERCISE.Entities.Exceptions;

namespace EXCEPTION_EXERCISE
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int accoutNumber = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string accountHolder = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double initialBalance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw Limit: ");
                double withDrawLimit = double.Parse(Console.ReadLine());

                Account acc = new Account(accoutNumber, accountHolder, initialBalance, withDrawLimit);

                Console.WriteLine("------------------------------------------");

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                acc.withDraw(amount);

                Console.Write("New Balance: " + acc.Balance);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }        
        }
    }
}
