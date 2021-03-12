using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca1.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public sealed override void Withdraw(double amount)
        {
            if (amount > 0)
                base.Withdraw(amount);
                Balance -= 2.0;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
