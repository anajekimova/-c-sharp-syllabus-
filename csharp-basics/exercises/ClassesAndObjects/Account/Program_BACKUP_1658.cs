using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        public static void Main(string[] args)
        {
<<<<<<< HEAD
            AccountPersone bartosAccount = new AccountPersone("Barto's account", 100.00);
            AccountPersone bartosSwissAccount = new AccountPersone("Barto's account in Switzerland", 1000000.00);
=======
            Account bartosAccount = new Account("Barto's account", 100.00);
            Account bartosSwissAccount = new Account("Barto's account in Switzerland", 1000000.00);
>>>>>>> b27b42ef7ae1c708775f597a3589624e0ab7c2f0

            Console.WriteLine("Initial state");
            Console.WriteLine(bartosAccount);
            Console.WriteLine(bartosSwissAccount);

            bartosAccount.Withdrawal(20);
            Console.WriteLine("Barto's account balance is now: " + bartosAccount.Balance());
            bartosSwissAccount.Deposit(200);
            Console.WriteLine("Barto's Swiss account balance is now: " + bartosSwissAccount.Balance());

            Console.WriteLine("Final state");
            Console.WriteLine(bartosAccount);
            Console.WriteLine(bartosSwissAccount);

<<<<<<< HEAD
            AccountPersone matt = new AccountPersone("Matt's account", 1000);
            AccountPersone myAccount = new AccountPersone("My account", 0);
=======
            Account matt = new Account("Matt's account", 1000);
            Account myAccount = new Account("My account", 0);
>>>>>>> b27b42ef7ae1c708775f597a3589624e0ab7c2f0

            var money = matt.Withdrawal(100);
            myAccount.Deposit(money);
            Console.WriteLine("Final state");
            Console.WriteLine(matt);
            Console.WriteLine(myAccount);
            Console.ReadLine();
        }

        public static void Transfer(AccountPersone from, AccountPersone to, double howMuch)
        {
            to.Deposit(from.Withdrawal(howMuch));
        }
    }
}
