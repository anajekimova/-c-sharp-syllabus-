
using System;

namespace GravityCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            const double gravity = -9.81; ;
            double initialVelocity = 0.0;
            double initialPosition = 0.0;
            double fallingTime = 10;
            string finalPosition = CalculatedGravety(gravity, initialVelocity, initialPosition, fallingTime);
            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + finalPosition + " m.");
            Console.ReadKey();
        }
        public static string CalculatedGravety(double gravity, double initVelocdity, double initPosition, double fallingTime)
        {
            if (initPosition >= 0 && initPosition >= 0 && fallingTime >= 0)
            {
                double finalPosition = 0.5 * gravity * Math.Pow(fallingTime, 2) + initPosition + initVelocdity * fallingTime;
                return finalPosition.ToString();
            }

            return "All data must be positive";
        }
    }
}
