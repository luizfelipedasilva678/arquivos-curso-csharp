using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EXERCISE_INTERFACE.Entities
{
    class Contract
    {
        public List<Installments> list { get; set; }
        public int  Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            list = new List<Installments>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Installments item in list)
            {
                sb.AppendLine(item.Date.ToString("dd/MM/yyyy") + " - " + item.Amount);
            }
            return sb.ToString();
        }
    }
}
