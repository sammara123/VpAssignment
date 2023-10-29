
using System;

namespace Matrix
{
    class Pro1
    {
        static void Main(string[] args)
        {
            int i, j, m, n, p, q;
            int[,] a = new int[30, 30];
            int[,] b = new int[30, 30];
            int[,] c = new int[30, 30];

            Console.WriteLine("Enter rows and columns of the first matrix: ");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter rows and columns of the second matrix: ");
            p = Convert.ToInt32(Console.ReadLine());
            q = Convert.ToInt32(Console.ReadLine());

            if (n != p)
            {
                Console.WriteLine("Matrix multiplication is not possible.");
            }
            else
            {
                Console.WriteLine("Elements of the first matrix: ");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                        a[i, j] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Elements of the second matrix: ");
                for (i = 0; i < p; i++)
                {
                    for (j = 0; j < q; j++)
                        b[i, j] = int.Parse(Console.ReadLine());
                }

                if (m == p && n == q)
                {
                    Console.WriteLine("Addition is possible: ");
                    for (i = 0; i < m; i++)
                    {
                        for (j = 0; j < n; j++)
                            c[i, j] = a[i, j] + b[i, j];
                    }

                    Console.WriteLine("Resultant matrix after addition: ");
                    for (i = 0; i < m; i++)
                    {
                        for (j = 0; j < n; j++)
                            Console.Write(c[i, j] + "\t");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Multiplication is possible: ");
                    for (i = 0; i < m; i++)
                    {
                        for (j = 0; j < q; j++)
                        {
                            c[i, j] = 0;
                            for (int k = 0; k < n; k++)
                            {
                                c[i, j] += a[i, k] * b[k, j];
                            }
                        }
                    }

                    Console.WriteLine("Resultant matrix after multiplication: ");
                    for (i = 0; i < m; i++)
                    {
                        for (j = 0; j < q; j++)
                            Console.Write(c[i, j] + "\t");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
