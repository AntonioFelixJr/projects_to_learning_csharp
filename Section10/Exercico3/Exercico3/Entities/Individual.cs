namespace Exercico3.Entities
{
    class Individual : AnnualTax
    {
        public decimal? HealthExpenses { get; private set; }

        public Individual(string name, decimal annualIncome, decimal? healthExpenses) : base(name, annualIncome)
        {
            HealthExpenses = healthExpenses;
        }

        public override decimal TotalTax()
        {
            decimal tax;
            decimal discount;

            tax = AnnualIncome >= 20000.00M ? 0.25M : 0.15M;

            discount = (decimal)(HealthExpenses.HasValue ? HealthExpenses/2.0M : 0M);

            return (decimal)((AnnualIncome * tax) - (HealthExpenses - discount));
        }
    }
}
