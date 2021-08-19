using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise4
{
    class Program
    {
        private static void Main(string[] args)
        {           
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black",
                "Grey",
                "Blue", 
                "Brown"
            };

            Console.WriteLine(string.Join(", ", colors));
            Console.Write("\n");
            
            string element = colors[0];
            Console.WriteLine("First element: " + element);
            Console.Write("\n");

            element = colors[2];
            Console.WriteLine("Third element: " + element);
            Console.ReadKey();
        }
    }
}
