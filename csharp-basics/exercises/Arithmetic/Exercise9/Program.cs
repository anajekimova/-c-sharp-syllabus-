using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight;
            double height;

            Console.WriteLine("Enter your weight in kg: ");
            weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Entere your height in m: ");

            height = double.Parse(Console.ReadLine());
            double bmi = weight / (height * height);
            if (bmi >= 18.5 || bmi <= 24.9)
                Console.WriteLine($"Bmi is healthy.");
            else if (bmi < 18.5)
                Console.WriteLine($"BMI is underweight.{bmi}");
            else if (bmi < 24.9 )
                Console.WriteLine($"BMI is overweight. ");
        }
    }
}
