using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgramming
{
    public class FactorialWithoutRecursion
    {
        int fact = 1;
        public void Factorial()
        {
            Console.WriteLine("Enter the Number to Calculate the Factorial");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial is:->"+fact);
        }
    }
}
