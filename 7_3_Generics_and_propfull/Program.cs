using _7_3_Generics_and_propfull.ModelsGeneric;
using _7_3_Generics_and_propfull.ModelsPropfull;

namespace _7_3_Generics_and_propfull
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productMemCache = new MemoryCache<Product>();
            var milk = new DairyProducts()
            {
                Id = 1,
                ExpirationDateTime = DateTime.Now.AddDays(7),
                Name = "Vilkiskiu",
                Price = 1.99
            };

            var laptop = new TechProduct()
            {
                Id = 2,
                WarrantyExpirationDateTime = DateTime.Now,
                Price = 799,
                Name = "Lenovo"
            };

            productMemCache.GetOrCreate(1, milk);
            productMemCache.GetOrCreate(2, laptop);
            productMemCache.GetOrCreate(3, milk);

            var milkFromCache = productMemCache.GetOrCreate(1);
            milkFromCache.Name = "Marg4";

            productMemCache.PrintProduct();

            //-------------------------------------------

            var dateRange = new Range<DateTime>
            {
                Start = new DateTime(2024, 3, 10),
                End = new DateTime(2024, 3, 20),
            };

            bool isWithinRange = dateRange.IsWithinRange(DateTime.Now);
            Console.WriteLine(isWithinRange);

            //-------------------------------------------
            Person person = new Person("Gitanas");
            Console.WriteLine(person.Name);

            //-------------------------------------------

        }
    }
}
