using System;

namespace DragRace
{
    public class Toyota : Car, Icar
    {
        private int _currentSpeed = 0;

        public string CarName()
        {
            return "Toyota";
        }

        public void SpeedUp()
        {
            _currentSpeed += 25;
        }

        public void SlowDown()
        {
            _currentSpeed -= 15;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine()
        {
            _currentSpeed += 50;
        }

        public void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}