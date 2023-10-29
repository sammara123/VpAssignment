

using System;
namespace ConsoleApplication3
{
    class Sample
    {
        public string param1, param2;
        public Sample() // Default Constructor
        {
            param1 = "Hi";
            param2 = "I am Default Constructor";
        }
        public Sample(string x, string y)
        {
            param1 = x;
            param2 = y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample();
            Sample obj1 = new Sample("Welcome", "ASP.NET");
            Console.WriteLine(obj.param1 + ", " + obj.param2);
            Console.WriteLine(obj1.param1 + " to " + obj1.param2);
            Console.ReadLine();
        }
    }
}