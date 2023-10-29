
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication8
{
    class a
    {
        public void display()
        {
            Console.WriteLine("my name is XYZ");
        }
    }
    class b : a //b is child of a
    {
        public void display1()
        {
            Console.WriteLine("Belongs to Computer Science Department");
        }
    }
    class d : b //d is child of b
    {
        public void display2()
        {
            Console.WriteLine("Studying in Air University Multan");
        }
    }
    class c
    {
        public static void Main()
        {
            d x = new d();//Normally object of child
            x.display();
            x.display1();
            x.display2();
        }
    }
}