namespace _7_2_Generic_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1--------------------
            List<ObjectForList> list = new List<ObjectForList>(5);

            ObjectForList ofl1 = new ObjectForList(28, 1550, "Curt", "English", "Hello");
            ObjectForList ofl2 = new ObjectForList(29, 1650, "Dante", "Spanish", "Ola");
            ObjectForList ofl3 = new ObjectForList(30, 1750, "Arnold", "United", "Hi");
            ObjectForList ofl4 = new ObjectForList(35, 1850, "Jacek", "Polish", "Cześć");

            list.Add(ofl1);
            list.Add(ofl2);
            list.Add(ofl3);
            list.Add(ofl4);

            //BringItOut.WriteOneObjectToFileWithStreamReader(ofl1);
            //BringItOut.WriteObjectsToFileWithStreamReader<ObjectForList>(list);

            //BringItOut.WriteOneObjectToFileWithFileDot(ofl1);
            //BringItOut.WriteObjectsToFileWithFileDot<ObjectForList>(list);

            //Exercise 2--------------------
            TwoGenericParameters<string, int> twoGenericParameters = new TwoGenericParameters<string, int>();

            twoGenericParameters.SetMyProperty1("Ace");
            twoGenericParameters.SetMyProperty2(25);
            //twoGenericParameters.PrintT1();
            //twoGenericParameters.PrintT2();

            //Exercise 3--------------------
            FourSideGeometricFigure figure = new FourSideGeometricFigure("Hey", 2, 4);

            Generator<FourSideGeometricFigure>.Show(figure);
        }
    }
}
