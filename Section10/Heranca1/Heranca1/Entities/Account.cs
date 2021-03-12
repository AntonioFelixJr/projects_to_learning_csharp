using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca1.Entities
{
    public class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }
        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            if (amount > 0)
                Balance -= amount + 5.0;
        }

        public void Depoist(double amount)
        {
            if (amount > 0)
                Balance += amount;
        }
    }
}
