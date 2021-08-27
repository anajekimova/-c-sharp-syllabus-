using System;

namespace Exercise6
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 111; i++)
            {
                Console.WriteLine(" " + ColoLoza(i));
                if (i % 11 == 0)
                    Console.WriteLine("");                
            }
        }

        public static string ColoLoza(int i)
        {
            string write = "";
            if (i % 15 == 0)
                write += "CozaLoza";
            else if (i % 3 == 0)
                write += "Coza";
            else if (i % 5 == 0)
                write +="Loza";
            else if (i % 7 == 0)
               write += "Woza";
            else if (i % 3 != 0 || i % 5 != 0 || i % 7 != 0)
                write += $"{i}";

            return write;
        }
    }
}