using System;

namespace Exercise_7
{
    class Piglet
    {
        static void Main(string[] args)
        {
            Console.Write("Welcom to Piglet!");
            int sum = 0;
            string answer;

            do
            {
                Random rand = new Random();
                int nums = rand.Next(1, 6);
                if (nums != 1)
                {
                    sum = sum + nums;
                    Console.WriteLine($"You rolled a {sum} !");
                }
                else
                {
                    sum = 0;
                    break;
                }

                Console.WriteLine("Roll again? y/n:");
                answer = Console.ReadLine();
            } while (answer == "n");
            Console.WriteLine($"You got {sum} points.");
            Console.ReadLine();
        }
    }
}
