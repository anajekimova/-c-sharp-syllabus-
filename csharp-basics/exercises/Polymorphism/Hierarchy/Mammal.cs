using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    abstract class Mammal:Animal
    {
        public string LivingRegion;

        protected Mammal(string name, int weight, string type, string region):
            base (name, weight, type)
        {
            LivingRegion = region;
        }

        public override string ToString()
        {
            return $"{AnimalType} [{AnimalName}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
