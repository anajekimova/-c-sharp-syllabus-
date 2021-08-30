using System;

namespace DragRace
{
    public class Lexus: Car, Icar
    {
        private int _currentSpeed = 0;

        public string CarName()
        {
            return "Lexus";
        }

        public void SpeedUp() 
        {
            _currentSpeed+=15;
        }

        public void SlowDown() 
        {
            _currentSpeed-= 15;
        }

        public string ShowCurrentSpeed() 
        {
            return _currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine() 
        {
            _currentSpeed+= 60;
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}