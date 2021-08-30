using System;
using System.Collections.Generic;
using System.Linq;

namespace DragRace
{
    public class Audi: Car
    {
        private int _currentSpeed = 0;

        public string CarName ()
        {
            return "Audi";
        }

        public void SpeedUp() 
        {
            _currentSpeed+= 10;
        }

        public void SlowDown() 
        {
            _currentSpeed-= 10;
        }

        public string ShowCurrentSpeed() 
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}