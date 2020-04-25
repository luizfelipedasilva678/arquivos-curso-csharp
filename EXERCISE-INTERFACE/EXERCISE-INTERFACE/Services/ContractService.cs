using System;
using System.Collections.Generic;
using EXERCISE_INTERFACE.Entities;

namespace EXERCISE_INTERFACE.Services
{
    class ContractService
    {
        private OnlinePaymentService _onlinePaymentService;

        public ContractService(OnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void processContract(Contract contract, int months)
        {
           double installments = contract.TotalValue / months;
           for (int i = 1; i <= months; i++)
           {
               double interest =  _onlinePaymentService.Interest(installments, i);
               double valueInstallment = _onlinePaymentService.PaymentFee(interest);
               contract.list.Add(new Installments(contract.Date.AddMonths(i), valueInstallment));
           }
        }
    }
}
