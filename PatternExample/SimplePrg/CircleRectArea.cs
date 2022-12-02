using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample.SimplePrg
{
    class CircleRectArea
    {
        static void Main(string[] args)
        {
            double radius, Area;
            radius = 15;
            Area = 3.14 * radius * radius;
            Console.WriteLine("Area of circle = " + Area);



        }
    }
    
    // Area of rectangle 
    
    class Rectangle
    {
        static void Main(string[] args)
        {
            int length, width, Area;
            length = 12;
            width = 13;
            Area = length * width;
            Console.WriteLine("Area of Rectangle= " + Area);

        }
    }
    //Addition od two number 
    class Addition1
    {
        static void Main(string[] args)
        {
            int a, b, result;
            a = 10;
            b = 20;
            Console.WriteLine("Addition ");
            result = a + b;
            Console.WriteLine("result" + result);
            Console.WriteLine("Subtraction");
            result = a - b;
            Console.WriteLine("result =" + result);
            Console.WriteLine("division");
            result = a / b;
            Console.WriteLine("result = " + result);
            Console.WriteLine("multiplication");
            result = a * b;
            Console.WriteLine("result = " + result);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            byte b;
            b = 96;
            Console.WriteLine("byte value = " + b);

            short d;
            d = 850;
            Console.WriteLine("short value = " + d);

            int a;
            a = 10;
            Console.WriteLine("integer value = " + a);

            long e;
            e = 8999051833;
            Console.WriteLine("long value = " + e);

            double t;
            t = 95.86;
            Console.WriteLine("double value " + t);

            float x;
            x = 6.1f;
            Console.WriteLine("float value = " + x);

            char R = 'R';
            Console.WriteLine("Char value = " + R);





        }
    }
}
