using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = new int[20];
            Random random = new Random();
            for( int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = random.Next(0, 100);
                Console.Write(myArr[i] + " ");
            }

            int userChoise;
            Console.WriteLine("Please choose the number position which you want to know: .");
            userChoise = int.Parse(Console.ReadLine());
            int numPosition = Array.IndexOf(myArr, userChoise);

            Console.WriteLine($"Your number position is {numPosition + 1}");
            Console.ReadKey();
        }
    }
}
