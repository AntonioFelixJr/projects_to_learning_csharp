using System.Globalization;
using System;
using Exercico3.Entities;
using System.Collections.Generic;

namespace Exercico3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AnnualTax> list = new List<AnnualTax>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nTax payer data: \n");

            for (int i=1; i<=n; i++)
            {
                Console.WriteLine($"\tPayer #{i} data:");
                
                Console.Write("\tIndividual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("\tName: ");
                string name = Console.ReadLine();

                Console.Write("\tAnual income: ");
                decimal annualIncome = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (type)
                {
                    case 'i':
                        Console.Write("\tHealth expenditures: ");
                        decimal healthExpenditures = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        list.Add(new Individual(name, annualIncome, healthExpenditures));
                        break;

                    case 'c':
                        Console.Write("\tNumber of employees: ");
                        int numberOfEmployees = int.Parse(Console.ReadLine());

                        list.Add(new Company(name, annualIncome, numberOfEmployees));
                        break;

                    default:
                        throw new Exception("Type is invalid.");
                }
                Console.WriteLine();

            }

            Console.WriteLine("\nTAXES PAID:");
            decimal total = 0;
            list.ForEach(tax =>
            {
                total += tax.TotalTax();
                Console.WriteLine(tax);
            });

            Console.WriteLine($"\nTOTAL TAXES: $ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
