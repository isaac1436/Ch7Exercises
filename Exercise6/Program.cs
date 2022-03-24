class Exercise6
{
    static int[] ints;
    static int length;
    static void Main()
    {
        bool errorCatch = false;
        Console.Write("Please enter the length of your array: ");
        while (errorCatch == false)
        {
            errorCatch = int.TryParse(Console.ReadLine(), out length);
        }

        ints = new int[length];
        errorCatch = false;
        int lim = 0;

        Console.WriteLine("\nPlease enter the integers to be stored in the array: ");
        while (lim < length)
        {
            errorCatch = int.TryParse(Console.ReadLine(), out ints[lim]);
            if (errorCatch) { lim++; }
        }

        SubSeq();
    }

    static void SubSeq()
    {
        int tempVal = 0; int maxCount = 0;
        int[] ints2 = new int[length];
        int[] finalResult = new int[length];

        for (int i = 0; i < length; i++)
        {
            int count = 0;
            tempVal = ints[i];
            for (int j = i + 1, k = 0; j < length; j++, k++)
            {
                if (tempVal < ints[j])
                {
                    ints2[k] = tempVal;
                    tempVal = ints[j];
                    count++;
                }
            }

            if (count > maxCount)
            {
                maxCount = count;
                for (int j = 0; j <= maxCount; j++)
                {
                    finalResult[j] = ints2[j];
                }
            }

        }


        Console.Write("\n\nThe largest conseutive sequence is { " + finalResult[0]);
        for (int i = 1; i <= maxCount; i++)
        {
            Console.Write(", " + finalResult[i]);
        }
        Console.Write(" }");
    }
}