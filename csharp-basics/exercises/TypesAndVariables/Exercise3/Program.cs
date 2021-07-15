using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            first();
            second();
            Console.ReadKey();
        }

        static void first()
        {
            String a = "1";
            int fixme = Int32.Parse(a);
            int b = 2;
            int c = 3;
            double d = 4;
            float e = 5;
            double sum =fixme + b + c + d + e;
            Console.WriteLine(sum);


           
        }

        static void second()
        {
            String a = "1";
            int fixme = Int32.Parse(a);
            int b = 2;
            int c = 3;
            double d = 4.2;
            float e = 5.3f;
            double sum = fixme + b + c + d + e;
            Console.WriteLine(sum.ToString("0.0"));

            
        }
    }
}
