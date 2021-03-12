using System.Collections.Generic;
using ClasseAbstrata.Entities;
using System.Globalization;
using System;

namespace ClasseAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Antonio", 10.0, 0.01));
            list.Add(new BusinessAccount(1002, "Vitória", 10.0, 400.00));
            list.Add(new SavingsAccount(1003, "Noemi", 1000.0, 0.01));
            list.Add(new BusinessAccount(1004, "Fatima", 1000.0, 1000.00));

            double sum = 0.0;

            list.ForEach(account =>
            {
                sum += account.Balance;
            });

            Console.WriteLine($"Total balance: {sum.ToString("F2", CultureInfo.InvariantCulture)}");


            list.ForEach(account =>
            {
                account.Withdraw(5);
                Console.WriteLine($"{account.Holder} $ {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            });
        }
    }
}
