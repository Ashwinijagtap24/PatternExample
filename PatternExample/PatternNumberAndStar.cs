using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample
{
    class PatternNumberAndStar
    {
        /*  ****
            ****
            ****
            *****/
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@");
            /*****
             ***
             **
             **/

            for (int i = 1; i <= 4; i++)
            {
                for (int j = i; j <= 4; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@");

            /*     *
                   **
                   ***
                   ****
       */
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }


            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@");

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {


                    if (j == 2 && i == 3)
                    {
                        Console.Write(" ");

                    }
                    else
                    {
                        Console.Write("*");
                    }

                }
                Console.WriteLine(" ");
            }

            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@");
              //n print

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (j == 1 || j == 4 || i == 2 && j == 2 || i == 3 && j == 3 || j == 4)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(" ");

            }

            //h print
            Console.WriteLine("###################");
            for(int i = 1;i<=5;i++)
            {
                for(int j = 1;j<=5;j++)
                {
                    if (j == 1 || i == 3 || j == 5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");

            }
            //+ sign 
            Console.WriteLine("###################");
            for(int i=1;i<=5;i++)
            {
                for(int j = 1;j<=5;j++)
                {
                    if (j == 4 && i == 3 || j == 5 || i == 3)
                    {
                        Console.Write("*");
                    }
              
                        Console.Write(" ");
                    
                }
                Console.WriteLine("");
            }

            //*0 print -
            Console.WriteLine("###################");
            for(int i=1;i<=4;i++)
            {
                for(int j =1;j<=i;j++)
                {
                    if (j == 1 || j == 3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("O");
                    }
                }
                
                Console.WriteLine("");
            }

            Console.ReadLine();
        }
       
    }


    
}

