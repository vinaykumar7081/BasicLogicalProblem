using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgramming
{
    public class QuotientAndRemainder
    {
        int remeinder = 0;
        int quotient = 0;
        public void RemienderAndQuotient()
        {
            Console.WriteLine("Enter a number:->");
            int number = Convert.ToInt32(Console.ReadLine());
            remeinder = number % 10;
            quotient = number / 10;
            Console.WriteLine("Remiender of that number is:->" + remeinder);
            Console.WriteLine("Quotient of that number is:->" + quotient);
        }

    }
}
