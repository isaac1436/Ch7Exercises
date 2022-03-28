class Exercise13
{
    static int[,] ints;
    static int n,m;
    static void Main()
    {
        bool errorCatch = false;
        Console.Write("Please enter the length of the columns of your array: ");
        while (errorCatch == false)
        {
            errorCatch = int.TryParse(Console.ReadLine(), out n);
        }

        errorCatch = false;
        Console.Write("Please enter the length of the rows of your array: ");
        while (errorCatch == false)
        {
            errorCatch = int.TryParse(Console.ReadLine(), out m);
        }

        ints = new int[n,m];
        errorCatch = false;
        int lim = 0;

        Console.WriteLine("\nPlease enter the integers to be stored in the array: ");
        for(int i = 0; i < n; i++)
        {
            for(int j=0; j < m; )
            {
                Console.Write("\nEnter the value to be stored in [{0},{1}]: ", i, j);
                errorCatch= int.TryParse(Console.ReadLine(), out ints[i,j]);
                if (errorCatch) { j++; }
                else { Console.WriteLine("\nInvalid value entered, Please try again\n"); }
            }
        }

        if (n >= 3 && m >= 3)
        {
            maximalPlatform(ints, n, m);
        }
        else { Console.WriteLine("\nThe array does not match the requirements. Try again later"); }
        
    }

    static void maximalPlatform(int[,]ints,int n,int m)
    {
        int maxSum = 0,maxRow=0,maxCol=0;

        for(int row = 0; row < n - 2; row++)
        {
            for(int col = 0; col < m - 2; col++)
            {
                int sum=ints[row,col]+ ints[row, col+1]+ ints[row, col+2]+ ints[row+1, col] + ints[row + 1, col+1] + ints[row + 1, col+2]+ 
                    ints[row+2, col] + ints[row + 2, col+1] + ints[row + 2, col+2];

                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxRow = row;
                    maxCol = col;
                }
            }
        }
        printArray(maxSum, maxCol, maxRow);
    }

    static void printArray(int maxSum, int maxCol, int maxRow)
    {
        Console.WriteLine("\nThe 3 x 3 platform with a maximal sum of {0} is :",maxSum);
        for(int i=maxRow; i < maxRow+3; i++)
        {
            for(int j=maxCol;j < maxCol+3; j++)
            {
                Console.Write(ints[i,j]+" ");
            }
            Console.WriteLine();
        }
    }
}