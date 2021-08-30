using System;
using System.Collections.Generic;
using System.Linq;

namespace DragRace
{
    public class Program
    {

        private static void Main(string[] args)
        {
            var carList = new List<Car>();
            var car1 = new Audi();
            var car2 = new Tesla();
            var car3 = new Bmw();
            var car4 = new Lexus();
            var car5 = new Renault();
            var car6 = new Toyota();

            carList.Add(car1);
            carList.Add(car2);
            carList.Add(car3);
            carList.Add(car4);
            carList.Add(car5);
            carList.Add(car6);

            Car fasrteCar = null;
            int maxSpeed = 0;

            for (var i = 0; i < 10; i++)
            {
               foreach(var c in carList)
                {
                    c.SpeedUp();
                    int speed = int.Parse(c.ShowCurrentSpeed());
                    if (maxSpeed < speed)
                    {
                        fasrteCar = c;
                        maxSpeed = speed;
                    }

                    if(i == 2)
                    {
                        Icar boostSpeed = c as Icar;

                        if (boostSpeed != null)
                        {
                            boostSpeed.UseNitrousOxideEngine();
                        }
                    }  
                }
            }

            Console.WriteLine($"The faster car is {fasrteCar.CarName()} and car speed is {maxSpeed}");
            Console.ReadKey();
        }
    }
}