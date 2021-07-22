using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1;
            int input2;
            int input3;
            int large;

            Console.Write("Input the 1st number: ");
            input1 = int.Parse(Console.ReadLine());
            Console.Write("Input the 2nd number: ");
            input2 = int.Parse(Console.ReadLine());
            Console.Write("Input the 3rd number: ");
            input3 = int.Parse(Console.ReadLine());

            if (input1 > input2 && input1 > input2)
                large = input1;
            else if (input2 > input1 && input2 > input3)
                large = input2;
            else
                large = input3;

            Console.WriteLine("Largest number is {0}", large);
            Console.ReadLine();
        }
    }
}