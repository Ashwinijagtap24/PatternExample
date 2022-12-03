using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample.ArrayExample
{
    class NumberArrayMax
    {
        public void Show(int[] arr)
        {
            int max = 0;
            for(int i =0;i<arr.Length;i++)
            {
                if(max < arr[i])
                {
                    max = arr[i];
                }
                
                   // Console.WriteLine(max);
                
            }Console.WriteLine("max number = "+max);
        }
        static void Main(string[] args)
        {
            int[] a = new int[6];
            for(int i =0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            NumberArrayMax nm = new NumberArrayMax();
            nm.Show(a);
            Console.ReadLine();
        }

    }
    //min value from the int array
    class NumberOfMinArray
    {
        public void Show(int[] n)
        {
            int min = n[0];
            for(int i=0;i<n.Length;i++)
            {
                if(min > n[i])
                {
                    min = n[i];
                }
            }Console.WriteLine("min="+min);
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter the elements");
            for(int i =0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            NumberOfMinArray mi = new NumberOfMinArray();
            mi.Show(a);
            Console.ReadLine();
        }
    }

    //find out the min and max character from the Array
    class MinMaxCharArray
    {
        public void Show(Char[] C)
        {
            int max = 0;
            for(int i = 0;i<C.Length;i++)
            {
                if(max < C[i])
                {
                    max = C[i];
                }

            }Console.WriteLine(max);
        }
        static void Main(string[] args)
        {
            char[] ch = new char[5];
            Console.WriteLine("Enter the Character  in to the Array");
            for(int i =0;i<ch.Length;i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            MinMaxCharArray mm = new MinMaxCharArray();
            mm.Show(ch);
            Console.ReadLine();
        }
    }
    //Sorting Array
    class CharSortArray
    {

        public void  MySortChar(char[] a)
        {
            for(int i=0;i<a.Length;i++)
            {
                for(int j=0;j<a.Length; i++)
                {
                    if(a[i]<a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = a[i];
                    }
                }
            }
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" sorting charating  of an array...");
            char[] ch = { 'd', 'y', 'f', 'a' };
            CharSortArray c = new CharSortArray();
            Console.ReadLine();

           
        }
    }
    // Code for Capital letter
  class CharExample
    {
        public char[] Show(char[] chh)
        {
            for(int i=0;i<chh.Length;i++)
            {
                if (chh[i] >= 'a' && chh[i] <='z')
                {
                    chh[i] = (char)(chh[i] - 32);
                }
                else if(chh[i]>='A' && chh[i]<='z')
                {
                    chh[i] = (char)(chh[i] + 32);
                }
                else
                {
                    chh[i] = chh[i];

                }
            }
            return chh;

        }

        static void Main(string[] args)
        {
            char[] c = { 't', 'a', 'r', 'w', 'y' };
            CharExample ch = new CharExample();
            ch.Show(c);
            Console.WriteLine(string.Join(" ", c));
            Console.ReadLine();

        }
    }
    // write code to creat a char type of array element by its alternative char
    class CharAlternateelement
    {
        public void Display(char[] ch)
        {
            for (int i = 0; i < ch.Length; i++)
            {

                
                if (ch[i] == 'y' || ch[i] == 'Y' || ch[i] == 'z'||ch[i]=='Z')
                {
                    ch[i] = Convert.ToChar(97);
                    Console.WriteLine(ch);
                }
                ch[i] = (char)(ch[i] + 2);

            }
           // Console.WriteLine(ch);
        }
        static void Main(string[] args)
        {
            char[] c = { 't', 'a', 'r', 'w', 'y' };
            CharAlternateelement ca = new CharAlternateelement();
            ca.Display(c);
            Console.ReadLine();


        }
    }
    // replce zero if number is divide by 3
    class Divisibleby3number
    {
        public void Display(int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] % 3 == 0)
                {

                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            int[] a = { 3, 5, 4, 6, 9 };
            Divisibleby3number d = new Divisibleby3number();
            d.Display(a);
            Console.ReadLine();

        }
    }
    //sum of array
    class SumOfArray
    {
        public void Display(int[] arr)
        {
            int sum = 0;
            for(int i=0;i<arr.Length;i++)
            {
                sum = arr[i] + sum;
            }
            Console.WriteLine("Sum = " + sum);
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            SumOfArray s = new SumOfArray();
            s.Display(a);
            Console.ReadLine();

        }
    }
    //Display the prime number from the Array
    class PrimeNumberArray
    {
        public void Display(int[] arr)
        {
            for(int i=2;i<arr.Length;i++)
            {
                if(arr[i]%2==0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("its prime no  "+arr[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            PrimeNumberArray p = new PrimeNumberArray();
            p.Display(a);
            Console.ReadLine();
        }
    }
}
