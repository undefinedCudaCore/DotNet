using _012_Interfaces_and_IComparer_Intro.Models;
using _012_Interfaces_and_IComparer_Intro.Models.Contracts;

namespace _012_Interfaces_and_IComparer_Intro.Service
{
    internal class CreditCardProcessor : IPaymentProcessor
    {

        public bool ProcessPayment(PaymentDetails paymentDetails)
        {
            //Credit card processong logic
            //Integration with API
            //Retrieval of keys
            //Object mapping
            //etc

            Console.WriteLine("Processing Credit Card payment.");
            return true;
        }

        public void OnPaymentSuccess(PaymentDetails paymentDetails)
        {
            Console.WriteLine("Credit Card payment succesfull.");
        }

        public void OnPaymentFailure(PaymentDetails paymentDetails, string error)
        {
            Console.WriteLine("Credit Card payment failed. Please try again");
        }
    }
}
