using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample.ClassWorkEX
{
    class FactoRIalProgram
    {
        static void Main(string[] args)
        {
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for(int i=1;i<=num;i++)
            {
                fact = fact * i;

            }
            Console.WriteLine("fact number=" + fact);
            Console.ReadLine();
        }
    }
    class FactoRIalProgram1
    {
        //sUM OF FACT
        static void Main(string[] args)
        {
            int num,SUM=0;
            num = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
                SUM = SUM + i;

            }
            Console.WriteLine("fact number=" + fact);
            Console.WriteLine("sum of fact number=" + SUM);
            Console.ReadLine();
        }
    }
    //cal Power of given number
    class PowerExpo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of base");
            int BAse2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number of Expo");
            int Expo = Convert.ToInt32(Console.ReadLine());
            int Power1 = 1;
            for(int i=1;i<=Expo;i++)
            {
                Power1 = Power1 * BAse2;
            }
            Console.WriteLine("Power = " + Power1);
            Console.ReadLine();
        }
       
    }
    // sum of digti
    class SumOFDigit
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter the number  ");
            int n = Convert.ToInt32(Console.ReadLine());
            while(n>0)
            {
                int digit = n % 10;
                sum = sum + digit;
                n = n / 10;

            }
            Console.WriteLine("Sum of digit = " + sum);
        }
    }
    //prime number 
    class Primenum
    {
        static void Main(string[] args)
        {
            int a, count = 0;
            Console.WriteLine("Enter the number  ");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= a; i++)
            {
                if(i%2==0)
                {
                    count++;
                }
            }
            if(count ==0)
            {
                Console.WriteLine("prime number");
            }
            else
            {
                Console.WriteLine("not prime ");
            }
        }
    }
   
}
