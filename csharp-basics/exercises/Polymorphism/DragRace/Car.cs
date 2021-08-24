using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    interface Car
    {
        string CarName();
        void SpeedUp();
        void SlowDown();
        string ShowCurrentSpeed();
        void StartEngine();
    }
}
