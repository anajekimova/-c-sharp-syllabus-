using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            int average;
            const int lowerBound = 1;
            const int upperBound = 100;
    
            for (var number = lowerBound; number <= upperBound; ++number)
            {
                sum += number;
            }
            int count = lowerBound + upperBound;
            average = sum / count;
            Console.WriteLine(sum);
            Console.WriteLine(average.ToString("0.0"));
        }
    }
}
