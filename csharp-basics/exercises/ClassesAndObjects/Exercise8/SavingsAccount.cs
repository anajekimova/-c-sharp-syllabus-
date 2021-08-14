using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise8
{
    class SavingsAccount
    {
        private double _startMoney;
        private int _interest;
        private double _totalWithDrawn;
        private double _totalDeposide;
        private double _totalBalance;
        private double _balance;
        private double _totalInterest;
        

        
        public SavingsAccount(int interest, double startMoney)
        {
            _interest = interest;
            _startMoney = startMoney;
        }

        public void Deposite(double money)
        {
            _balance += money;
            _totalDeposide += money;
        }

        public void WithDrawn(double money)
        {
            _balance -= money;
            _totalWithDrawn += money;
        }

        public void Balance()
        {

            _totalBalance += _balance;
        }

        public void Interests()
        {
            _balance += _balance * _interest / 12;
            _totalInterest += _balance * _interest / 12;
        }

        public void TotalDeposited()
        {
            Console.WriteLine($"Total deposited: $ {_totalDeposide}");
        }

        public void TotalWithdrawn()
        {
            Console.WriteLine($"Total withdrawn: $ {_totalWithDrawn}");
        }

        public void TotalInterest()
        {
            Console.WriteLine($"Interest earned: $ {_totalInterest.ToString("0.00")} ");
        }

        public void TotalBalnce()
        {
            Console.WriteLine($"Ending balance:$ {_totalBalance}");
        }
    }
}

