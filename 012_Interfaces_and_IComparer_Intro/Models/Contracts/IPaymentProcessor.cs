namespace _012_Interfaces_and_IComparer_Intro.Models.Contracts
{
    internal interface IPaymentProcessor
    {
        bool ProcessPayment(PaymentDetails paymentDetails);
        void OnPaymentSuccess(PaymentDetails paymentDetails);
        void OnPaymentFailure(PaymentDetails paymentDetails, string error);
    }
}