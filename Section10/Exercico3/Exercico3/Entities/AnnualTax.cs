using System.Globalization;

namespace Exercico3.Entities
{
    abstract class AnnualTax
    {

        public string Name { get; protected set; }

        public decimal AnnualIncome { get; protected set; }

        protected AnnualTax(string name, decimal annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract decimal TotalTax();

        public override string ToString()
        {
            return $"{Name}: $ {TotalTax().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
