using System;

namespace Exercise6
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a number:");
            num = int.Parse(Console.ReadLine());

            for(var i= 1; i< num; i++)
            {
                if(num % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                else if(num % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                else if(num % 15 == 0)
                {
                    Console.Write("FizzBuzz");
                }
                else
                {
                    Console.Write(i + " ");
                }
                if (num % 20 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
