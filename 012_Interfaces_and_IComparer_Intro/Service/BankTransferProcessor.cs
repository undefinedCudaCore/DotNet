using _012_Interfaces_and_IComparer_Intro.Models;
using _012_Interfaces_and_IComparer_Intro.Models.Contracts;

namespace _012_Interfaces_and_IComparer_Intro.Service
{
    internal class BankTransferProcessor : IPaymentProcessor
    {
        public bool ProcessPayment(PaymentDetails paymentDetails)
        {
            //Bank transfer processong logic
            //Integration with API
            //Retrieval of keys
            //Object mapping
            //etc

            Console.WriteLine("Processing Bank transfer payment.");
            return true;
        }

        public void OnPaymentSuccess(PaymentDetails paymentDetails)
        {
            Console.WriteLine("Bank transfer payment succesfull.");
        }

        public void OnPaymentFailure(PaymentDetails paymentDetails, string error)
        {
            Console.WriteLine("Bank transfer payment failed. Please try again");
        }

    }
}
