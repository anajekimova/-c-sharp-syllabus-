using System;
using System.Collections.Generic;
namespace MakeSounds
{
    public class Parrot : ISound
    {
        public void PlaySound()
        {
            Console.WriteLine("parparpampam");
        }
    }
}

