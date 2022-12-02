using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample
{
    class BreakContinuePrg
    {
        public static void Main()
        {

            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        
        
            Console.WriteLine("example of break statement");

            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }

    }
}
   