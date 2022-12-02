using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample.ArrayExample
{
    // boc pattern
    class Pattern2dArray
    {
        public void ShowPattern(int[,]a)
        {
            //Display All pattern 
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    Console.Write(a[i,j]);
                }
                Console.WriteLine();
            }
            //n pattern
            Console.WriteLine("//////////////");

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if(j==0||i==j||i==a.GetLength(0)||j==a.GetUpperBound(1))
                    {
                        Console.Write(a[i, j]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            // box pattern
            Console.WriteLine("##############");
            for(int i =0;i<a.GetLength(0);i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (j==0||i==3||i==0||j==3)
                    {
                        Console.Write(a[i, j]);
                    }
                    else
                    {
                       
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
            //S
            Console.WriteLine("##########");
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if(i==0||i==3||i==j)
                    {
                        Console.Write(a[i, j]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("##########");
            //A letter 
            for (int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if(i==0||j==0||i==2||j==3)
                    {
                        Console.Write(a[i, j]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
            //Tletter 
            Console.WriteLine("##########");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i==0||j==1)
                    {
                        Console.Write(a[i, j]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
        }
        
        static void Main(string[] args)
        {
            int[,] ar = { { 1,2,3,4},
                           {5,6,7,8 },
                           {6,3,1,5 },
                            {4,7,5,2 }
                         };
            Pattern2dArray p = new Pattern2dArray();
            p.ShowPattern(ar);
            Console.ReadLine();

        }
    }
    //Write a code to find out the coloumn wise sum
    class ColoumnRowSum
    {
        //Sum of Row program
        public void SumRow(int[,] n)
        {
            Console.WriteLine("row wise sum = ");
            for (int i =0;i<n.GetLength(0);i++)
            {
                int sum = 0;
                for (int j =0; j<n.GetLength(1);j++)
                {
                    sum = sum + n[i, j];

                    Console.Write(n[i, j]+" ");
                    
                }
                Console.WriteLine("sum of row = " + sum);
                //Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Column wise sum = ");
            for (int i = 0; i < n.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < n.GetLength(1); j++)
                {
                    sum = sum + n[j, i];
                    Console.WriteLine(n[j, i] + " ");


                }
                Console.WriteLine("sum of Col = " + sum);
                Console.WriteLine();

            }
        }
       /* public void SumCol(int[,] p)
        {
            
            for (int i = 0; i < p.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < p.GetLength(1); j++)
                {
                    sum = sum + p[j,i];
                    Console.WriteLine(p[j,i]+ " ");
                    

                }
                Console.WriteLine("sum of Col = " + sum);
                Console.WriteLine();

            }
            //Console.WriteLine("sum of Col = " + sum);
        }*/
        static void Main(string[] args)
        {
           
            int[,] a = new int[3,3];
            Console.WriteLine("Enter the element of 2D Array");
            for(int i =0;i< a.GetLength(0);i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
               
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
            ColoumnRowSum c = new ColoumnRowSum();
            c.SumRow(a);
            
          
            Console.ReadLine();
        }
      
    }
    //Write Code to Find out Mix valuewith Column And Row wise
    class MaX
    {
        public void Display(int[,] arr)
        {
            
            for(int i =0;i<arr.GetLength(0);i++)
            {
              
                for (int j =0;j<arr.GetLength(1);j++)
                {
                    int max = arr[j,i];
                    if (arr[j,i] >max)
                    {
                        max = arr[j,i];

                    }
                    Console.WriteLine("max = " + max);
                }
               
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] a = { { 1,2,3},
                        {4,5,6 },
                        {1,2,5 }
                       };
            MaX m = new MaX();
            m.Display(a);
            Console.ReadLine();
        }
    }
    //Addition of two MAtrix 
    class AddMatrix
    {
        public void MatrixAdd(int[,] s, int[,] k)
        {
            Console.WriteLine("First Array = ");
            for(int i=0;i<s.GetLength(0);i++)
            {
                for(int j=0;j<s.GetLength(1);j++)
                {
                    Console.Write(s[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Second Array = ");
            for (int i = 0; i < k.GetLength(0); i++)
            {
                for (int j = 0; j < k.GetLength(1); j++)
                {
                    Console.Write(k[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[,] c = new int[3,3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                         c[i,j]= s[i, j] + k[i, j];

                }
                Console.WriteLine();
            }
            Console.WriteLine(" Additon perform = ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + c[i, j]);

                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            int[,] a = { { 1,2,3},
                         {4,5,6},
                         {1,2,3}};
            int[,] b = { { 2,4,5},
                         {7,8,1},
            {9,3,1}};
            int[,] c = new int[3,3];
            /*for(int i= 0;i<a.GetLength(0);i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine(c[i,j]);
                }
            }*/

            AddMatrix am = new AddMatrix();
            am.MatrixAdd(a, b);
            Console.ReadLine();
        }
    }
}
