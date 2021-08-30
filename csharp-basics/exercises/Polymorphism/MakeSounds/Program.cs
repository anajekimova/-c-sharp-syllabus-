using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        public static void Main(string[] args)
        {
            var soundList = new List<ISound>
            {new Parrot(), new Firework(), new Parrot(), new Radio(), new Firework()};

            for(int i = 0; i < 4; i++)
            {
                soundList.ForEach(k => k.PlaySound());
            }
            Console.ReadKey();
        }
    }
}