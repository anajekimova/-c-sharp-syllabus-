using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars, drivers, passengers, cars_not_driven, cars_driven;
            double seats_in_a_car, carpool_capacity;

            cars = 100; //cars
            seats_in_a_car = 4.0; //seats in a car
            drivers = 28; // drivers
            passengers = 90; // passengers
            //cars_not_driven  // free cars
            //cars_driven ; // cars driven at the moment
            //carpool_capacity = // carpool capacity
            //average_passengers_per_car = // average passengers per car
            cars_not_driven = cars - drivers;
            carpool_capacity = drivers * seats_in_a_car;
            cars_driven = cars - cars_not_driven;
            double average_passengers_per_car = passengers / cars_driven; 
            






            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + cars_not_driven + " empty cars today.");
            Console.WriteLine("We can transport " + carpool_capacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + average_passengers_per_car.ToString("0.00") + " in each car.");
            Console.ReadKey();
        }
        //decimal value = 123.456m;
        //Console.WriteLine("Your account balance is {0:C2}.", value);
// Displays "Your account balance is $123.46."

    }
}