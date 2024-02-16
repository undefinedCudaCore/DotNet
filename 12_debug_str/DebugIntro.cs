using System.Diagnostics;
using System.Text;

namespace _12_debug_str
{
    internal static class DebugIntro
    {
        internal static void FindBugWithDebug()
        {
            int a = 10;
            int b = 5;
            int c = 8;

            int max = a;
            // (b < max) ??? int a is max value - do nothing
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = b; // max = c;
            }
            Console.WriteLine("The maximum value is: " + max);
        }

        internal static void FindBugWithDebug2()
        {
            string firstName = "John";
            string lastName = "Doe";

            //space is missing?
            string fullName = firstName + lastName;

            Console.WriteLine("Full Name: " + fullName);
        }

        internal static void FindBugWithDebug3()
        {
            int counter = 0;

            while (counter <= 10)
            {
                Console.WriteLine("Count: " + counter);
                counter--;
                //counter++
            }
        }

        internal static void FindBugWithDebug4()
        {
            int i = 0;

            while (i < 5)
            {
                i++;
                Console.WriteLine(i);
            }
        }

        internal static void FindBugWithDebug5()
        {
            string name1 = "John";
            string name2 = "john";

            // Upper case does not equal to lover case string(char)
            //if (name1.ToLower().Equals(name2.ToLower()))

            if (name1.Equals(name2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Names are the same.");
            }
            else
            {
                Console.WriteLine("Names are different.");
            }
        }

        internal static void FindBugWithDebug6()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("Names are different. ");
            stringBuilder.Append("Kaip sekasi? ");
            stringBuilder.Append("Tikiuosi, kad viskas gerai!");

            string result = stringBuilder.ToString();
            Console.WriteLine(result);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch);
        }
    }
}
