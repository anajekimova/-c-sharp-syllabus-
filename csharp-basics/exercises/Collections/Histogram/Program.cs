using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        private const string Path = "../../midtermscores.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllText(Path);
            var input = readText.Split(' ');
            var point = new List<string>();
            point.Add("00-09");
            point.Add("10-19");
            point.Add("20-29");
            point.Add("30-39");
            point.Add("40-49");
            point.Add("50-59");
            point.Add("60-69");
            point.Add("70-79");
            point.Add("80-89");
            point.Add("90-99");
            point.Add("100");

            foreach (var s in input)
            {
                var nums = int.Parse(s) / 10;
                point[nums] += "*";
            }

            foreach(var k in point)
            {
                Console.WriteLine(k);
            }
            Console.ReadLine();
        }
    }
}
