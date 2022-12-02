using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample.LoopingEx
{
    //odd number using while loop
    class DoWhileProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sum of odd number using while loop");
            int a;
            Console.WriteLine("Enter the number");
            a = Convert.ToInt32(Console.ReadLine());

            while (a % 2 != 0)
            {
                Console.WriteLine("odd number " + a);
                break;
            }
            Console.ReadLine();
        }
    }
    //sum of odd number
    class Whileprog1
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("sum of odd number using while loop");
            for (int i = 1; i <= 20; i++)
            {
                while (i % 2 != 0)
                {

                    count++;
                    Console.WriteLine("odd number " + i);
                    i++;
                }

            }
            Console.WriteLine("Sum of odd number = " + count);
            Console.ReadLine();


        }
    }
    //print 1 to10 number
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
