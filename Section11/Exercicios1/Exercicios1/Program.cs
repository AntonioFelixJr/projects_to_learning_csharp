using Exercicios1.Entities.Exception;
using System.Globalization;
using System;
using Exercicios1.Entities;

namespace Exercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                decimal balance = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit: ");
                decimal limitWithdraw = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, balance, limitWithdraw);

                Console.Write("\nEnter amount for withdraw: ");
                decimal amount = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.Withdraw(amount);
                
                Console.WriteLine($"New balance: {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");

            }
            catch (AccountException e)
            {
                Console.WriteLine($"\nWithdraw error: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Formatting erro: {e.Message}");
            }
            catch(Exception e)
            {
                Console.WriteLine($"{e.GetType().Name}: {e.Message}");
            }
        }
    }
}
