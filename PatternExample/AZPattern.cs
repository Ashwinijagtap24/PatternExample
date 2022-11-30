using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample
{
    class AZPattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("###################");
            //abcd print
            for(int i='A';i<='D';i++)
            {
                for(char j='A';j<=i;j++)
                {
                 
                    Console.Write(j);
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine("###################");
            for (char i='A';i<='D';i++)
            {
                for(char j ='D';j>=i;j--)
                {

                    Console.Write(j);
                    
                }
                Console.WriteLine(" ");
            }

            Console.ReadLine();
        }
    }
}
