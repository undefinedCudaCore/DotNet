namespace _7_1_Generic_Intro
{
    internal class CustomList<T>
    {
        public CustomList(int size)
        {
            Size = size;
            _index = 0;
            _actualSize = size;
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
                Array = MakeArraqyBigger();
            }
            Array[_index++] = tttt;
        }

        private bool IsListEmpty()
        {
            if (Array.Length >= _actualSize)
            {
                return true;
            }
            return false;
        }

        private T[] MakeArraqyBigger()
        {
            Array2 = new T[Size++];
            Array.CopyTo(Array2, 0);

            return Array2;
        }
    }
}
