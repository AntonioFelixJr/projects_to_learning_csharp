﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2.Service
{
    class MercadoPagoService : IOnlinePaymentService
    {
        private const double FeePercentage = 0.03;
        private const double MonthlyInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
    }
}
