using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioDeFixacao1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberRegisters;

            List<Employee> listEmployees = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            numberRegisters = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberRegisters; i++)
            {
                int id;
                string name;
                double salary;

                Console.Write($"\nEmploee #{ i }: ");
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                name = Console.ReadLine();

                Console.Write("Salary: ");
                salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listEmployees.Add(new Employee(id, name, salary));
            }
            
            Console.Write("\nEnter the employee id that will have salary increase: ");
            int idEmployee = int.Parse(Console.ReadLine());

            Employee employeeFound = listEmployees.Find(employee => employee.Id == idEmployee);

            if (employeeFound != null)
            {
                Console.Write("Enter the percentage: ");
                float percentage = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employeeFound.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("\nUpdated list of employees:");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
