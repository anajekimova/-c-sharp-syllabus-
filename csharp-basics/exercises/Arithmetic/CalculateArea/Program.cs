using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice; 

            do
            {
                
                choice = getMenu();

                if (choice == 1)
                {
                    Console.WriteLine("You chose 1");
                    CalculateCircleArea();
                    Console.ReadKey();
                }
                else if (choice == 2)
                {
                    CalculateRectangleArea();
                    Console.ReadKey();
                }
                else if (choice == 3)
                {
                    CalculateTriangleArea();
                    Console.ReadKey();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Thanks for calculating!");
                    Console.ReadKey();
                }

            } while (choice != 4);
        }

        public static int getMenu()
        {

            int userChoice;
           
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Console.ReadKey();
            
            int.TryParse(keyboard.KeyChar.ToString(), out userChoice);

            while (userChoice < 1 || userChoice > 4)
            {
                Console.WriteLine("Please enter a valid range: 1, 2, 3, or 4: ");
                keyboard = Console.ReadKey();
                userChoice = keyboard.KeyChar;
            }

            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            
            Console.WriteLine("What is the circle's radius? ");       
            var keyboard = Console.ReadLine();
            decimal.TryParse(keyboard, out var radius);
            Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(radius));
        }

        public static void CalculateRectangleArea()
        {

            var keyboard = Console.ReadKey();
            Console.WriteLine("What is th rectangle`s length? ");
            decimal.TryParse(Console.ReadLine(), out var length);          
            Console.WriteLine("What is rectangle`s width? ");
            decimal.TryParse(Console.ReadLine(), out var width);
            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfTriangle(length, width));
        }

        public static void CalculateTriangleArea()
        {
           
            var keyboard = Console.ReadKey();
            Console.WriteLine("Enter length of the triangle's base: ");
            decimal.TryParse(Console.ReadLine(), out var ground);
            Console.WriteLine("Enter triangle's height: ");
            decimal.TryParse(Console.ReadLine(), out var height);
            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfRectangle(ground, height));
        }
    }
}
