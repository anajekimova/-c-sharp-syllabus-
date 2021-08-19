using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var  animals = new List<string> { "Panda", "Rabbit", "Dog" };
            Console.WriteLine(string.Join(", ", animals));
            Console.Write("\n");

            animals.Add("Lion");
            animals.Add("Fox");
            animals.Add("Tiger");
            animals.Add("Cat");
            animals.Add("Monkey");
            animals.Add("Koala");
            animals.Add("Gorilla");
            animals.Add("Leopard");
            animals.Add("Wolf");
            animals.Add("Camel");
            
            Console.WriteLine(string.Join(", ", animals));
            Console.Write("\n");

            animals.Insert(5, "Zebra");
            Console.WriteLine(string.Join(", ", animals));
            Console.Write("\n");

            animals[animals.Count - 1] = "Pantera";
            Console.WriteLine(string.Join(", ", animals));
            Console.Write("\n");

            animals.Sort();
            Console.WriteLine(string.Join(", ", animals));
            Console.Write("\n");

            if (animals.Contains( "Foobar"))
            {
                Console.WriteLine("Foobar is here.");
            }
            else
            {
                Console.WriteLine("Foobar no here.");
            }
            Console.Write("\n");

            foreach (var i in animals)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
