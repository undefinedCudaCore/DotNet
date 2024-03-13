namespace _7_1_Generic_Intro
{
    internal class CustomList<T>
    {
        public CustomList(int size)
        {
            Size = size;
            Array = new T[Size];
        }

        public T[] Array { get; set; }
        public T[] Array2 { get; set; }
        private int Size { get; set; }
        private int _index = 0;

        public void AddToArray(T arrayElementToAdd)
        {
            if (IsListFull())
            {
                Array = MakeArrayBigger();
            }
            Array[_index] = arrayElementToAdd;
            _index++;
        }

        public void RemoveArrayItem(int index)
        {
            var newArray = new T[Array2.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = Array2[i];
            }
            for (int i = index + 1; i < newArray.Length; i++)
            {
                newArray[index++] = Array2[i];

            }

            Array2 = newArray;

            //List<T> list = new List<T>();
            //list = Array2.ToList();
            //list.Remove(list[index]);


            //Array2 = list.ToArray();
        }

        private bool IsListFull()
        {
            if (_index == Size)
            {
                return true;
            }
            return false;
        }

        private T[] MakeArrayBigger()
        {
            Size += (Size / 2);
            Array2 = new T[Size];
            Array.CopyTo(Array2, 0);

            return Array2;
        }
    }
}
