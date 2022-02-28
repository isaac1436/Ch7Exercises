class Exercise8
{
    static void Main()
    {
        int a, b, arrLength, choice;
        a = b = 0;
        Console.Write("We will now be sorting an array based on your specifications,"
        + "But first please enter the length of the array you would like to form: ");
        arrLength = int.Parse(Console.ReadLine());

        Console.WriteLine("\n\nPlease enter the elements of your array below: ");
        int[] arr = new int[arrLength];

        for (int i = 0; i < arrLength; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\n\nPlease choose 1 to sort in ascending order and 2 to sort in descending order: ");
        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                ascSort(arr, arrLength, a, b);
                break;


            case 2:
                descSort(arr, arrLength, a, b);
                break;
        }
    }

    public static void ascSort(int[] arr, int arrLength, int a, int b)
    {
        for (int i = 0; i < arrLength; i++)
        {
            a = i;
            for (int j = i + 1; j < arrLength; j++)
            {
                if (arr[j] < arr[a])
                {
                    a = j;
                }
            }

            b = arr[i];
            arr[i] = arr[a];
            arr[a] = b;
        }

        Console.Write("\n\nThe sorted array is: ");

        foreach (int element in arr)
        {
            Console.Write(element);
        }
    }


    public static void descSort(int[] arr, int arrLength, int a, int b)
    {
        for (int i = 0; i < arrLength; i++)
        {
            a = i;
            for (int j = i + 1; j < arrLength; j++)
            {
                if (arr[j] > arr[a])
                {
                    a = j;
                }
            }

            b = arr[i];
            arr[i] = arr[a];
            arr[a] = b;
        }

        Console.Write("\n\nThe sorted array is: ");

        foreach (int element in arr)
        {
            Console.Write(element);
        }
    }
}