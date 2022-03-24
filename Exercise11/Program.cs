class Exericse11
{
    static int[] ints;
    static int length, sum;
    static void Main()
    {
        bool errorCatch = false;
        Console.Write("How many numbers would you like to enter: ");
        while (errorCatch == false)
        {
            errorCatch = int.TryParse(Console.ReadLine(), out length);
        }

        ints = new int[length];
        int lim = 0;
        Console.WriteLine("\nPlease enter the numbers for the array: ");
        while (lim < length)
        {
            errorCatch = int.TryParse(Console.ReadLine(), out ints[lim]);
            if (errorCatch) { lim++; }
        }
        Console.Write("\nWhat sum are you aiming for: ");
        errorCatch = int.TryParse(Console.ReadLine(), out sum);

        Console.Write("The subsets that fit the conditions set are: ");
        SubSetSum();
    }

    static void SubSetSum()
    {
        for (int i = 0; i < length; i++)
        {
            int count = 0;
            int tempSum = 0;
            for (int j = i; j < length;j++)
            {
                tempSum += ints[j];
                if (tempSum == sum)
                {
                    count = j;
                    PrintSubset(count, i);
                    break;
                }

            }

        }
    }

    static void PrintSubset(int count, int start)
    {
        Console.Write("{ " + ints[start]);
        for (int i = start + 1; i <= count; i++)
        {
            Console.Write(", " + ints[i]);
        }
        Console.Write(" }\t");
    }
}