using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            double  minutes;
            Console.WriteLine("Enter minute");
            minutes = double.Parse(Console.ReadLine());
            double hours = minutes / 60;
            double days = hours / 24;
            double  years = days / 365;

            Console.WriteLine($"Approximately it will be {days.ToString("0")} days  and {years.ToString("0")} years.");
        }
    }
}
