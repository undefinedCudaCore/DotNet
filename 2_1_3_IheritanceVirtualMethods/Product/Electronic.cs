namespace _2_1_3_IheritanceVirtualMethods.Product
{
    internal class Electronic : Product
    {
        public Electronic()
        {
            Warranty = DateTime.Now.AddMonths(24);
        }

        public DateTime Warranty { get; set; }
    }
}