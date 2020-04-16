using System;


namespace EXERCISE_BANK_ACCOUNT
{
    class ContaBancaria
    {
        private string _nome;
        public string NumeroDaConta { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string nome, string numeroDaConta)
        {
            _nome = nome;
            NumeroDaConta = numeroDaConta;
        }

        /* Outro Construtor que também funcionaria
            public ContaBancaria(string nome, string numeroDaConta, double depositoIncial) : this(nome, numeroDaConta)
            {
                Saldo = depositoIncial;
            }
        */
        
        public ContaBancaria(string nome, string numeroDaConta, double depositoIncial)
        {
            _nome = nome;
            NumeroDaConta = numeroDaConta;
            Deposito(depositoIncial);
        }
        

        public string Nome {
            get { return _nome; }
            set
            {
                if(value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public void Saque(double valorDoSaque)
        {
            Saldo = Saldo - valorDoSaque - 5;
        }

        public void Deposito(double valorDoDeposito)
        {
            Saldo = Saldo + valorDoDeposito;
        }

        public override string ToString()
        {
            return "Dados da Conta: " + "\n" + "Conta: " + NumeroDaConta + "\n" + "Titular: " + _nome + "\n" + "Saldo: " + Saldo
        }



    }
}
