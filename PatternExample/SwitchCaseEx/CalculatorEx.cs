using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample.SwitchCaseEx
{

    class CalculatorEx
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Enter the 1st number");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("(1). Addition");
            Console.WriteLine("(2). Minus ");
            Console.WriteLine("(3). Multiplication");
            Console.WriteLine("(4). Division");
            Console.WriteLine("Enter your number...which you want to perform some add,sub,mul,div");
            int n3 = Convert.ToInt32(Console.ReadLine());
            switch (n3)
            {
                case 1:
                    Console.WriteLine("You perform Addition of Two number");
                    int add = n1 + n2;
                    Console.WriteLine("Addition = " + add);
                    break;

                case 2:
                    Console.WriteLine("You perform Subtraction of two number");
                    int sub = n1 - n2;
                    Console.WriteLine("substraction = " + sub);
                    break;
                case 3:
                    Console.WriteLine("You perform Multiplication of two number");
                    int mul = n1 - n2;
                    Console.WriteLine("substraction = " + mul);
                    break;
                case 4:
                    Console.WriteLine("You perform Division of two number");
                    int div = n1 - n2;
                    Console.WriteLine("substraction = " + div);
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;


            }
            Console.ReadLine();
        }
    }
    //calculate odd even 
    class Soddeven
    {
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



        }
    }

}

