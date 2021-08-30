using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var nam = new Account("Benson", -17.5);
            nam.ShowUserNameAndBalance();
            Console.ReadLine();
        }
    }
}