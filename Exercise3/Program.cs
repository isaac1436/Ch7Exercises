class Exercise3
{
    static void Main()
    {
        Console.WriteLine("Today we will be comparing two arrays of type char lexicographically");
        int lexCount = 0;
        char lexOrder;

        Console.Write("Please enter the length of the first array: ");
        int firstLength = int.Parse(Console.ReadLine());
        Console.WriteLine("Now please enter the contents of the first array: ");
        char[] firstArray = new char[firstLength];
        for (int i = 0; i < firstLength; i++)
        {
            firstArray[i] = Convert.ToChar(Console.ReadLine());
        }

        Console.Write("Please enter the length of the second array: ");
        int secondLength = int.Parse(Console.ReadLine());
        Console.WriteLine("Now please enter the contents of the first array: ");
        char[] secondArray = new char[firstLength];
        for (int i = 0; i < secondLength; i++)
        {
            secondArray[i] = Convert.ToChar(Console.ReadLine());
        }
        lexCount=secondArray.Length;
        if (firstArray.Length < secondArray.Length) { lexCount = firstArray.Length; }
        if (firstArray.Length > secondArray.Length) { lexCount = secondArray.Length; }

        for (int i = 0; i < lexCount; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                Console.WriteLine("The values of both arrays in index " + i + " are equal");
                continue;
            }

            if (secondArray[i] > firstArray[i])
            {
                Console.WriteLine("The value of the second array stored in index {0} ({1}) is lexicoprahically superior" +
                    " to its counter part in the first array", i, secondArray[i]);
                continue;
            }

            if (secondArray[i] < firstArray[i])
            {
                Console.WriteLine("The value of the first array stored in index {0} ({1}) is lexicoprahically superior" +
                    " to its counter part in the second array", i, firstArray[i]);
                continue;
            }
        }

    }
}