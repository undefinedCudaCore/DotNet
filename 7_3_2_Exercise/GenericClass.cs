﻿namespace _7_3_2_Exercise
{
    internal class GenericClass<T>
    {
        private readonly List<T> _list;
        private bool Validate { get; set; }

        public GenericClass(List<T> list)
        {
            _list = new List<T>();
            _list = list;

            Validate = Validation<List<T>>.Validate(list);
            if (Validate)
            {
                Console.WriteLine("It is null for GenericClass class list");
            }
        }

        public void PrintList()
        {
            foreach (T item in _list)
            {
                Console.WriteLine(item);
            }
        }

        public T[] ConvertToArray()
        {
            return _list.ToArray();
        }

        public void AddToOneValueToList(T value)
        {
            _list.Add(value);
        }

        public void AddListToList(List<T> values)
        {
            _list.AddRange(values);
        }

        public void RemoveOneValueFromList(T value)
        {
            _list.Remove(value);
        }

        public void RemoveOneValueFromListByIndex(int index)
        {
            _list.RemoveAt(index);
        }
        public void RemoveOneValueFromListAllValues(T value)
        {
            for (int i = 0; i < _list.Count; i++)
            {
                if (_list.Contains(value))
                {
                    _list.Remove(value);
                }
            }
        }
    }
}
