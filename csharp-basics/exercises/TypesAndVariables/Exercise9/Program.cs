using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance;
            Console.WriteLine("Enter distance");
            distance = Convert.ToSingle(Console.ReadLine());
            float hour;
            Console.WriteLine("Enter hour");
            hour = Convert.ToSingle(Console.ReadLine()); ;
            float minute;
            Console.WriteLine("Enter minute");
            minute = Convert.ToSingle(Console.ReadLine());
            float seconde;
            Console.WriteLine("Enter seconde");
            seconde = Convert.ToSingle(Console.ReadLine()); ;
            float timeSec = (hour * 3600) + (minute * 60) + seconde;
            float speedMetreSeconde = distance / timeSec;
            float  speedKmh = (distance / 1000.0f) / (timeSec / 3600.0f);
            float speedMileH = speedKmh / 1.609f;

            Console.WriteLine($"Input distance in meters: {distance}");
            Console.WriteLine($"Input hour: {hour}");
            Console.WriteLine($"Input minutes: {minute}");
            Console.WriteLine($"Input seconds: {seconde}");
            Console.WriteLine($"Expected Output :");
            Console.WriteLine($"Your speed in meters/second is {speedMetreSeconde}");
            Console.WriteLine($"Your speed in km/h is {speedKmh}");
            Console.WriteLine($"Your speed in miles/h is {speedMileH}");

        }
    }
}
