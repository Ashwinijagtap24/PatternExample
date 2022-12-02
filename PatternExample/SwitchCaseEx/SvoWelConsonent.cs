using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample.SwitchCaseEx
{
    class SvoWelConsonent
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("enter the character");
            ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("its vowel");
                    break;
                case 'A':
                    Console.WriteLine("its  vowel");
                    break;

                case 'e':
                    Console.WriteLine("its vowel");
                    break;
                case 'E':
                    Console.WriteLine("its  vowel");
                    break;

                case 'i':
                    Console.WriteLine("its vowel");
                    break;
                case 'I':
                    Console.WriteLine("its  vowel");
                    break;

                case 'o':
                    Console.WriteLine("its vowel");
                    break;
                case 'O':
                    Console.WriteLine("its  vowel");
                    break;

                case 'u':
                    Console.WriteLine("its vowel");
                    break;
                case 'U':
                    Console.WriteLine("its  vowel");
                    break;
                default:
                    Console.WriteLine("its Consonent");
                    break;

            }
            Console.ReadLine();
        }
    }
}

