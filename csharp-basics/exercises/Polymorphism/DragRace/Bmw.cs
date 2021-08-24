using System;

namespace DragRace
{
    public class Bmw:Car
    {
        private int _currentSpeed = 0;
        public string CarName()
        {
            return "Bmv";
        }

        public void SpeedUp() 
        {
            _currentSpeed+= 20;
        }

        public void SlowDown() 
        {
            _currentSpeed-= 20;
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