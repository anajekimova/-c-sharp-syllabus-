using System;

namespace DragRace
{
    public class Tesla: Car
    {
        private int _currentSpeed = 0;

        public string CarName()
        {
            return "Tesla";
        }

        public void SpeedUp() 
        {
            _currentSpeed+=5;
        }

        public void SlowDown() 
        {
            _currentSpeed-= 5;
        }

        public string ShowCurrentSpeed() 
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine() 
        {
            Console.WriteLine("-- silence ---");
        }
    }
}