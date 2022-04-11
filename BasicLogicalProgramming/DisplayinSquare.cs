using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgramming
{
    internal class DisplayinSquare
    {
        public void SquareOfTwo()
        {

            Console.WriteLine("Hello Sir Enter a number:->");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                int num = (int)Math.Pow(2, i);
                Console.WriteLine("2" + " " + "^" + " " + i + "=" + num);
            }


        }
    }
}
