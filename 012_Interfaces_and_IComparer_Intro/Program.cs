using _012_Interfaces_and_IComparer_Intro.Models;
using _012_Interfaces_and_IComparer_Intro.Models.Enums;
using _012_Interfaces_and_IComparer_Intro.Service;

namespace _012_Interfaces_and_IComparer_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var paymentDetails = new PaymentDetails
            {
                Amount = 100.00m,
                ToAccount = "548654468",
                FromAccount = "4698798645"
            };

            var emailService = new EmaiService();
            var paymentService = new PaymentService(emailService);
            paymentService.ProcessPayment(paymentDetails, PaymentMethods.PayPal);
        }
    }
}