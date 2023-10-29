
using System;
class Enumtype
{
    enum Direction
    {
        North,
        East,
        West,
        South
    }
    public static void Main()
    {
        Direction d1 = 0;
        Direction d2 = Direction.East;
        Direction d3 = Direction.West;
        Direction d4 = (Direction)12;
        Console.WriteLine("d1 = " + d1);
        Console.WriteLine("d2 = " + d2);
        Console.WriteLine("d3 = " + d3);
        Console.WriteLine("d4 = " + d4);

    }
}