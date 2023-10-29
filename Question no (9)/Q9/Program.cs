

using System;
namespace InheritanceApplication
{
    class a
    {
        public void display()
        {
            System.Console.WriteLine("my name is XYZ");
        }
    }
    class b : a //b is child of a
    {
        public void display1()
        {
            System.Console.WriteLine("belongs to computer science department");
        }
    }
    class c
    {
        public static void Main()
        {
            b x = new b();
            x.display();
            x.display1();
        }
    }
}
