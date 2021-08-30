using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    class Employee: Person
    {
        private string _jobTitle;

        public Employee(string firstName, string lastName, string adress, string jobTitle, int id): base(firstName, lastName, adress, id)
        {
            _jobTitle = jobTitle;

        }

        public string JobTitle => _jobTitle;

        public override void Display()
        {
            Console.WriteLine($"{FirstName} {LastName}, lives at {Adress} and work as {_jobTitle}. Id: {Id}");
        }
    }
}
