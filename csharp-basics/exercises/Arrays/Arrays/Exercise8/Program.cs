using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random((int)DateTime.Now.Ticks);
            string[] wordBank = { "Dog", "Cat", "Informatic", "Orange", "Holiday" };

            string randomWord = wordBank[random.Next(0, wordBank.Length)];
            string wordTOUpper = randomWord.ToUpper();

            StringBuilder displayToPlayer = new StringBuilder(randomWord.Length);
            for (int i = 0; i < randomWord.Length; i++)
                displayToPlayer.Append('_');

            List<char> correctGuesses = new List<char>();
            List<char> incorrectGuesses = new List<char>();

            int move = 5;
            bool won = false;
            int lettersRevealed = 0;

            string input;
            char guess;

            while (!won && move > 0)
            {
                Console.WriteLine("Guess a Letter: ");

                input = Console.ReadLine().ToUpper();
                guess = input[0];

               if (correctGuesses.Contains(guess))
                {
                    Console.WriteLine($"You've already tried '{0}', and it was correct!", guess);
                    continue;
                }
                else if (incorrectGuesses.Contains(guess))
                {
                    Console.WriteLine("You've already tried '{0}', and it was wrong!", guess);
                    continue;
                }

                if (wordTOUpper.Contains(guess))
                {
                    correctGuesses.Add(guess);

                    for (int i = 0; i < randomWord.Length; i++)
                    {
                        if (wordTOUpper[i] == guess)
                        {
                            displayToPlayer[i] = randomWord[i];
                            lettersRevealed++;
                        }
                    }

                    if (lettersRevealed == randomWord.Length)
                        won = true;
                }
                else
                {
         
                    Console.WriteLine($"Nope, there's no '{guess}' in it!");
                    move--;
                }

                Console.WriteLine(displayToPlayer.ToString());
            }

            if (won)
                Console.WriteLine("You won!");
            else
                Console.WriteLine($"You lost! It was {guess}");

            Console.Write("Press ENTER to exit....");
            Console.ReadLine();
            Console.Read();


        }
    }
}
