using System;
using System.Globalization;
using ExecicioInterface.Entities;
using ExecicioInterface.Services;


namespace ExercicioInterface
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter contrat date: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (MM/dd/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contrat Value: ");
            double ValueContract = double.Parse(Console.ReadLine());
            Contract contrato = new Contract(number, date, ValueContract);
            Console.Write("Enter number of Installments: ");
            int installments = int.Parse(Console.ReadLine());
            ServiceContract processingContract = new ServiceContract(new PayService());
            processingContract.ProcessingContract(contrato, installments);

            Console.WriteLine();
            Console.WriteLine(" INSTALLMENTS: ");
            foreach(Installment installment in contrato.Installments)
            {
                Console.WriteLine(installment);
            }





        }
    }
}