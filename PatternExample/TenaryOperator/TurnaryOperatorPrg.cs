using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample.TenaryOperator
{
    class TurnaryOperatorPrg
    {
        // check no is positive negative and zero
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the Number");
            num = Convert.ToInt32(Console.ReadLine());
            string Result = num > 0 ? (num < 0 ? "number is negative" : "number is positive") : (num == 0 ? "number is zero" : "negative number");
            Console.WriteLine("result = " + Result);
            Console.ReadLine();
        }
    }
    //chek  number is divisible by 5 or 11
    class Div5or11
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Enter the number");
            num1 = Convert.ToInt32(Console.ReadLine());
            string res = num1 % 5 == 0 || num1 % 11 == 0 ? "Number is divisible by 5 or 11" : "number is not divisible by 5 or 11";
            Console.WriteLine("result = " + res);
            Console.ReadLine();
        }

    }
    // check number is greater than bet 3
    class Greaterthan3
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("enter the first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third number");
            c = Convert.ToInt32(Console.ReadLine());
            string MaxNumber = a > b ? (a > c ? "a is gretaer" : "c is greter") : (b > c ? "b is greter " : "c is greter");
            Console.WriteLine(MaxNumber);
            Console.ReadLine();

        }
    }
}
