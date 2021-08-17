using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        public static SortedDictionary<string, int> information = new SortedDictionary<string, int>();
        private int _number;
        private string _name;

        public PhoneDirectory(string name, int number)
        {
            _number = number;
            _name = name;
            information.Add(name, number);
        }

        public void PrintNameNumber()
        {
            Console.WriteLine($"Name: {_name}, Numer: {_number}");
        }

        public static void Print()
        {
            foreach (KeyValuePair<string, int> key in information)
            {
                Console.WriteLine(key.Key, key.Value);
            }
        }

        public static void GetNumber(string name)
        {
            bool found = false;
            foreach (KeyValuePair<string, int> pair in information)
            {
                if (pair.Key == name)
                {
                    Console.WriteLine($"{pair.Value} - this number is owned by a {pair.Key}");
                    found = true;
                }
                else if(found == false)
                {
                    Console.WriteLine($"Person not found");
                    found = false;
                }
            }
        }
    }
}
