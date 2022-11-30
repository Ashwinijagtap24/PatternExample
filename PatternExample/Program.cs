using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample
{
    // Display Table 1 to 5 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Display table 1 to 5 number ");
            for(int i = 1;i<=10;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    //Console.WriteLine("");
                    Console.Write(i * j+"\t");

                }

                Console.WriteLine("   ");
            }
            Console.ReadLine();
        }
    }
    //Find out the Avg of prime number in bet 1 to 20

    class Avgprimenumber
    {
        static void Main(String[] args)
        {
            int Sum = 0;
            int avg = 0;
            bool isprime = true;

            for (int i = 2; i <= 20; i++)
            {
                for (int j = 2; j <= 20; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isprime = false;

                        break;
                    }
                   

                }
               // Console.WriteLine("prime number to 1 to 20");

                if (isprime)
                {
                   
                   Console.WriteLine(i);
                    Sum = Sum + i;
                    avg = Sum / 8            ;
                    
                }
                
                isprime = true;
               
            }
            Console.WriteLine("Sum of prime number = "+Sum);
            Console.WriteLine("Sum of prime number = " + avg);

            Console.ReadKey();
        }
    }
    //Calculate the sum of Factorial 1 to 5
    class Fact1to5
    {
        static void Main(string[] args)
        {
            int fact = 1;
            int sum = 0;
            for(int i = 1;i<=5;i++)
            {
                
                        fact = fact * i;
                    sum = sum + fact;
                        
                    
                Console.WriteLine(fact);
               
            }
            Console.WriteLine("Sum of Factorial = " + sum);
            Console.ReadKey();
        }
    }

}
