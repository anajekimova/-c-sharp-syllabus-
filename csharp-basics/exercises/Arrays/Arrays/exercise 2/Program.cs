using System;

namespace Exercise2
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var sum = 0;

            Console.WriteLine("Please enter a min number");
            int minNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a max number");
            int maxNumber = int.Parse(Console.ReadLine());
            var slice = myArray[minNumber..maxNumber];

           for(int i = 0; i < slice.Length; i++)
            {
                sum += slice[i];
            }

            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
        }
    }
}
