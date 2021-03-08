using System.Collections.Generic;
using Exercicio1.Entities.Enums;
using System.Globalization;

namespace Exercicio1.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public Department Department { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sumContract = BaseSalary;

            Contracts.FindAll(c => c.Date.Year == year && c.Date.Month == month).ForEach(contract =>
            {
                sumContract += contract.TotalValue();

            });

            return sumContract;
        }

        public override string ToString()
        {
            return 
                $"Name: {Name}\n" +
                $"Department: {Department.Name}\n" +
                $"WorkerLevel: {Level}\n" +
                $"BaseSalary: {BaseSalary.ToString("F2", CultureInfo.InvariantCulture)}.";
        }
    }
}
