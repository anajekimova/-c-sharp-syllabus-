using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie spider = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG");
            Movie casino = new Movie("Casino Royale", "Eon Productions", "PG­13");
            Movie glass = new Movie("Glass", "Buena Vista International", "Pg13");

            Console.WriteLine(spider.PrintMovie());
            Console.WriteLine(casino.PrintMovie());
            Console.WriteLine(glass.PrintMovie());
            Console.WriteLine("\n");

            Console.WriteLine("Movie with 'PG' raiting.");

            Movie[] collection = new Movie[] { spider, casino, glass };
            collection = Movie.GetPG(collection);

            foreach (var x in collection)
            {
                Console.WriteLine(x.PrintMovie());
            }
        }
    }
}
