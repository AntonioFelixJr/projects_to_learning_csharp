namespace Exercico3.Entities
{
    class Company : AnnualTax
    {
        public int NumberOfWorker { get; set; }

        public Company(string name, decimal annualIncome, int numberOfWorker) : base(name, annualIncome)
        {
            NumberOfWorker = numberOfWorker;
        }

        public override decimal TotalTax()
        {
            decimal tax = NumberOfWorker > 10 ? 0.14M : 0.16M;

            return AnnualIncome * tax;
        }
    }
}
