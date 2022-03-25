class Exercise12
{
    static void Main()
    {
        int num = 1;
        Console.WriteLine("We will be working with matrices now");
        Console.Write("\nFirst, enter the number of rows for your matrix: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("\nNow enter the number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++, num++)
            {
                matrix[i, j] = num;
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
                diagonalSnake(matrix, rows, cols);
                break;

            case 4:
                spiralMatrix(matrix, rows, cols);
                break;

            default: Console.WriteLine("\nInvalid option entered please try again"); break;
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
        int k = cols - 1;
        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                if ((j == 0 || j % 2 == 0) && (j != 1))
                {
                    Console.Write(matrix[j, i] + " ");
                }
                if (j == 1 || j % 2 != 0)
                {
                    Console.Write(matrix[j, k] + " ");
                    k--;

                }
            }
            Console.WriteLine();
        }
    }

    public static void diagonalSnake(int[,] matrix, int rows, int cols)
    {
        if (rows != 3 && cols != 3)
        {
            Console.WriteLine("\nThis option only works for 3x3 matrices");
            return;
        }
        for (int i = 0; i < cols; i++)
        {
            if (i == 0)
            {
                for (int j = 0, k = 1; j < rows; j++, k++)
                {
                    if (k < rows)
                    {
                        Console.Write(matrix[k, i] + " ");
                    }
                    if (k == rows)
                    {
                        Console.Write(matrix[k - 1, j] + " ");
                    }
                }
            }

            else if (i == 1)
            {
                for (int j = 0; j < rows; j++)
                {

                    Console.Write(matrix[j, i] + " ");
                }
            }

            else if (i >= 2)
            {
                for (int j = 0, k = 0; j < cols; j++)
                {
                    if (j == 0) { Console.Write(matrix[j, j] + " "); }
                    else { Console.Write(matrix[k, i] + " "); k++; }
                }
            }
            Console.WriteLine();
        }
    }

    public static void spiralMatrix(int[,] matrix, int rows, int cols)
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
}