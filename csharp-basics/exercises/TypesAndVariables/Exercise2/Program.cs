using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            String myName, myEyes, myTeeth, myHair;
            int myAge, myHeight, myWeight;

            myName = "Zed A. Shaw";
            myAge = 35;
            myHeight = 74;  
            myWeight = 180; 
            myEyes = "Blue";
            myTeeth = "White";
            myHair = "Brown";
            string name = myName;
            int age = myAge;
            double weight = myWeight * 0.453592;
            double height = myHeight * 2.54;
            string eyes = "Blue";
            string teeth = "White";
            string hair = "Brown";

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