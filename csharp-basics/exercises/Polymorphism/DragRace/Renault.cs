using System;

namespace DragRace
{
    public class Renault : Car
    {
        private int _currentSpeed = 0;
        public string CarName()
        {
            return "Renault";
        }

        public void SpeedUp()
        {
            _currentSpeed += 30;
        }

        public void SlowDown()
        {
            _currentSpeed -= 10;
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
