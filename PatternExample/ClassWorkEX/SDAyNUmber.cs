using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample.ClassWorkEX
{
    class SDAyNUmber
    {
        static void Main(string[] args)
        {

            int daynumber;
            Console.WriteLine("Enter the number");
            daynumber = Convert.ToInt32(Console.ReadLine());
            switch(daynumber)
            {
                case 1:Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("thursday");
                    break;
                case 4:
                    Console.WriteLine("friday");
                    break;
                default:
                    Console.WriteLine("Wnesday");
                    break;
            }
        }
    }
    class SDAyNUmber2
    {
        static void Main(string[] args)
        {

            char ch;
            Console.WriteLine("Enter the number");
            ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("Monday");
                    break;
                case 'b':
                    Console.WriteLine("tuesday");
                    break;
                case 'c':
                    Console.WriteLine("thursday");
                    break;
                case 'd':
                    Console.WriteLine("friday");
                    break;
                default:
                    Console.WriteLine("Wnesday");
                    break;
            }
        }
    }
}
