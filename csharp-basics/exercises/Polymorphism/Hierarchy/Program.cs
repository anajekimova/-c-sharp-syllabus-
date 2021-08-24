using System;
using System.Collections.Generic;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = new List<Animal>();
            do
            {
                Console.WriteLine("Please write: Animal type, Animal name ,  weight, Animal living region. If animal type is cate please write breed. ");
                var animal1 = Console.ReadLine();
                string[] animalArr = animal1.Split(" ");

                if (animalArr[0] == "Cat" || animalArr[0] == "cat")
                {
                    animal.Add(new Cat(animalArr[0], animalArr[1], animalArr[3], animalArr[4], Convert.ToString(animalArr[2])));
                }

                else if (animalArr[0] == "Tiger" || animalArr[0] == "tiger")
                {
                    animal.Add(new Tiger(animalArr[0], animalArr[1], animalArr[3], animalArr[4], Convert.ToString(animalArr[2])));
                }

                else if (animalArr[0] == "Mouse" || animalArr[0] == "mouse")
                {
                    animal.Add(new Mouse(animalArr[0], animalArr[1], animalArr[3], Convert.ToString(animalArr[2])));
                }
                else if (animalArr[0] == "Zebra" || animalArr[0] == "zebra")
                {
                    animal.Add(new Zebra(animalArr[0], animalArr[1], animalArr[3], Convert.ToString(animalArr[2])));
                }
                else if (animalArr[0] == "End" || animalArr[0] == "end")
                {
                    break;
                }

                string[] animalArr2 = animal1.Split(" ");

                if (animalArr2[0] == "Meat" || animalArr2[0] == "meat")
                {
                    if (animal[animal.Count - 1].Eat(new Meat(Convert.ToInt16(animalArr2[1]))))
                    {
                        Console.WriteLine(animal[animal.Count - 1]);
                    }
                }
                else if (animalArr2[0] == "Vegetable" || animalArr2[0] == "vegetable")
                {
                    if (animal[animal.Count - 1].Eat(new Vegetable(Convert.ToInt16(animalArr2[1]))))
                    {
                        Console.WriteLine(animal[animal.Count - 1]);
                    }
                }
                else
                {
                    Console.WriteLine("It not correct.");
                    break;

                }

                {
                    while (true)
                    {
                        Console.WriteLine(string.Join(",", animal));
                        Console.ReadKey();
                    }
                }
            }
         }
    }
}

        
    
