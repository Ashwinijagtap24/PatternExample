using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample
{
    class NumberPattern
    {
        static void Main(string[]args)
        {
            for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=4;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine("###################");
            for(int i =1;i<=4;i++)
            {
                for(int j =1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("###################");
           
            for (int i = 6; i >=1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("###################");
            int n = 3;
            int count=1;
            for(int i =1;i<=n;i++)
            { 
                for(int j=1;j<=i;j++)
                {
                    
                    Console.Write(count);
                    count++;
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
}
