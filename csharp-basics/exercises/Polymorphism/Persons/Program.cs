using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Alksandra", "Japina", "Kurzemes 123, Riga", 23453, 80);
            var employer = new Employee("Aleksa", "Serga", "Salnas 7", "teacher", 23657);

            student.Display();
            employer.Display();

            Console.ReadKey();
        }
    }
}