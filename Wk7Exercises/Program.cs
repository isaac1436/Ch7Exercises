class Wk7Matrices
{
    static int[,] matrix1 = new int[3, 3];
    static int[,] matrix2 = new int[3, 3];
    static void Main()
    {

        int[,,,] my4DArray = new int[2, 3, 5, 4]
        {
        {
            { { -1,2,3,4},{ 1,2,3,4},{ 1,2,3,4},{ 1,2,3,4},{ 1,2,3,4}},
            { { 1,2,3,4},{ 1,2,3,4},{ 1,2,3,4},{ 1,2,3,4},{ 1,2,3,4} },
            { { 1,2,3,4},{ 1,2,3,4},{ 1,2,3,4},{ 1,2,3,4},{ 1,2,3,4} }
        },

        {
            { { 1,2,3,4},{ 1,2,3,4},{ 1,2,3,4},{ 1,2,3,4},{ 1,2,3,4} },
            { { 1,2,3,4},{ 1,2,3,4},{ 1,2,3,4},{ 1,2,3,4},{ 1,2,3,4} },
            { { 1,2,3,4},{ 1,2,3,4},{ 1,2,3,4},{ 1,2,3,4},{ 1,2,3,4} }
        }

        };


        bool errorCatch = false;

        Console.WriteLine("\nPlease enter the integers to be stored in the first array: ");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3;)
            {
                Console.Write("\nEnter the value to be stored in [{0},{1}]: ", i + 1, j + 1);
                errorCatch = int.TryParse(Console.ReadLine(), out matrix1[i, j]);
                if (errorCatch) { j++; }
                else { Console.WriteLine("\nInvalid value entered, Please try again\n"); }
            }
        }

        errorCatch = false;

        Console.WriteLine("\nPlease enter the integers to be stored in the second array: ");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3;)
            {
                Console.Write("\nEnter the value to be stored in [{0},{1}]: ", i + 1, j + 1);
                errorCatch = int.TryParse(Console.ReadLine(), out matrix2[i, j]);
                if (errorCatch) { j++; }
                else { Console.WriteLine("\nInvalid value entered, Please try again\n"); }
            }
        }

        Console.WriteLine("\nNow please choose from the options below");
        Console.WriteLine("1.\tAdd them");
        Console.WriteLine("2.\tSubtract them");
        Console.WriteLine("3.\tMultiply them");
        Console.WriteLine("4.\tFind their determinants");

        Console.Write("\nYour choice is: ");
        errorCatch = int.TryParse(Console.ReadLine(), out int choice);

        Console.WriteLine("\n\n");
        if (errorCatch)
        {
            switch (choice)
            {
                case 1:
                    addMatrices(matrix1, matrix2);
                    break;

                case 2:
                    subtractMatrices(matrix1, matrix2);
                    break;

                case 3:
                    multiplyMatrices(matrix1, matrix2);
                    break;

                case 4:
                    Console.WriteLine("\nThe determinant of the first matrix is {0} and the determinant of the" +
                        " second matrix is {1} ", determinantOfMatrices(matrix1), determinantOfMatrices(matrix2));

                    if (determinantOfMatrices(matrix1) > determinantOfMatrices(matrix2)) { Console.WriteLine("So therefor the 1st matrix is greater than the second"); }

                    if (determinantOfMatrices(matrix2) > determinantOfMatrices(matrix1)) { Console.WriteLine("So therefor the 2nd matrix is greater than the first"); }

                    if (determinantOfMatrices(matrix1) == determinantOfMatrices(matrix2)) { Console.WriteLine("So therefor the 1st matrix is equal to the second"); }

                    break;

                default:
                    Console.WriteLine("Invalid value entered, please try again later");
                    break;
            }
        }

        else { Console.WriteLine("Invalid Value entered"); }
    }

    static void addMatrices(int[,] matrix1, int[,] matrix2)
    {
        int[,] summedMatrix = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                summedMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        printResult(summedMatrix);
    }

    static void subtractMatrices(int[,] matrix1, int[,] matrix2)
    {

        int[,] subtractedMatrix = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                subtractedMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }
        printResult(subtractedMatrix);
    }

    static void multiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int[,] multipliedMatrix = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            int k = 0;
            for (int j = 0; j < 3; j++)
            {
                multipliedMatrix[i, k] += matrix1[j, i] * matrix2[i, j];
            }
            k++;

            for (int j = 0; j < 3; j++)
            {
                multipliedMatrix[i, k] += matrix1[j, k] * matrix2[i, j];
            }
            k++;

            for (int j = 0; j < 3; j++)
            {
                multipliedMatrix[i, k] += matrix1[j, k] * matrix2[i, j];
            }

        }
        printResult(multipliedMatrix);
    }

    static int determinantOfMatrices(int[,] arr)
    {
        int det = 0;
        for (int i = 0; i < 3; i++)
        {
            det = det + (arr[0, i] * (arr[1, (i + 1) % 3] * arr[2, (i + 2) % 3] - arr[1, (i + 2) % 3] * arr[2, (i + 1) % 3]));
            return det;
        }
    }

    static void printResult(int[,] solutionMatrix)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(solutionMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

}






