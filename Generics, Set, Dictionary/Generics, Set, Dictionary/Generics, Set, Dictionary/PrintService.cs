using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Generics__Set__Dictionary
{
    class PrintService<T>
    {
        private List<T> nums = new List<T>();

       public void addValue(T num)
       {
            nums.Add(num);
       }

       public T first()
       {
            return nums.First();
       }

       public void print()
       {
            nums.ForEach(x => Console.Write("[" + x + "]"));
       }
    }
}
