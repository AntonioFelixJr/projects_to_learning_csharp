using System.Globalization;

namespace Exercicio2.Entities
{
    class ImportedProduct : Product
    {
        public decimal CustomFee { get; set; }

        public ImportedProduct(string name, decimal price, decimal customFee) : base(name, price)
        {
            CustomFee = customFee;
        }

        public override string PriceTag()
        {
            return $"{Name} $ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} " +
                $"(Customs fee: $ {CustomFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }

        public decimal TotalPrice()
        {
            return Price + CustomFee;
        }
    }
}
