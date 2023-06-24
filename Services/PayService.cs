using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecicioInterface.Services
{
    internal class PayService : StandardPaymentService1
    {

        private double _monthlyInterest = 0.01;
        private double _paymentFee = 0.02;

        public double MonthlyInterest(double amount, int month)
        {
            return amount * _monthlyInterest * month;
        }

        public double PaymentFee(double amount)
        {
            return amount * _paymentFee;
        }
 
    }
}
