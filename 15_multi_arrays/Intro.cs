namespace _15_multi_arrays
{
    internal class Intro
    {
        public static void IntroForMultidimentionalArrays()
        {
            int rows = 4;
            int cols = 5;

            int[,] matrix = new int[rows, cols];

            //Initialize the matrix with some values
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = i + j;
                }
            }

            //Display the matrix in the console
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        public static void PrintTable()
        {
            string[,] table = new string[3, 3];

            //Fullfil headers
            table[0, 0] = "Name";
            table[0, 1] = "Age";
            table[0, 2] = "City";

            //Fullfil headers
            table[1, 0] = "Tomas";
            table[1, 1] = "25";
            table[1, 2] = "London";

            //Fullfil headers
            table[2, 0] = "Andrew";
            table[2, 1] = "50";
            table[2, 2] = "New York";

            //Display the matrix in the console
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(table[i, j].PadRight(10));
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
