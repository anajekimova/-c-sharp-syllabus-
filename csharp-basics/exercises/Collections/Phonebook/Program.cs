﻿using PhoneBook;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new PhoneDirectory("Nika", 862229478);
            var name1 = new PhoneDirectory("Alisa", 783720987);
            var nam2 = new PhoneDirectory("Nikol", 678439876);

            name.PrintNameNumber();
            PhoneDirectory.Print();
            PhoneDirectory.Print();
            PhoneDirectory.GetNumber("Nika");
            PhoneDirectory.GetNumber("Nikol");

            Console.ReadKey();
        }
    }
}
