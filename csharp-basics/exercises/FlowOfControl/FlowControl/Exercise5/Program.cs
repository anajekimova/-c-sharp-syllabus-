﻿using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string letter;
            Console.WriteLine("Enter letter:");
            letter = Console.ReadLine();

            int letterNum = 0;
            if (letter == "a" || letter == "b" || letter == "c")
                letterNum = 2;
            else if (letter == "d" || letter == "e" || letter == "f")
                letterNum = 3;
            else if (letter == "g" || letter == "h" || letter == "i")
                letterNum = 4;
            else if (letter == "j" || letter == "k" || letter == "l")
                letterNum = 5;
            else if (letter == "m" || letter == "n" || letter == "o")
                letterNum = 6;
            else if (letter == "p" || letter == "q" || letter == "r" || letter == "s")
                letterNum = 7;
            else if (letter == "t" || letter == "u" || letter == "v")
                letterNum = 8;
            else if (letter == "w" || letter == "x" || letter == "y" || letter == "z")
                letterNum = 9;
            else
                Console.WriteLine("Erro!");

            Console.WriteLine($"Letter number is {letterNum}");

            string lett;
            Console.WriteLine("Enter letter:");
            lett = Console.ReadLine();

            switch(lett)
            {
                case "a": case "b": case "c":
                    Console.WriteLine(2);
                    break;
                case "d": case "e": case "f":
                    Console.WriteLine(3);
                    break;
                case "g": case "h": case "i":
                    Console.WriteLine(4);
                    break;
                case "j": case "k": case "l":
                    Console.WriteLine(5);
                    break;
                case "m": case "n": case "o":
                    Console.WriteLine(6);
                    break;
                case "p": case "q": case "r": case "s":
                    Console.WriteLine(7);
                    break;
                case "t": case "u": case "v":
                    Console.WriteLine(8);
                    break;
                case "w": case "x": case "y": case "z":
                    Console.WriteLine(9);
                    break;
                default:
                    Console.WriteLine("Erro!");
                    break;
            }

        }
    }
}
