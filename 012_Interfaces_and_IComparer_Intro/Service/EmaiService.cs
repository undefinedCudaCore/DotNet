using _012_Interfaces_and_IComparer_Intro.Models.Contracts;

namespace _012_Interfaces_and_IComparer_Intro.Service
{
    public class EmaiService : INotificationService
    {
        public void SendNotification(string to, string subject, string message)
        {
            Console.WriteLine($"[TEST]Sending email to {to}: {subject} - {message}.");
        }

        void INotificationService.SendNotification(string to, string subject, string message)
        {
            Console.WriteLine($"Sending email to {to}: {subject} - {message}.");
        }
    }
}
