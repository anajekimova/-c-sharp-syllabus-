using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    class Student: Person
    {
        private double _gpa;

        public Student(string firstName, string lastName, string adress, int id, double gpa): base (firstName, lastName,  adress,  id)
        {
            _gpa = gpa;
        }

        public double Gpa => _gpa;

        public override void Display()
        {
            Console.WriteLine($"{FirstName} {LastName} lives at {Adress} and has {_gpa} point. Id: {Id}");
        }
    }
}
