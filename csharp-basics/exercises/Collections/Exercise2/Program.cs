using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        private static void Main(string[] args)
        {
            var mySet = new HashSet<string>();
            var name = string.Empty;
            Console.WriteLine("Enter name:");

            do
            {
                name = Console.ReadLine();
                mySet.Add(name);
            }
            while (name != string.Empty);

            foreach (var item in mySet)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}