namespace _2_1_3_IheritanceVirtualMethods.Product
{
    internal class Food : Product
    {
        public Food(int expirationDayCount)
        {

            ExpirationDayCount = expirationDayCount;
            ExpirationTime = DateTime.Now.AddDays(expirationDayCount);
        }

        public int ExpirationDayCount { get; set; }
        public DateTime ExpirationTime { get; set; }
    }
}