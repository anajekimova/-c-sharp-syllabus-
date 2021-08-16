using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise7
{
    class Dog
    {
        private string _name;
        private string _sex;
        private string _mother;
        private string _father;

        public Dog(string name, string sex, string mother, string farher)
        {
            _name = name;
            _sex = sex;
            _mother = mother;
            _father = farher;
        }

        public void FatherName()
        {
            if(_name == null)
            {
                Console.WriteLine("Unknown");
            }
            else
            {
                Console.WriteLine(_father);
            }
        }

        public void HasSameMotherAs(Dog name)
        {
            if(_mother == name._mother)
            {
                Console.WriteLine($"{_name} and {name._name} has a same mother.");
            }
            else
            {
                Console.WriteLine($"{_name} and {name._name} doesn't have a same mother. ");
            }
        }

        public string PrintDog()
        {
            return $"{ _name} has {_mother} as mother, and  {_father} as father .";
        }
    }
}
