using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample.ClassWorkEX
{
    class PatternExapl
    {
        
        static void Main(string[] args)
        {
            /*****
            ****
        ****
        ****/
            
            for (int i=1;i<=4;i++)
            {
                for(int j=1;j<=4;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
   /*         *
                *
                **
                ***
                *****/
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

   /*         1111
            2222
            3333
            4444*/
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            // Pattern for charcter
            /*          AAAA
                      BBBB
                      CCCC
                      DDDD*/
            for (int i = 'A'; i <= 'D'; i++)
            {
                for (char j = 'A'; j <= 'D'; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            /*                 ABCD
                            ABCD
                            ABCD
                            ABCD
            */
            for (int i = 'A'; i <= 'D'; i++)
            {
                for (char j = 'A'; j <= 'D'; j++)
                {
                    Console.Write((char)(j+64));
                }
                Console.WriteLine();
            }

        }
    
    }
}
