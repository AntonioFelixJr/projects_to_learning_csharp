using Exercicios1.Entities.Exception;

namespace Exercicios1.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public decimal Balance { get; set; }
        public decimal WithdrawLimit { get; set; }

        public Account(int number, string holder, decimal balance, decimal withdrawLimit)
        {
            if (balance < 0)
                throw new AccountException("Opening balance is less than zero");

            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new AccountException("Amount is less or equal than zero");

            if (amount > WithdrawLimit)
                throw new AccountException("The amount exceededs witdraw limit");

            if (amount > Balance)
                throw new AccountException("No enough balance");

            Balance -= amount;
        }

    }
}
