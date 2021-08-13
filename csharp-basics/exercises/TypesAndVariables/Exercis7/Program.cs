using System;

namespace Exercis7
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            Console.WriteLine("Enter the word");
            word = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                    count++;
            }

            Console.WriteLine($"{count}");
        }
    }
}
