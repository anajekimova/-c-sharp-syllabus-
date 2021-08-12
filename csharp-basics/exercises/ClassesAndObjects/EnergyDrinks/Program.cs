using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDrinks
{
    class Program
    {
        private const int _NumberedSurveyed = 12467;
        private const double _PurchasedEnergyDrinks = 0.14;
        private const double _PreferCitrusDrinks = 0.64;

        private static void Main(string[] args)
        {
             Console.WriteLine("Total number of people surveyed " + _NumberedSurveyed);
             Console.WriteLine($"Approximately {CalculateEnergyDrinkers(_NumberedSurveyed)} bought at least one energy drink");
             Console.WriteLine($"{CalculatePreferCitrus(_NumberedSurveyed)} of those prefer citrus flavored energy drinks.");
             Console.ReadLine();
        }

        static double CalculateEnergyDrinkers(int numberSurveyed)
        {
            return _NumberedSurveyed * _PurchasedEnergyDrinks;
        }

        static double CalculatePreferCitrus(int numberSurveyed)
        {
            return _NumberedSurveyed * _PreferCitrusDrinks;
        }
    }
}
