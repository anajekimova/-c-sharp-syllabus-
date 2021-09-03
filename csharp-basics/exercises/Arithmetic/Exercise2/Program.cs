using System;

namespace Exercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number");
            num = int.Parse(Console.ReadLine());
            var result = CheckEvenOrOdd(num);

            if(result)
            {
                Console.WriteLine("It is even");
            } 
            else
            {
                Console.WriteLine("It is  odd");
            }
            Console.WriteLine("Bue!");           
        }

        public static bool CheckEvenOrOdd(int input)
        {
            int check = input % 2;

            return check == 0;           
        }
    }
}
