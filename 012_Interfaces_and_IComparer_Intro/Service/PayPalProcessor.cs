using _012_Interfaces_and_IComparer_Intro.Models;
using _012_Interfaces_and_IComparer_Intro.Models.Contracts;

namespace _012_Interfaces_and_IComparer_Intro.Service
{
    public class PayPalProcessor : IPaymentProcessor
    {
        public bool ProcessPayment(PaymentDetails paymentDetails)
        {
            //PayPal processong logic
            //Integration with API
            //Retrieval of keys
            //Object mapping
            //etc

            Console.WriteLine("Processing PayPal payment.");
            return true;
        }

        public void OnPaymentSuccess(PaymentDetails paymentDetails)
        {
            Console.WriteLine("PayPal payment succesfull.");
        }

        public void OnPaymentFailure(PaymentDetails paymentDetails, string error)
        {
            Console.WriteLine("PayPal payment failed. Please try again");
        }
    }
}
