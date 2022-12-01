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
    //Display vowel from the Array
    class VowelDisplay
    {
        public void Show(char[] array)
        {
            Console.WriteLine("Display the vowel");
            for (int i=0;i<array.Length;i++)
            {
                if(array[i]=='a'|| array[i]=='e'|| array[i]=='i'|| array[i]=='o'|| array[i]=='u')
                {
                    Console.WriteLine(array[i]);
                }
            }
           
        }
        static void Main(string[] args)
        {
            

            char[] ch = new char[6];
            Console.WriteLine("Enter the elements of Array ");
            for(int i =0;i<ch.Length;i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());

            }
            VowelDisplay v = new VowelDisplay();
            v.Show(ch);
           
            Console.ReadLine();
        }
    }
    //calculate Even Odd number from the Array
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
    // Count odd number in Array
    class OddArrayEx
    {
        public void Display(int[] arr)
        {
            Console.WriteLine("Odd number Display");
            for(int i =0;i<arr.Length;i++)
            {
                if(arr[i] % 2 != 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[4];
            Console.WriteLine("Enter the elements");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            OddArrayEx o = new OddArrayEx();
            o.Display(a);
        }
    }
   /* // Maximum Element from the Array
    
    class MaxNumber
    {
        public void Display(int[] arr)
        {
            int max = 0;
            for(int i =0;i<arr.Length;i++)
            {
                if(max<arr[i])
                {
                    max = arr[i];
                }
                Console.WriteLine(max);
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[6];
            for(int i =0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            MaxValueNumber m = new MaxValueNumber();
            m.Display(a);
            Console.ReadLine();
        }
    }*/
}
