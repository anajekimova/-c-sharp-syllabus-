using System;

namespace Exercise8
{
    class Program
    {
            static void Main(string[] args)
            {
                double startMoney;
                Console.WriteLine("How much money is in the account?");
                startMoney = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the annual interest rate:");
                int interest = int.Parse(Console.ReadLine());
                var account = new SavingsAccount(interest, startMoney);
                Console.WriteLine("How long has the account been opened?");
                int month = int.Parse(Console.ReadLine());

                for (int i = 0; i < month; i++)
                {
                    Console.WriteLine($"Enter amount deposited for month {i + 1}");
                    int deposite = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Enter amount withdrawn for {i + 1}");
                    double withDrawn = double.Parse(Console.ReadLine());

                    account.Deposite(deposite);
                    account.WithDrawn(withDrawn);
                    account.Interests();
                }

                account.TotalDeposited();
                account.TotalWithdrawn();
                account.TotalInterest();
                account.TotalBalnce();
                Console.ReadLine();
            }
        }
    }

    
