using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    public class WordCount
    {
        static void Main(string[] args)
        {
           
            var text = File.ReadAllText("../../lear.txt");

            Console.WriteLine($"Word: {CounWord(text)}");
            Console.WriteLine($"Line: {WordLine(text)}");
            Console.WriteLine($"Char: {CharCount(text)}");
            Console.ReadKey();
        }

        public static int CounWord(string text)
        {
            string[] wordArr = text.Split(' ', '\'', '\n');
            int count = 0;

            foreach (var word in wordArr)
            {
                count++;
            }

            return count;
        }

        public static int WordLine(string text)
        {
            var lineCount = text.Split('\n').Length;
            return lineCount;
        }

        public static int CharCount(string text)
        {
            int chars = 0;
            foreach (var i in text)
            {
                var charString = i.ToString().ToCharArray();
                chars += charString.Length;
            }
            return chars;
        }
    }
}