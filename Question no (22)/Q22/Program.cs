


using System;
namespace binary_overload
{
    class complexNumber
    {
        int x;
        double y;
        public complexNumber(int real, double imagnary)
        {
            x = real;
            y = imagnary;
        }
        public complexNumber()
        {
        }
        public static complexNumber operator +(complexNumber c1,
        complexNumber c2)
        {
            complexNumber c = new complexNumber();
            c.x = c1.x + c2.x;
            c.y = c1.x - c2.y;
            return c;
        }
        public void show()
        {
            Console.Write(x);
            Console.Write("+j" + y);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            complexNumber p, q, r;
            p = new complexNumber(10, 2.0);
            q = new complexNumber(20, 15.5);
            r = p + q;
            Console.Write("p=");
            p.show();
            Console.Write("q=");
            q.show();
            Console.Write("r=");
            r.show();
            Console.ReadLine();
        }
    }
}