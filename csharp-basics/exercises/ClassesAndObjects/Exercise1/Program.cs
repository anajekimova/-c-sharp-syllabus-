using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product mouse = new Product("Logitech mouse", 70.00 , 14);
            Product phone = new Product("iPhone 5s", 999.99, 3 );
            Product projector = new Product("Epson EB-U05", 440.46 , 1 );

            mouse.PrintPrice();
            phone.PrintPrice();
            projector.PrintPrice();

            Console.WriteLine("After changes  ");
            mouse.ChangeAmount(8);
            mouse.PrintPrice();

            phone.ChangePrice(450);
            phone.PrintPrice();

            projector.ChangeAmount(3);
            projector.ChangePrice(854.78);
            projector.PrintPrice();
            
            Console.ReadKey();
        }
    }
}
