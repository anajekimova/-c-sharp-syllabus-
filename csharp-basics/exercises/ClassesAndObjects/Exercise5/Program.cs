using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int day, month, year;

            Console.WriteLine("Enter day:");
            day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter month:");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter year:");
            year = int.Parse(Console.ReadLine());

            Date DateTest = new Date(day, month, year);
            Console.WriteLine(DateTest.PrintDays());
        }
    }
}
