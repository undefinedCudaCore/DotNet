namespace _7_1_Generic_Intro
{
    internal class CustomList<T>
    {
        public CustomList(int size)
        {
            Size = size;
            _index = 0;
            Array = new T[Size];
        }

        public T[] Array { get; set; }
        public T[] Array2 { get; set; }
        private int Size { get; set; }
        private int _index;
        private int _actualSize { get; set; }

        public void AddToArray(T tttt)
        {
            if (IsListEmpty())
            {
                Array = MakeArrayBigger();
            }
            Array[_index++] = tttt;
        }

        public void RemoveArrayItem(int index)
        {
            //List<T> list = new List<T>();
            //list = Array2.ToList();
            //list.Remove(list[index]);

            //Array2 = list.ToArray();
        }

        private bool IsListEmpty()
        {
            if (Array.Length >= Size)
            {
                return true;
            }
            return false;
        }

        private T[] MakeArrayBigger()
        {
            Array2 = new T[Size++];
            Array.CopyTo(Array2, 0);

            return Array2;
        }
    }
}
