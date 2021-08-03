using System;

namespace Exercise2
    {
        class Program
        {
            static void Main(string[] args)
            {
                int i, n;

                Console.WriteLine("Input number of terms : ");
                n = Convert.ToInt32(Console.ReadLine());

                for (i = 1; i <= n; i++)
                {
                    int pow = i;
                    for (int j = 1; j < n; j++)
                    {
                        pow *= i;
                    }
                    Console.WriteLine($"{i}^{n} = {pow}");
                }
                Console.ReadKey();
            }
        }
    }

    
