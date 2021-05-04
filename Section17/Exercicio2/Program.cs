using Exercicio2.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\Employees.csv";

            List<Employee> employees = new List<Employee>();

            string delimiter = ",";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            string[] employee = line.Split(delimiter);
                            string name = employee[0];
                            string email = employee[1];
                            decimal salary = decimal.Parse(employee[2], CultureInfo.InvariantCulture);
                            employees.Add(new Employee(name, email, salary));
                        }
                    }
                }

                Console.Write("Enter salary: ");
                decimal salaryMin = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine($"\nEmail of people whose salary is more than {salaryMin.ToString("F2", CultureInfo.InvariantCulture)}");

                var employeesPerSalary =
                    from e in employees
                    where e.Salary > salaryMin
                    orderby e.Email ascending
                    select e.Email;

                foreach (var employeeEmail in employeesPerSalary)
                {
                    Console.WriteLine(employeeEmail);
                }

                decimal sumM =
                    (from e in employees
                     where e.Name.StartsWith("m", StringComparison.InvariantCultureIgnoreCase)
                     select e.Salary).Sum();

                Console.WriteLine($"\nSum of salary of people whose name starts with 'M': {sumM.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (IOException e)
            {
                Console.WriteLine("Error in read file: " + e.Message);
            }
        }
    }
}
