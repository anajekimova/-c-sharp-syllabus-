using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Mouse: Mammal
    {
        public Mouse(string name, int weight, string type, string region): 
            base(name, weight, type, region)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Pi pi pi ");
        }

        public override bool Eat(Food foods)
        {
            if (foods is Vegetable)
            {
                FoodEaten = foods.Quantity;
                return true;
            }
            else
            {
                Console.WriteLine($"{AnimalType} are not eating that type of food!");
                return false;
            }
        }
    }
}
