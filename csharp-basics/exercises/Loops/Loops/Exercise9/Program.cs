using System;

namespace Exercise9
{
    class RollTwoDice
    {
        static void Main(string[] args)
        {
            int sum;
            Console.WriteLine("Enter sum from 2 to 12:");
            sum = int.Parse(Console.ReadLine());
            int result;

            do
            {
                Random rand = new Random();
                int nums1 = rand.Next(1, 7);
                int nums2 = rand.Next(1, 7);
                result = nums1 + nums2;
                Console.WriteLine($"{nums1} and {nums2} = {result}");
            } while (sum != result);
            Console.ReadKey();     
        }
    }
}
