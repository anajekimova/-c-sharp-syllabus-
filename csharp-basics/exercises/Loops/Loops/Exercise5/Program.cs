using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord;
            string secondWord;
            

            Console.WriteLine("Please enter a first word:");
            firstWord = Console.ReadLine();
            Console.WriteLine("Pease enter a second word:");
            secondWord = Console.ReadLine();
            int dot = 30 - (firstWord.Length + secondWord.Length);

            Console.WriteLine(firstWord + new string('.', dot) + secondWord);
            Console.ReadLine();
        }
    }
}
