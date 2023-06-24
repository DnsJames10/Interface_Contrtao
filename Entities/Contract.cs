using System;
using System.Collections.Generic;

namespace ExecicioInterface.Entities
{
    internal class Contract
    {


        public int NumContract { get; set; }
        public DateTime DateContract { get; set; }

        public double ValueBase { get; set; }

        public List<Installment> Installments = new List<Installment>();

        public Contract(int numContract, DateTime dateContract, double valueBase)
        {
            NumContract = numContract;
            DateContract = dateContract;
            ValueBase = valueBase;
        }


        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);

        }
    }
}
