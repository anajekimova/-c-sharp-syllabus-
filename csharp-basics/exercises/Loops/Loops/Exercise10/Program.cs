using System;

namespace Exercise10
{
    class NumberSquare
    {
        static void Main(string[] args)
        {
            int min;
            int max;

            Console.WriteLine("Enter min number:");
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("Entere max number: ");
            max = int.Parse(Console.ReadLine());

            for (int i = 0; i <= max - min; i++)
            {
                for(int j= min; j<= max; j++)
                {
                    if (j + i > max)
                    {
                        Console.Write(j + i - max + min - 1);
                    }
                    else
                    {
                        Console.Write(j + i);
                    }
                }
                Console.WriteLine("");
                Console.ReadKey();
            }
        }
    }
}
