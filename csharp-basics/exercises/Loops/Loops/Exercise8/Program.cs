using System;

namespace Exercise8
{
    class AsciiFigure
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());

            for(int i= 0; i< num; i++)
            {
                Console.WriteLine("".PadLeft(((num- i) *4) - 4, '/') + "".PadLeft(i* 8, '*')+ "".PadLeft(((num-i) * 4)- 4, '\\'));
            }
            Console.ReadKey();
        }
    }
}
