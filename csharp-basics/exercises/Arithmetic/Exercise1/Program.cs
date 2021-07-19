using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("Enter number");
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());
            double sum = num1 + num2;
            double difference = num1 - num2;
            double difference1 = num2 - num1;

            double num = 15;
           if (num1 == num || num2 == num)
            {
                Console.WriteLine("It true!");
            } 
            else if(sum == num || difference == num || difference1 == num)
            {
                Console.WriteLine("It true!");
            } else
            {
                Console.WriteLine("It false!");
            }

            }  
        }
    }
   
