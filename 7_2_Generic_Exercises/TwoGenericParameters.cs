namespace _7_2_Generic_Exercises
{
    internal class TwoGenericParameters<T1, T2>
    {

        public T1 MyProperty1 { get; set; }
        public T2 MyProperty2 { get; set; }

        public void SetMyProperty1(T1 t1)
        {
            MyProperty1 = t1;
        }
        public void SetMyProperty2(T2 t2)
        {
            MyProperty2 = t2;
        }

        public void PrintT1()
        {
            Console.WriteLine(MyProperty1);
        }
        public void PrintT2()
        {
            Console.WriteLine(MyProperty2);
        }


    }
}
