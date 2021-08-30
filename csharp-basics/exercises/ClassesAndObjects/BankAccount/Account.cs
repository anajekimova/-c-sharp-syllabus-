using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        private string _accountName;
        private double _balance;

        public Account(string accountName, double balance)
        {
            _accountName = accountName;
            _balance = balance;
        }

        public void ShowUserNameAndBalance()
        {
            if(_balance > 0)
            {
                Console.WriteLine($"{_accountName}, ${_balance}");
            }
            else
            {
                Console.WriteLine($"{_accountName}, ${Math.Abs(_balance)}");
            }
        }
    }
    

}
