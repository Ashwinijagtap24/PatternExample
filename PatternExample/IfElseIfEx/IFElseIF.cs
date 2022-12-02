using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample.IfElseIfEx
{
    class IFElseIF
    {
        //area of triangle
        static void Main(string[] args)
        {
            int base1, height;
            int Area;
            Console.WriteLine("Enter the base value");
            base1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height");
            height = Convert.ToInt32(Console.ReadLine());
            Area = (base1 * height) / 2;
            Console.WriteLine("Area = " + Area);


        }
    }
    class evenodd
    {
        //number is even or odd
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter the Number ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Number is Even ");

            }
            else
            {
                Console.WriteLine("Number is Odd");

            }
            Console.ReadLine();
        }
    }
    class Devision5
    {
        //number is divisible by 5
        static void Main(string[] args)
        {
            int b;
            Console.WriteLine("Enter the number");
            b = Convert.ToInt32(Console.ReadLine());
            if (b % 5 == 0)
            {
                Console.WriteLine("Divisible by 5");
            }
            else
            {
                Console.WriteLine("not divisible by 5");
            }
        }
    }
    class PositiveNegativeZero
    {
        //number is positive negative or zero
        static void Main(string[] args)
        {
            int c;
            Console.WriteLine("Enter the Number");
            c = Convert.ToInt32(Console.ReadLine());
            if (c > 0)
            {
                Console.Write("Number is Positive");
            }
            else if (c < 0)
            {
                Console.WriteLine("Number is negative");

            }
            else
            {
                Console.WriteLine("Number is Zero");

            }
            Console.ReadLine();
        }
    }
    class Divisible3or5
    {
        //Divisible by 3 or 5
        static void Main(string[] args)
        {
            int d;
            Console.WriteLine("Enter the number ");
            d = Convert.ToInt32(Console.ReadLine());
            if (d % 3 == 0 || d % 5 == 0)
            {
                Console.WriteLine("Number is divisible by 3 or 5");
            }
            else
            {
                Console.WriteLine("Number is not Divisible by 3 or 5");
            }
            Console.ReadLine();
        }
    }
    class Smtwfs
    {
        //Sunday monday tuesday....number wise
        static void Main(string[] args)
        {
            int e;
            Console.WriteLine("Enter the number 1 to 7 ");
            e = Convert.ToInt32(Console.ReadLine());
            if (e == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (e == 2)
            {
                Console.WriteLine("Tuesday");

            }
            else if (e == 3)
            {
                Console.WriteLine("Wednesday");

            }
            else if (e == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (e == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (e == 6)
            {
                Console.WriteLine("Saturday");

            }
            else if (e == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
    class VowelLetter
    {
        //Vowel with capital letter or small letter
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter the character");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'A')
            {
                Console.WriteLine("its Vowel");
            }
            else if (ch == 'e' || ch == 'E')
            {
                Console.WriteLine("its Vowel");
            }
            else if (ch == 'i' || ch == 'I')
            {
                Console.WriteLine("its Vowel");
            }
            else if (ch == 'o' || ch == 'O')
            {
                Console.WriteLine("its Vowel");
            }
            else if (ch == 'u' || ch == 'U')
            {
                Console.WriteLine("its Vowel");
            }
            else
            {
                Console.WriteLine("its Consounent");
            }
        }
    }
}
