using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgramming
{
    internal class VowelConsonents
    {
        public void VowelAndConsonent()
        {
            Console.WriteLine("Please Enter the word:->");
            char ch = Console.ReadKey().KeyChar;
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("Entered by End user Character is vowel in Lower case");
            }
            else if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("Entered by End user Character is vowel in Upper case");
            }
            else
            {
                Console.WriteLine("Entered by End user Character is Consonents");
            }
        }
    }
}
