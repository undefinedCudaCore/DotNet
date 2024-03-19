namespace _7_3_Generics_and_propfull.ModelsGeneric
{
    internal class MemoryCache<T> where T : Product, new()
    {
        private Dictionary<int, T> cache = new Dictionary<int, T>();

        public T GetOrCreate(int id, T product = null)
        {
            if (!cache.ContainsKey(id))
            {
                T newItem = product == null
                    ? new T()
                    : product;

                cache.Add(id, newItem);
                return newItem;
            }
            return cache[id];
        }

        public void PrintProduct()
        {
            foreach (var item in cache)
            {
                Console.WriteLine($"{item.Key}, {item.Value.Name}: {item.Value.Price}.");
            }
        }
    }
}
