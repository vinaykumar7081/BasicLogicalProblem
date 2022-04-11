using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgramming
{
    internal class VowelConsonents
    {
        char ch;
        
        public void VowelAndConsonent()
        {
            Console.WriteLine("Please Enter the Alphabets:->");
            ch = Console.ReadKey().KeyChar;
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("Entered by End user Character is vowel");
            }
            else
            {
                Console.WriteLine("Entered by End user Character is Consonent");
            }


        }
    }
}
