namespace _012_Interfaces_and_IComparer_Intro.Models.Contracts
{
    public interface INotificationService
    {
        public void SendNotification(string to, string subject, string message);
    }
}
