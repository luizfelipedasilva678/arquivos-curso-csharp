using System;

namespace EXERCISE_BANK_ACCOUNT
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            string numeroDaConta = Console.ReadLine();
            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito incial (s/n)? ");
            char deposito = char.Parse(Console.ReadLine());

            if(deposito == 's')
            {
                Console.Write("Informe o Valor do Depósito Incial: ");
                double valorDoDepositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(nome, numeroDaConta, valorDoDepositoInicial);
            }
            else
            {
                conta = new ContaBancaria(nome, numeroDaConta);
            }

            Console.Write("Entre com um valor para depósito: ");
            double valorDoDeposito = double.Parse(Console.ReadLine());
            conta.Deposito(valorDoDeposito);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine("Conta: "+conta.NumeroDaConta+", "+"Titular: "+conta.Nome+", "+"Saldo: "+conta.Saldo);

            Console.Write("Entre com um valor para saque: ");
            double valorDoSaque = double.Parse(Console.ReadLine());
            conta.Saque(valorDoSaque);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine("Conta: " + conta.NumeroDaConta + ", " + "Titular: " + conta.Nome + ", " + "Saldo: " + conta.Saldo);


        }
    }
}
