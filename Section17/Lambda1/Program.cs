using Delegate1.Services;
using System;

namespace Delegate1
{
    delegate double BinaryNumericOperation(double n1, double n2);
    delegate void BinaryNumericOperationShow(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Max;
            // Sitaxe alternativa
            // BinaryNumericOperation op1 = new BinaryNumericOperation(CalculationService.Sum);

            double result = op(a, b);

            // double result = op.Invoke(a, b);
            Console.WriteLine(result);

            Console.WriteLine();

            BinaryNumericOperationShow opShow = CalculationService.ShowSum;
            opShow += CalculationService.ShowMax;
            opShow += CalculationService.ShowSum;

            opShow.Invoke(a, b);
        }
    }
}
