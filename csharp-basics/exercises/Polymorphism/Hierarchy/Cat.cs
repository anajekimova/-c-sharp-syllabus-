using System;
using System.Collections.Generic;
using System.Linq;
namespace Hierarchy
{
    public class Cat: Felime
    {
        private string _breed;
        public Cat(string type, string name, int weight,  string region, string breed) :
            base(name, weight, type, region)
        {
            _breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Mauu");
        }

        public override bool Eat(Food foods)
        {          
                FoodEaten = foods.Quantity;
                return true;           
        }

        public override string ToString()
        {
            return $"{AnimalType} {AnimalName} {_breed} {AnimalWeight} {LivingRegion} {FoodEaten}";
        }
    }
}
