using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            int[] arr = new int[size];
            Random randName = new Random();

            for (int i = 0; i < size; i++)
            {
                arr[i] = randName.Next(1, 100);
                Console.WriteLine(arr[i] + " ");
            }

            arr[9] = -7;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i] + "");
            }
        }
    }
}

