


using System;
namespace ConsoleApplication3
{
    class Sample
    {
        public string param1, param2;
        static Sample()
        {
            Console.WriteLine("Static Constructor");
        }
        public Sample()
        {
            param1 = "Sample";
            param2 = "Instance Constructor";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample();
            Console.WriteLine(obj.param1 + " " + obj.param2);
            Sample obj1 = new Sample();
            Console.WriteLine(obj1.param1 + " " + obj1.param2);
            Console.ReadLine();
        }
    }
}