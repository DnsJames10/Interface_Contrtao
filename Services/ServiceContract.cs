using System;
using ExecicioInterface.Entities;


namespace ExecicioInterface.Services
{
    internal class ServiceContract
    {

        private StandardPaymentService1 _standarPaymentService; 

        public ServiceContract( StandardPaymentService1 standardPaymentService)
        {
            _standarPaymentService = standardPaymentService;
        }

        public void ProcessingContract(Contract contract , int month)
        {

            double valueBase = contract.ValueBase / month;

            for (int i = 1; i<= month; i++)
            {

                DateTime provision = contract.DateContract.AddMonths(i);
                double aMonth = valueBase +  _standarPaymentService.MonthlyInterest(valueBase, i);
                double feePerMonth = aMonth + _standarPaymentService.PaymentFee(aMonth);                     
                contract.Installments.Add(new Installment(feePerMonth,provision));

            }



        }



    }
}
