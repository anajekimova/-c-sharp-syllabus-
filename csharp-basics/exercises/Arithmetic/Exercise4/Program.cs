using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            long intergar = 1L;
            int n = 10;

            for(int i = 1; i <= n; i++)
            {
                intergar *= i;
            }

            Console.WriteLine(intergar); 
        }
    }
}
