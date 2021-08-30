using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Tiger: Felime
    {
        public Tiger(string name, int weight, string type, string region) :
            base(name, weight, type, region)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("rrrrr");
        }

        public override bool Eat(Food foods)
        {
            if (foods is Meat)
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

            public override string ToString()
        {
            return $"{AnimalType} {AnimalName}  {AnimalWeight} {LivingRegion} {FoodEaten}";
        }
    }
 }
