using _012_Interfaces_and_IComparer_Intro.Models;
using _012_Interfaces_and_IComparer_Intro.Models.Contracts;
using _012_Interfaces_and_IComparer_Intro.Models.Enums;

namespace _012_Interfaces_and_IComparer_Intro.Service
{
    internal class PaymentService
    {
        private readonly INotificationService _notificationService;

        public PaymentService(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        public void ProcessPayment(PaymentDetails paymentDetails, PaymentMethods paymentMethods)
        {
            var processor = PaymentProcessorFactory.GetPaymentProcessor(paymentMethods);
            if (processor.ProcessPayment(paymentDetails))
            {
                processor.OnPaymentSuccess(paymentDetails);
                _notificationService.SendNotification(paymentDetails.Email, "Payment succesfull", $"Your payment of {paymentDetails.Amount} has processed succesfully.");
            }
            else
            {
                processor.OnPaymentFailure(paymentDetails, "Payment failed");
                _notificationService.SendNotification(paymentDetails.Email, "Payment failed", $"Please try again.");
            }
        }
    }
}
