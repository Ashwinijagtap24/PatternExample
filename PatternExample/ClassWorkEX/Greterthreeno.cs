using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample.ClassWorkEX
{
    class Greterthreeno
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

