using System;

namespace Exercise7
{
    class DogTest
    {
        static void Main(string[] args)
        {
            var dogName1 = new Dog("Max", "male", "Lady", "Rocky");
            var dogName2 = new Dog("Rocky", "male", "Molly", "Sam");
            var dogName3 = new Dog("Sparky", "male", null, null);
            var dogName4 = new Dog("Buster", "male", "Lady", "Sparky");
            var dogName5 = new Dog("Sam", "male", null, null);
            var dogName6 = new Dog("Lady", "female", null, null);
            var dogName7 = new Dog("Molly", "female", null, null);
            var dogName8 = new Dog("Coco", "female", "Molly", "Buster");

            Console.WriteLine(dogName1.PrintDog());
            Console.WriteLine(dogName2.PrintDog());
            Console.WriteLine(dogName4.PrintDog());
            Console.WriteLine(dogName8.PrintDog());
            Console.WriteLine("\n");

            dogName8.FatherName();
            dogName3.FatherName();

            dogName2.HasSameMotherAs(dogName8);
        }
    }
}
