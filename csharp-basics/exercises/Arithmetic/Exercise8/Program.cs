using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            double minimumWage = 8;
            double maxHour = 60;
            double basePay = 0;
            int hourWorked = 0;
            string employee;
            double totalSalary = 0;

            for (double i = 1; i <= 3; i++)
            {
                Console.WriteLine("Employee number:");
                employee = Console.ReadLine();
                Console.WriteLine("Enter hour:");
                hourWorked = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Base pay:");
                basePay = double.Parse(Console.ReadLine());

                if (hourWorked <= 40)
                {
                    totalSalary = basePay * hourWorked;
                    Console.WriteLine($"Your total salary is ${totalSalary}");
                }
                else if (hourWorked > 40)
                {
                    totalSalary = basePay * 40 + 1.5 * basePay * (hourWorked - 40);
                    Console.WriteLine($"Your total salary is ${totalSalary}");
                }

                if (hourWorked > maxHour)
                {
                    Console.WriteLine("You don`t need to  work so much!");
                }

            }

        }
    }
}






