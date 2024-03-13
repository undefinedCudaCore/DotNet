namespace _10_ref_out
{
    internal static class Intro
    {

        internal static void Introduction()
        {
            int a = 100;
            Console.WriteLine(a);
            ChangeValue(ref a);
            Console.WriteLine(a);

            int x = 0;
            DoSomething(ref x);
            Console.WriteLine(x);
        }

        internal static void ChangeValue(ref int x)
        {
            x = 200;
        }

        internal static int DoSomething(ref int x)
        {
            return x += 1;
        }

        internal static void Swap(ref int one, ref int two)
        {
            one += two;
            two = one - two;
            one = one - two;

            Console.WriteLine($"One is now: {one}");
            Console.WriteLine($"Two is now: {two}");
        }

        internal static void IncrementByN(ref int incr)
        {
            Console.WriteLine($"You entered: {incr}");

            int x = incr;
            incr += incr;

            Console.WriteLine($"Your {x}, that you entered now is: {incr}");
        }

        internal static void WriteGreeting(string greet)
        {
            Console.WriteLine($"Enter a value for {greet}:");
        }

        internal static void TrimAndCapitalize(ref string textChange)
        {
            textChange = textChange.Trim();

            if (!String.IsNullOrEmpty(textChange) && !String.IsNullOrWhiteSpace(textChange))
            {
                textChange = (textChange.Substring(0, 1).ToUpper()) +
                    (textChange.Substring(1, textChange.Length - 1));
                Console.WriteLine($"Yor trimed and capitalized sentence: {textChange}");
            }
        }
    }
}
