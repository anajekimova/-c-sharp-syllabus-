using System;
using System.Collections.Generic;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            var num = int.Parse(Console.ReadLine());   
            
            if(Happy(num) == true )
            {
                Console.WriteLine("Number is happy.");
            }
            else
            {
                Console.WriteLine("Number is not happy.");
            }
        }

        public static bool Happy(int n)
        {
            var nums = new HashSet<int>();

            while(true)
            {
                var total = 0;
                while (n > 0)
                {
                    var digit = n % 10;
                    total += digit * digit;
                    n /= 10;
                }

                n = total;
                if(!nums.Add(n))
                {
                    return false;
                }
                else if(n == 1)
                {
                    return true;
                }

                Console.ReadKey();
            }
        }
    }
}
