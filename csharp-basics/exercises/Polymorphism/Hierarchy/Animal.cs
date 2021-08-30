using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    abstract class Animal
    {
        public string AnimalName { get; }
        public string AnimalType { get; }
        public double AnimalWeight { get; }
        public int FoodEaten { get; set; }

        public Animal(string name, int weight, string type)
        {
            AnimalName = name;
            AnimalWeight = weight;
            AnimalType = type;  
        }

        public abstract void MakeSound();
        public abstract bool Eat(Food input);
    }
}
