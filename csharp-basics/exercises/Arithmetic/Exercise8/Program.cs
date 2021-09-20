using System;

namespace Exercise8
{
    public static class Program
    {
        static void Main(string[] args)
        {
            
            int hourWorked = 0;
            string employee;

            for (double i = 1; i <= 3; i++)
            {
                Console.WriteLine("Employee number:");
                employee = Console.ReadLine();
                Console.WriteLine("Enter hour:");
                hourWorked = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Base pay:");
                double basePay = double.Parse(Console.ReadLine());

                Console.WriteLine(" " + CheckHours(hourWorked, basePay));
            }
        }

        public static string CheckHours(int hour, double basPay)
        {
            double totalSalary = 0;           
            string write = "";
            int maxHour = 60;
            if (hour <= 40)
            {
                totalSalary = basPay * hour;
                write = $"Your total salary is ${totalSalary}";
            }
            else if (hour > 40)
            {
                totalSalary = basPay * 40 + 1.5 * basPay * (hour - 40);
                write = $"Your total salary is ${totalSalary}";
            }

            if (hour > maxHour)
            {
                write = "You don`t need to  work so much!";
            }
            return write;
        }

    }
}