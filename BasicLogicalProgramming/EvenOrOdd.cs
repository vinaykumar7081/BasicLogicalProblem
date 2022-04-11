using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgramming
{
    internal class EvenOrOdd
    {
        public void Check()
        {
            Console.WriteLine("Enter a number to checking Even or Odd:->");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Given Number is Even" + " :->" + number);
            }
            else
            {
                Console.WriteLine("Given Number is odd" + " :->" + number);
            }


        }
    }
}
