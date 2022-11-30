using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample
{
    class KrishanamurthiNo
    {
        static void Main(string[] args)
        {
            int sum= 0;
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            int num = a;
           
            while(num>0)
            {
                int digit = num% 10;
                int fact = 1;
                for (int i = 1; i <= digit; i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                num= num/ 10;

            }
           if(sum==a)
            {
                Console.WriteLine("krishana murthi");
            }
            else
            {
                Console.WriteLine("not krushinamurthi number");
            }
            //Console.WriteLine(fact);
            Console.ReadLine();
        }
    }
}
