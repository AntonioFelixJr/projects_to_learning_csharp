using Exercicio2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2.Service
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService { get; set; }

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void Process(Contract contract, int mounts)
        {
            double basicQuota = contract.TotalValue / mounts;

            for (int i = 1; i <= mounts; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);
                contract.Installments.Add(new Installment(date, fullQuota));
            }
        }
    }
}
