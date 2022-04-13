using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgramming
{
     public class Factorial
    {
        int fact = 1;
       // Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
        public int Factor()//5
        {

            if (num == 4)//5,4,3,2,1,0
            {
                return 1;
            }
            fact = fact * num;
            num--;
            Factor();
           return fact;
        }
    }
}
