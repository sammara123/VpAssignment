


using System;
namespace ConsoleApplication3
{
    class Sample
    {
        public string param1, param2;
        public Sample(string x, string y)
        {
            param1 = x;
            param2 = y;
        }
        public Sample(Sample obj) // Copy Constructor
        {
            param1 = obj.param1;
            param2 = obj.param2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample("Welcome", "Asp.Net");
            Sample obj1 = new Sample(obj);
            Console.WriteLine(obj1.param1 + " to " + obj1.param2);
            Console.ReadLine();
        }
    }
}