class Exercise12
{
    static void Main()
    {
        Console.WriteLine("We will be working with matrices now");
        Console.Write("First, enter the number of rows for your matrix: ");
        int rows=int.Parse(Console.ReadLine());
        Console.Write("Now enter the number of columns: ");
        int cols=int.Parse(Console.ReadLine());

        int[,] matrix=new int[rows,cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("Element [{0},{1}]:  ",i+1,j+1);
                matrix[i,j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Please choose from the options below, how you would like to reresent your matrix");
        Console.WriteLine("1.\t column by column");
        Console.WriteLine("2.\t Vertical Snake");
        Console.WriteLine("3.\t A diagonal snake");
        Console.WriteLine("4.\t A spiral");

        Console.Write("Please make a choice: ");
        int choice=int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: 
                Exercise12.colByCol(matrix,rows,cols); 
                break;
        }
    }

    public static void colByCol(int [,] matrix,int rows,int cols)
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