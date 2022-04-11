using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgramming
{
    internal class FlipCoin
    {
        const double HEAD = 0.5;
        const int FLIP_NUMBER_OF_COIN = 200;
        int hCount = 0;
        int tCount = 0;
        public void FlipCoins()
        {

            for (int i = 0; i < 200; i++)
            {
                Random random = new Random();
                double num = random.NextDouble();
                if (num < HEAD)
                {
                    tCount++;
                }
                else
                {
                    hCount++;
                }
            }
            double hPresentage = hCount  % 100;
            double tPresentage = tCount  % 100;
            Console.WriteLine("Percentage of the Coid of HEAD " + hPresentage);
            Console.WriteLine("Percentage of the Coid of TAIL " + tPresentage);


        }
    }
}
