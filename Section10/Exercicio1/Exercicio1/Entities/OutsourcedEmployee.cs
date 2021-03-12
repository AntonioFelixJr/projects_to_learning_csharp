using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1.Entities
{
    sealed class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; private set; }


        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours,valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }


        public override double Payment()
        {
            double payment =  base.Payment();

            payment += (AdditionalCharge / 100) * 110;

            return payment;
        }
    }
}
