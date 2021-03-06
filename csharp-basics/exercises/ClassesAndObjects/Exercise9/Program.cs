using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6); 

            Console.WriteLine($"({p1._x}, {p1._y})");
            Console.WriteLine($"({p2._x}, {p2._y})");
            Console.WriteLine("\n");

            Point.SwapPoints(Point p1, Point p2);

            Console.WriteLine($"({p1._x}, {p1._y})");
            Console.WriteLine($"({p2._x}, {p2._y})");
        }
    }
}
