using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample.ClassWorkEX
{
    class ArmStrongNUmber
    {
        static void Main(string[] args)
        {
            int result = 0;
            Console.WriteLine("Enter the number  ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                int digit = n % 10;
                result = (result+10)* digit*digit*digit;
                n = n / 10;

            }
            Console.WriteLine("Sum of digit = " + result);
        }
    }
}
