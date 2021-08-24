using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Zebra: Mammal
    {
        public Zebra(string type, string name, int weight, string region) :
            base(name, weight, type, region)
        {
            
        }

        public override void MakeSound()
        {
            Console.WriteLine("iiii");
        }

        public override bool Eat(Food foods)
        {
            if(foods is Vegetable)
            {
                FoodEaten = foods.Quantity;
                return true;
            }
            else
            {
                Console.WriteLine($"{AnimalType} are not eating that type of food!");
            }
        }
    }
}
