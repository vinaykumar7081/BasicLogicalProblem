using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgramming
{
    public class BiggestNumber
    {
        public void GreatestNumber()
        {
            Console.WriteLine("Please Enter the three number To find the Greatest Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num2 > num3)
            {
                Console.WriteLine("First Number is Greatest Number" + " " + num1);
            }
            else if (num2 < num1 && num1 < num3)
            {
                Console.WriteLine("Second Number is Greatest Number" + " " + num2);
            }
            else
            { 
            Console.WriteLine("Third Number is Greatest Number");
            }
        }
    }
}
