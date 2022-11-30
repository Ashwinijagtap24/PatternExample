using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample.ArrayExample
{
    //sum of even Array

    class SumofevenArray
    {
        public void Display(int[] arr)
        {
           int sum = 0;
            for(int i =0;i<arr.Length;i++)
            {
               

                    if (arr[i] % 2 == 0)
                    {

                       sum += arr[i];

                    }


            }
            Console.WriteLine("even number sum = " + sum);

        }
        static void Main(string[] args)
        {
            int[] a = new int[6];
            Console.WriteLine("Enter the number ");
            for(int i =0;i<6;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
          
            SumofevenArray s = new SumofevenArray();
            s.Display(a);
            
            
            Console.ReadLine();

        }

    }
    //Count the odd element from the Array
    class OddArray
    {
        public void Show(int[] array)
        {
            int count = 0;
            for(int i=0;i<array.Length;i++)
            {
                if(array[i] %2 != 0)
                {
                    // Console.Write(" Odd elements = ");
                    Console.WriteLine(array[i]);
                        count++;

                }
            }Console.WriteLine(count);
        }
        static void Main(string[] args)
        {
            

            int[] a = new int[6];
            Console.WriteLine("Enter the Elements of Array ");
            for(int i =0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            OddArray o = new OddArray();
            o.Show(a);
            Console.ReadLine();
        }
    }

    class  EvenOddNUmber
    {
        public void Show(int[] arr)
        {
            
            Console.WriteLine("even number = ");
            for(int i =0;i<arr.Length;i++)
            {
                if(arr[i] %2==0)
                {
                    Console.WriteLine(arr[i]);
                }
              
            }
            Console.WriteLine("odd number");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.WriteLine( +arr[i]);                  
                }
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[6];
            Console.WriteLine("Enter the element in array");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            EvenOddNUmber eo = new EvenOddNUmber();
            eo.Show(a);
            Console.ReadLine();

        }
    }
}
