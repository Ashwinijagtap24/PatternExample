using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample.LoopingEx
{//1 to 10 number
    class ForLoopEx
    {

        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    //disaply number sum of 75 to 65
    class Prog1
    {
        static void Main(string[] args)
        {
            for (int i = 75; i >= 65; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
    //disaply number sum of 120 to 200
    class Prg3
    {
        static void Main(string[] args)
        {
            for (int i = 120; i <= 200; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    //disaply number sum of 1 to 10

    class Prg4
    {
        static void Main(string[] args)
        {
            int result = 0;
            for (int i = 1; i <= 10; i++)
            {
                result = result + i;
                Console.WriteLine(result);
            }
        }
    }
    //odd nuumber
    class Prg5
    {
        static void Main(string[] args)
        {
            for (int i = 120; i >= 81; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    //odd number count
    class Prg6
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {


                    Console.WriteLine(i);
                }
                count++;
                Console.WriteLine(count);
            }
        }
    }
    //table 
    class Prg7
    {
        static void Main(string[] args)
        {
            int s, result;
            Console.WriteLine("Enter the number");
            s = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                result = s * i;
                Console.WriteLine(result);
            }
        }
    }
    //factor program
    class Prg8
    {
        static void Main(string[] args)
        {
            int a, result = 0;
            Console.WriteLine("enter the number");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                result = result + i;

            }
            Console.WriteLine(result);
        }
    }
    //divisible by 5 and 3
    class Prg9
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("Divisible by 5 and 3");
                }
                else
                {
                    Console.WriteLine("not divisible by  5 and 3");
                }
            }
        }
    }
}
