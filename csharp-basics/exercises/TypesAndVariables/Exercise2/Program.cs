﻿using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
           

            string myName = "Zed A. Shaw";
            int myAge = 35;
            int myHeight = 74;  
            int myWeight = 180; 
            string myEyes = "Blue";
            string myTeeth = "White";
            string myHair = "Brown";
            string name = myName;
            int age = myAge;
            double weight = myWeight * 0.453592;
            double height = myHeight * 2.54;
            string eyes = myEyes;
            string teeth = myTeeth;
            string hair = myHair;

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + height.ToString("0.00") + " centimeters tall.");
            Console.WriteLine("He's " + weight.ToString("0.00") + " kilos heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + age + ", " + height.ToString("0.00") + ", and " + weight.ToString("0.00")
                               + " I get " + (age + height + weight).ToString("0.00") + ".");

            Console.ReadKey();
        }
    }
}