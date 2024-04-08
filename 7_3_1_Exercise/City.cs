using _7_3_2_Exercise;

namespace _7_3_1_Exercise
{
    public class City<T1, T2>
    {
        private readonly Dictionary<T1, T2> _cityList;
        private bool Validate { get; set; }


        public City(Dictionary<T1, T2> list)
        {
            _cityList = new Dictionary<T1, T2>();
            _cityList = list;

            Validate = Validation<Dictionary<T1, T2>>.Validate(list);
            if (Validate)
            {
                Console.WriteLine("It is null for City class dictionary");
            }
        }

        public T2 GetCity(T1 id, T2 city)
        {
            if (!_cityList.ContainsValue(city))
            {
                _cityList.Add(id, city);
                return city;
            }
            return _cityList[id];
        }

        public void PrintList()
        {
            foreach (var item in _cityList)
            {
                Console.WriteLine($"City: {item.Value}");
            }
        }

        public T2[] ChangeListToArray()
        {
            List<T2> toArray = new List<T2>();
            foreach (var item in _cityList)
            {
                toArray.Add(item.Value);
            }

            return toArray.ToArray();
        }

        public T2 DictionaryContainsValue(T2 city)
        {
            int count = 0;
            if (!_cityList.Values.Contains(city))
            {
                throw new Exception("Get some good values!");
            }

            foreach (var item in _cityList)
            {
                if (item.Value.Equals(city))
                {
                    count++;
                }
            }
            if (count > 1)
            {
                throw new Exception("Found more than 2 values!");
            }
            return city;
        }
        public T2 DictionaryContainsValueIfNotReturnsDefault(T2 city)
        {
            int count = 0;
            if (!_cityList.Values.Contains(city))
            {
                return default(T2);
            }

            foreach (var item in _cityList)
            {
                if (item.Value.Equals(city))
                {
                    count++;
                }
            }
            if (count > 1)
            {
                throw new Exception("Found more than 2 values!");
            }
            return city;
        }

        public bool IsItemInList(T2 value)
        {
            foreach (var item in _cityList)
            {
                if (item.Value.Equals(value))
                {
                    return true;
                }
            }
            return false;
        }
    }
}