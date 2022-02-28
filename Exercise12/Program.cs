class Exercise12
{
    static void Main()
    {
        Console.WriteLine("We will be working with matrices now");
        Console.Write("First, enter the number of rows for your matrix: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Now enter the number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("\nElement [{0},{1}]:  ", i + 1, j + 1);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\n\nPlease choose from the options below, how you would like to reresent your matrix");
        Console.WriteLine("1.\t column by column");
        Console.WriteLine("2.\t Vertical Snake");
        Console.WriteLine("3.\t A diagonal snake");
        Console.WriteLine("4.\t A spiral");

        Console.Write("\nPlease make a choice: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                colByCol(matrix, rows, cols);
                break;

            case 2:
                verticalSnake(matrix, rows, cols);
                break;

            case 3:
                Console.WriteLine("\n\nSorry, this solution is currently unavailable" +
                    "\n\nPlease wait as I try to fix it");
                break;
        }
    }

    public static void colByCol(int[,] matrix, int rows, int cols)
    {
        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                Console.Write(matrix[j, i] + " ");
            }
            Console.WriteLine();
        }
    }

    public static void verticalSnake(int[,] matrix, int rows, int cols)
    {
        int temp = rows - 1;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i % 2 != 0)
                {
                    if (temp == 0)
                    {
                        Console.Write(matrix[i, 0] + " ");
                    }

                    else
                    {
                        Console.Write(matrix[i, temp - j] + " ");
                        temp--;
                    }
                }

                else
                {
                    Console.Write(matrix[i , j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}