using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        /**
           * Origination:
           * Audi -> Germany
           * BMW -> Germany
           * Honda -> Japan
           * Mercedes -> Germany
           * VolksWagen -> Germany
           * Tesla -> USA
           */

        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            Console.WriteLine("List:");
            var list = array.ToList<string>();
            Console.WriteLine(string.Join(", ", list));
            Console.Write("\n");
            
            Console.WriteLine("Hash Set:");
            var hasSet = array.ToHashSet<string>();
            Console.WriteLine(string.Join(", ", list));
            Console.Write("\n");

            Console.WriteLine("Dictionary:");
            var dictionary = new Dictionary<string, string>()
            {
                {"Audi", "Q7"},{"BMW", "X6"},{"Honda", "Cr-v"},{"Mercedes", "C-180"},{"Volkswagen", "Passat 6"},{"Tesla", "Model 3"}
            };
            foreach (var i in dictionary)
            {
                Console.WriteLine($"{i.Key} -> {i.Value}");
            }
            Console.ReadKey();         
        }
    }
}
