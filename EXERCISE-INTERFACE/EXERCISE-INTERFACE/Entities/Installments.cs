using System;
using System.Collections.Generic;
using System.Text;

namespace EXERCISE_INTERFACE.Entities
{
    class Installments
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }

        public Installments(DateTime date, double amount)
        {
            Date = date;
            Amount = amount;
        }
    }
}
