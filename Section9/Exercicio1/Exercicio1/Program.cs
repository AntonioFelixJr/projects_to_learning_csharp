using Exercicio1.Entities.Enums;
using System.Globalization;
using Exercicio1.Entities;
using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();

            Console.Write("Enter department´s name: ");
            worker.Department = new Department(Console.ReadLine());

            Console.WriteLine("\nEnter worker data:\n");

            Console.Write("\tName: ");
            worker.Name = Console.ReadLine();


            Console.Write("\tLevel (Junior/MidLevel/Senior): ");
            worker.Level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("\tBase salary: ");
            worker.BaseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nHow many contracts to this worker? ");
            int qtdContracts = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= qtdContracts; i++)
            {
                Console.WriteLine($"\tEnter #{i} contract data:\n");

                Console.Write("\tDate (DD/MM/YYYY): ");
                DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                Console.Write("\tValue per hour: ");
                double contractValuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("\tDuration (hours): ");
                int contractHours = int.Parse(Console.ReadLine());

                Console.WriteLine();

                worker.AddContract(new HourContract(contractDate, contractValuePerHour, contractHours));
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            DateTime incomeDate = DateTime.ParseExact(Console.ReadLine(), "MM/yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(worker);
            Console.WriteLine($"Income for {incomeDate.ToString("MM/yyyy")}: " +
                $"{worker.Income(incomeDate.Year, incomeDate.Month).ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
