using System;

namespace Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("Enter number");
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());
            var result = CheckNumber(num1, num2);
            if (result)
            {
                Console.WriteLine("It is  true!");
            }
            else
            {
                Console.WriteLine("It is false!");
            }
        }

        public static bool CheckNumber(double input1, double input2)
        {
            double sum = input1 + input2;
            double difference = input1 - input2;
            double difference1 = input2 - input1;
            double num = 15;

            return input1 == num || input2 == num || sum == num || difference == num || difference1 == num;
        }
    }
}