

using System;
namespace App
{
    public partial class partialclass
    {
        private int x;
        private int y;
        public partialclass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public partial class partialclass
    {
        public void print()
        {
            Console.WriteLine("Output values {0},{1}", x, y);
        }
    }
    class test
    {
        public static void Main()
        {
            partialclass p = new partialclass(25, 39);
            p.print();
            Console.ReadLine();
        }
    }
}