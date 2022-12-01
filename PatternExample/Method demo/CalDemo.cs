using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample.Method_demo
{//calculate 
    class CalDemo
    {
       /* int a ,b;*/
        public void Addition(int a,int b)
        {
            int c = a + b;
            Console.WriteLine("Addition = " + c);
        }
        public void Substraction(int a,int b)
        {
            int c = a - b;
            Console.WriteLine("substraction = " + c);
        }
        public void Multiplication(int a,int b)
        {
            int c = a * b;
            Console.WriteLine("multiplication = " + c);

        }
        public void Division(int a,int b)
        {
            int c = a / b;
            Console.WriteLine("Division = " + c);
        }
        static void Main (string []args)
        {
            CalDemo c = new CalDemo();
            c.Addition(10, 20);
            c.Substraction(30, 20);
            c.Multiplication(2, 4);
            c.Division(6,3);
            Console.ReadLine();
        }
    }
    //car details 
    class CarInfo
    {
        int ModelNumber;
        string Car_Name;
        int car_price;
        string car_colour;
       public void AcceptCarInfo(int Modelno,string name,int price,string colour)
        {
            ModelNumber = Modelno;
            Car_Name = name;
            car_price = price;
            car_colour = colour;

        }
        public void DisplayInfo()
        {
            Console.WriteLine("Car Model = " + ModelNumber);
            Console.WriteLine("Car Name = " + Car_Name);
            Console.WriteLine("Car Price = " + car_price);
            Console.WriteLine("Car Colour = " + car_colour);
        
        }
       static void Main(string[] args)
        {
            CarInfo c = new CarInfo();
            c.AcceptCarInfo(2410, "BMW", 100000, "Black");
            c.DisplayInfo();


            CarInfo d = new CarInfo();
            d.AcceptCarInfo(1024, "oddi", 100000, "white");
            d.DisplayInfo();

            CarInfo e = new CarInfo();
            e.AcceptCarInfo(1024, "Marcadyy", 100000, "Blue");
            e.DisplayInfo();

          
            Console.ReadLine();
        }
     }
    //book details 
    class BookDetails
    {
        string Book_name;
        string Book_author;
        int Book_price;
        int Book_pages;
        public void getData(string Book_name, string Book_author, int Book_price, int Book_pages)
        {
            this.Book_name = Book_name;
            this.Book_author = Book_author;
            this.Book_price = Book_price;
            this.Book_pages = Book_pages;

        }
        public void Display()
        {
            Console.WriteLine("Book Name  = " + Book_name);
            Console.WriteLine("Book Author  = " + Book_author);
            Console.WriteLine("Book Price  = " + Book_price);
            Console.WriteLine("Book Pages  = " + Book_pages);

        }
        static void Main(string[]args)
        {
            BookDetails b = new BookDetails();
            b.getData("Before memory Faded","Naliman",399,459);
            b.Display();
            Console.ReadLine();

           
        }
    }
    //calculate are of reactangle
    class AreaofRectangle
    {
        /*double length;
        double width;*/
        public double AreaReact(double length,double width)
        
        {
            double Area = length * width;
            return Area;
        }

        static void Main(string[] args)
        {
            AreaofRectangle Ar = new AreaofRectangle();
           double Area = Ar.AreaReact(2.5, 3.5);
            Console.WriteLine("Area of Reactangle = " + Area);
            Console.ReadLine();
        }
    }
    //Mobile details
    class MobileDetails
    {
        string mobile_name;
        int price;
        string mobile_model;
        public void getinfo()
        {
            Console.WriteLine("Enter the Mobile Name ");
            mobile_name = Console.ReadLine();
            Console.WriteLine("Enter the model");
            mobile_model = Console.ReadLine();
            Console.WriteLine("Enter the Mobile price");
            price = Convert.ToInt32(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("Mobile name = " + mobile_name);
            Console.WriteLine("Mobile Model = " + mobile_model);
            Console.WriteLine("Mobile price = " + price);
        }
        static void Main(string[] args)
        {
            MobileDetails Md = new MobileDetails();
            Md.getinfo();
            Md.display();
            Console.ReadLine();

        }
    }
    // stud details
    class StudDetails
    {
        int roll_no;
        string name;
        string Sch_name;
        public void getdata()
        {
            Console.WriteLine("enter the roll no");
            roll_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("entr th ename of student");
            name = Console.ReadLine();
            Console.WriteLine("entr the School name ");
            Sch_name = Console.ReadLine();
        }
        public void display()
        {
            Console.WriteLine("Roll number = " + roll_no);
            Console.WriteLine("Student name = " + name);
            Console.WriteLine("Student School name = " + Sch_name);

        }
        static void Main(string[] args)
        {
            StudDetails s = new StudDetails();
            s.getdata();
            s.display();
            Console.ReadLine(); 

        }
    }


}
