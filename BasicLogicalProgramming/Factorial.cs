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
            int num = Convert.ToInt32(Console.ReadLine());
        public int Factor()
        {
            
            if (num == 0)
            {
                return  1;
            }
                fact = fact * num;
            num--;
            Factor();
            return fact;
        }
    }
}
