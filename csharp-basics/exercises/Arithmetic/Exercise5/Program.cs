using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int returnValue = random.Next(1, 100);
            int userChoise;
            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
            userChoise = int.Parse(Console.ReadLine());
            int answer = 0;

            while (answer != userChoise)
            {
                if (userChoise > answer)
                {
                    Console.WriteLine("Sorry, you are too high.");
                }
                else if (userChoise < answer)
                {
                    Console.WriteLine("Sorry, you are too low.");
                }
                break;
                }

                Console.WriteLine("Well done! The answer was " + returnValue);
            }
        }
    }


