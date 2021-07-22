using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNumber;

            Console.WriteLine("Enter day number from 0 to 6: ");
            dayNumber = int.Parse(Console.ReadLine());

            if (dayNumber == 0)
                Console.WriteLine("Sunday");
            else if (dayNumber == 1)
                Console.WriteLine("Monday");
            else if (dayNumber == 2)
                Console.WriteLine("Tuesday");
            else if (dayNumber == 3)
                Console.WriteLine("Wednesday");
            else if (dayNumber == 4)
                Console.WriteLine("Thursday");
            else if (dayNumber == 5)
                Console.WriteLine("Friday");
            else if (dayNumber == 6)
                Console.WriteLine("Saturday");
            else
                Console.WriteLine("Not a valid day.");

            int dayN;
            Console.WriteLine("Enter number from 0 to 6");
            dayN = int.Parse(Console.ReadLine());

            switch (dayN)
            {
                case 0:
                    Console.Write("Sunday");
                    break;
                case 1:
                    Console.Write("Monday");
                    break;
                case 2:
                    Console.Write("Tuseday");
                    break;
                case 3:
                    Console.Write("Wednesday");
                    break;
                case 4:
                    Console.Write("Thursday");
                    break;
                case 5:
                    Console.Write("Friday");
                    break;
                case 6:
                    Console.Write("Saturday");
                    break;
                default:
                    Console.Write("Not a valid day.");
                    break;
            }
        }
    }
}
