using System;
using EXCEPTION_EXERCISE.Entities.Exceptions;

namespace EXCEPTION_EXERCISE.Entities
{
    class Account
    {
        private string _holder;
        public int Number { get; private set; }
        public double Balance { get; private set; }
        public double WithDrawLimit { get; private set; }

        public string Holder 
        {
            get { return _holder; }
            set 
            { 
                if(value.Length > 0 && value != null)
                {
                    _holder = value;
                }
            }
        }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void deposit(double amount)
        {
            Balance += amount;
        }

        public void  withDraw(double amount)
        {
            if(Balance == 0)
            {
                throw new DomainException("You cannot withdraw because your balance is zero");
            }

            if(amount > WithDrawLimit)
            {
                throw new DomainException("You cannot withdraw because your amount is highest withdraw limit");
            }

            Balance -= amount;
        }
    }
}
