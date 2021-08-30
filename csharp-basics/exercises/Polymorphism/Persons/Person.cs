using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private string _adress;
        private int _id;

        public Person(string firstName, string lastName, string adress, int id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _adress = adress;
            _id = id;
        }

        public string FirstName => _firstName;
        public string LastName => _lastName;
        public string Adress => _adress;
        public int Id => _id;

        public virtual void Display()
        {
            Console.WriteLine($"{_firstName} {_lastName}. Lives at {_adress}. Id: {_id}");
        }
    }
}
