using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecicioInterface.Services
{
    interface StandardPaymentService1
    {


        public double MonthlyInterest(double amount, int month);
        public double PaymentFee(double amount);

    }
}
