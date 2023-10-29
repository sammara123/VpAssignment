


using System;

namespace c
{
    class pro
    {
        public static void Main(string[] args)
        {
            int n, i = 0;
            Console.WriteLine("Enter any Value: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                i++;
                n = n / 10;
            }
            Console.WriteLine("total digits in the number: " + i);
        }
    }
}