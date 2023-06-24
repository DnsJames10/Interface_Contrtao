using System;


namespace ExecicioInterface.Entities
{
    internal class Installment
    {
        public double Value { get; set; }
        public DateTime DueDate { get; set; }



        public Installment (double value, DateTime dueDate)
        {
            Value = value; DueDate = dueDate;
        }


        public override string ToString()
        {
            return DueDate.ToString("MM/dd/yyyy") + " - "+ Value;
        }


    }
}
