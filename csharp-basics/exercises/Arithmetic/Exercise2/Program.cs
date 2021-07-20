using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number");
            num = int.Parse(Console.ReadLine());
            int check = num % 2;
            if(check == 0)
            {
                Console.WriteLine("It is even");
            } else
            {
                Console.WriteLine("It is  odd");
            }
            Console.WriteLine("Bue!");
            
        }
    }
}
