using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample.SwitchCaseEx
{
    class LeapYearPrg
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter the year");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("Leap yr");

            }
            else
            {
                Console.WriteLine("not leap yr");
            }
            Console.ReadLine();
        }
    }
    // 5 sub percentage 
    class Sub5
    {
        static void Main(string[] args)
        {
            int eng, math, marathi, history, geo, marks;
            Console.WriteLine("Enter the marks of each sub");
            Console.WriteLine("Enter the marks of English");
            eng = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of Maths");
            math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of Marathi");
            marathi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of History");
            history = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Marks of Geo");
            geo = Convert.ToInt32(Console.ReadLine());

            marks = eng + math + marathi + history + geo;

            Console.WriteLine("Marks = " + marks);
            if (marks > 70)
            {
                Console.WriteLine("designation");
            }
            else if (marks > 60 && marks < 70)
            {
                Console.WriteLine("!st class");
            }
            else if (marks > 50 && marks < 60)
            {
                Console.WriteLine("2nd class");
            }
            else if (marks > 35 && marks < 50)
            {
                Console.WriteLine("Pass");

            }
            else
            {
                Console.WriteLine("Fail");
            }
            Console.ReadLine();


        }
    }
    class Gt3
    {
        static void Main(string[] argd)
        {
            int x, y, z;
            Console.WriteLine("Enter thhe number ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2 nd num");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 3 rd num");
            z = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                if (x > z)
                {
                    Console.WriteLine("x is a great");
                }
                else
                {
                    Console.WriteLine("z is great");
                }
            }
            else
            {
                if (z > y)
                {
                    Console.WriteLine("Z is great");
                }
                else
                {
                    Console.WriteLine("y21 is great");
                }
            }
            Console.ReadLine();

        }
    }
}
