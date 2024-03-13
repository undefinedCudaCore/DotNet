namespace Advanced1
{
    public class Store
    {
        public Store(List<string> item)
        {
            this.Name = Name;
            CreationDate = DateTime.Now;
            AddItems(item);
            //Print(Name, Items);
        }
        public Store(string name)
        {
            Name = name;
            CreationDate = DateTime.Now;
            //Print(Name, Items);
        }
        public Store()
        {
            CreationDate = DateTime.Now;
            //Print(Name, Items);
        }
        public string Name { get; set; }
        public static DateTime CreationDate { get; set; }
        public static List<string> Items { get; set; }

        public static void AddItems(List<string> itemsToAdd)
        {
            Items = new List<string>();

            foreach (var item in itemsToAdd)
            {
                Items.Add(item);
            }
        }

        public static void Print(string nameToPrint, List<string> itemsToPrint)
        {
            for (int i = 0; i < itemsToPrint.Count; i++)
            {
                Console.WriteLine($"Name - {nameToPrint};\tDate - {CreationDate.ToString().Trim()}\t;Product name - {itemsToPrint[i]}");
            }
        }

        public static List<string> ReturnItemList()
        {
            return Items;
        }

    }
}
