using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample
{
    class DisariumProgram
    {
        static void Main(string[] args)
        {
            int num, Length = 0;
            //int res = 0;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                Length = Length + 1;

                num = num / 10;


            }
            Console.WriteLine(Length);
            int digit = num % 10;
            Console.WriteLine(Math.Pow(digit, Length));

            Console.ReadLine();



        }
    }
}
