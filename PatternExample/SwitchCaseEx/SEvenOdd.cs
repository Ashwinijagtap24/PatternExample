using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample.SwitchCaseEx
{
    class SEvenOdd
    {
        //calculate odd even 

        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter the number");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{1}.even number");
            Console.WriteLine("{2}.odd number");
            Console.WriteLine("you want to calculate even or odd");
            int b = Convert.ToInt32(Console.ReadLine());
            switch (b)
            {
                case 1:
                    Console.WriteLine("you perform some even number ");
                    if (a % 2 == 0)
                    {
                        Console.WriteLine("Its even number" + a);
                    }
                    break;
                case 2:
                    Console.WriteLine("you perform some odd");
                    if (a % 2 != 0)
                    {
                        Console.WriteLine("its Odd number" + a);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;

            }
            Console.ReadLine();
        }
    }
}

