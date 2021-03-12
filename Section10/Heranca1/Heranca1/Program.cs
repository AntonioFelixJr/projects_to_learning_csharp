using Heranca1.Entities;
using System;

namespace Heranca1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Antonio", 200.00);

            BusinessAccount bacc = new BusinessAccount(1002, "Vitória", 0, 500.00);

            //UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.00);
            Account acc3 = new SavingsAccount(1004, "Joana", 100.0, 0.02);

            //DOWNCASTING

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            //Gera exception em run time
            
            //BusinessAccount acc5 = (BusinessAccount)acc3;

            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!" + acc3.Balance);
            }

            /*
            BusinessAccount businessAccount = new BusinessAccount(1000, "Antonio", 150.00, 50.00);

            businessAccount.Loan(50);
            //businessAccount.Balance = 10000.99;

            Console.WriteLine(businessAccount.Balance);
            */

            Console.WriteLine("---------------------------------------------------------------------------------");

            Account conta1 = new Account(1010, "André", 500.00);
            Account conta2 = new SavingsAccount(1010, "Jane", 500.00, 0.01);

            conta1.Withdraw(10.0);
            conta2.Withdraw(10.0);

            Console.WriteLine($"Valores Account: {conta1.Balance}, SavingAccount: {conta2.Balance}");
        }
    }
}
