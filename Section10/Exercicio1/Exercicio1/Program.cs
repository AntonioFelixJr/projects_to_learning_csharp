using Exercicio1.Entities;
using System.Globalization;
using System.Collections.Generic;
using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            
            for (int i = 1 ; i <= n ; i++)
            {

                Console.WriteLine($"Employee #{i} data: ");

                Console.Write($"\tOutsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());

                Console.Write($"\tName: ");
                string name = Console.ReadLine();

                Console.Write($"\tHours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write($"\tValue per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Employee employeeObj;
                if (outsourced.Equals('y'))
                {
                    Console.Write($"\tAdditional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine("\nPAYMENTS:");


            foreach (Employee employee in list)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}
