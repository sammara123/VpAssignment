
using System;
namespace comparison
{
    class Vector
    {
        int x, y, z;
        public Vector(int p, int q, int r)
        {
            x = p;
            y = q;
            z = r;
        }
        public static bool operator ==(Vector v1, Vector v2)
        {
            if (v1.x == v2.x && v1.y == v2.y && v1.z == v2.z)
                return (true);
            else
                return (false);
        }
        public static bool operator !=(Vector v1, Vector v2)
        {
            return (!(v1 == v2));
        }
    }
    class comparison
    {
        static void Main()
        {
            Vector v1 = new Vector(10, 20, 30);
            Vector v2 = new Vector(40, 50, 60);
            if (v1 == v2)
                Console.WriteLine("v1 and v2 both are Equal");
            else
                Console.WriteLine("v1 and v2 are not equal");
            if (!(v1 == v2))
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
            Console.ReadLine();
        }
    }
}