class Exercise10
{
    static void Main()
    {
        int maxCount = 0, maxVal = 0, maxValCount = 0, k = 0;
        Console.Write("We will now be finding the element with the most occurences in an array,"
       + "But first please enter the length of the array you would like to form: ");
        int arrLength = int.Parse(Console.ReadLine());

        Console.WriteLine("\n\nPlease enter the elements of your array below: ");
        int[] arr = new int[arrLength];
        int[] backUp = new int[arrLength];

        for (int i = 0; i < arrLength; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arrLength; i++)
        {
            int count = 0;
            for (int j = i; j < arrLength; j++)
            {
                if (arr[j] == arr[i])
                {
                    count++;
                }
            }

            if (count > maxCount)
            {
                maxCount = count;
                maxVal = arr[i];
                maxValCount = 0;
            }

            if (count == maxCount)
            {
                backUp[k] = arr[i];
                maxValCount++;
                k++;
            }
        }
        if (maxValCount == 0)
        {
            Console.WriteLine("\n\nAfter extensive calculations, the most occuring value is " + maxVal + " which occurs a total of " + maxCount + " times");
        }

        if (maxValCount != 0)
        {
            Console.Write("\n\nAfter extensive calculations, the most occuring values are ");

            for (int i = 0; i < maxValCount; i++)
            {
                Console.Write(backUp[i] + " ");
            }

            Console.Write(" which occurs a total of " + maxCount + " times each");
        }
    }
}