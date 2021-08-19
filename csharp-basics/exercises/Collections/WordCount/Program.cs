using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var text1 = File.ReadAllLines("../../lear.txt");
            var text2 = File.ReadAllText("../../lear.txt");

            Console.WriteLine($"Line = {text1.Count()}");

            string[] word = text2.Split(' ', '\'', '\n');
            Console.WriteLine($"Words = {word.Length}");

            int chars = 0;
            foreach (var i in text1)
            {
                var charString = i.ToString().ToCharArray();
                chars += charString.Length;
            }
            Console.WriteLine($"Chars = {chars}");
            Console.ReadKey();
        }
    }
}
