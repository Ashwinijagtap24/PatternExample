using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample.OopsConceptDemo
{
    class StudentDetails
    {
        int Id;
        string Name;
        int Marks;
       public StudentDetails(int Id,string Name)
        {
            this.Id = Id;
            this.Name = Name;
           // this.Marks = Marks;

        }
        int math,eng,marathi;
        
        
        public void Display()
        {
            Console.WriteLine("ID = " +Id);
            Console.WriteLine("NAme = " + Name);
            Console.WriteLine("Enter the marks of Math");
            math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of eng");
            eng = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of marathi");
            marathi = Convert.ToInt32(Console.ReadLine());


        
            int sum =math + eng + marathi;
            Console.WriteLine("Sum of marks = " + sum);
            int result = (sum * 100) / 300;
             Console.WriteLine("Percentage of Marks = " + result);


        }

    }
    class StudentInfo
    {
        static void Main(string[] args)
        {
            StudentDetails sd = new StudentDetails(24,"Ashu");
            sd.Display();
            Console.ReadLine();

        }
    }
}
