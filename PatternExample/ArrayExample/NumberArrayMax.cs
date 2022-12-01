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
            int max = 0;c
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
}
