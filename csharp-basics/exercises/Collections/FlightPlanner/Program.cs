using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FlightPlanner
{
    public class Program
    {
        private const string Path = "../../flights.txt";
        private static List<string> _flightPlan = new List<string>();
        private static List<Tuple<string, string>> _flight = new List<Tuple<string, string>>();
        private static List<string> _cities = new List<string>();

        public static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);
            foreach (var s in readText)
            {
                _flightPlan.Add(s);
            }
            _flightPlan.ForEach(Console.WriteLine);

            foreach (var flight in readText)
            {
                var write = flight.Replace("-", " ").Split('>');
                _flight.Add(new Tuple<string, string>(write[0].Trim(), write[1].Trim()));
            }

            foreach (var c in _flight)
            {
                _cities.Add(c.Item1);
                _cities.Add(c.Item2);
            }

            var choise = _cities.Distinct().ToList();
            bool input = true;
            while (input)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("To display list of the cities press 1");
                Console.WriteLine("To exit program press #");
                var ourCoise = Console.ReadLine();
                Console.WriteLine();

                if (ourCoise == "1")
                {
                    Console.WriteLine("List of cities:");
                    _cities.ForEach(Console.WriteLine);
                    input = false;
                    Travel();
                }
                else if (ourCoise == "#")
                {
                    break;
                }
            }
            Console.ReadKey();
        }

        public static void Travel()
        {
            Console.WriteLine("To select a city from which you would like to start press 1:");
            var ourChoise2 = Console.ReadLine();

            if (ourChoise2 == "1")
            {
                var city = " ";
                var rest = "";
                bool isActive1 = true;
                bool isActive2 = true;

                while (isActive1)
                {
                    Console.WriteLine("Enter your city:");
                    city = Console.ReadLine();

                    foreach (var a in _flight)
                    {
                        if (a.Item1 == city)
                        {
                            Console.WriteLine($"{a.Item1} -> {a.Item2}");
                            isActive2 = false;
                        }
                    }
                }

                var firstCity = city;
                var copy = " ";

                while (isActive2)
                {
                    Console.Write("Enter our next city: ");
                    var nextCity = Console.ReadLine();
                    Console.WriteLine();

                    if (nextCity == copy)
                    {
                        Console.WriteLine($"You are in this city {nextCity}");
                    }
                    else if (nextCity == firstCity)
                    {
                        Console.WriteLine($"You have returned to {firstCity}");
                        isActive2 = false;
                        break;
                    }

                    foreach (var b in _flight)
                    {
                        if (nextCity == b.Item1)
                        {
                            Console.WriteLine($"{b.Item1}  ->  {b.Item2}");
                        }
                    }
                    foreach (var d in _flight)
                    {
                        if (nextCity == copy)
                        {
                            break;
                        }
                        else if (nextCity == d.Item1)
                        {
                            rest += nextCity + ", ";
                            break;
                        }
                    }
                    copy = nextCity;
                }
                if (rest.Contains(","))
                {
                    rest = rest.Remove(rest.Length - 2).Trim();
                    Console.WriteLine($"Your route was:  { firstCity} ,  { rest}");
                }
            }
        }
    }
}