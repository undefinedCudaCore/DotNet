using _012_Interfaces_and_IComparer_Intro.Models.Contracts;
using _012_Interfaces_and_IComparer_Intro.Models.Enums;

namespace _012_Interfaces_and_IComparer_Intro.Service
{
    public class PaymentProcessorFactory
    {
        public static IPaymentProcessor GetPaymentProcessor(PaymentMethods paymentMethods)
        {
            switch (paymentMethods)
            {
                case PaymentMethods.CreditCard:
                    return new CreditCardProcessor();
                case PaymentMethods.PayPal:
                    return new PayPalProcessor();
                case PaymentMethods.BankTransfer:
                    return new BankTransferProcessor();
                default:
                    throw new NotImplementedException("Unknown payment method.");
            }
        }
    }
}
