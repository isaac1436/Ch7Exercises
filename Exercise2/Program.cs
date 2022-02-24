class Exercise2
{
    static void Main()
    {
        Console.Write("Please enter the length of the first array: ");
        int lengthOf1st = int.Parse(Console.ReadLine());
        Console.Write("Please enter the length of the second array: ");
        int lengthOf2nd = int.Parse(Console.ReadLine());
        bool equal;

        int[] firstArray = new int[lengthOf1st];
        int[] secondArray = new int[lengthOf2nd];

        Console.Write("Please enter the elements to be stored in the first array: ");
        for (int i = 0; i < lengthOf1st; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\n\nPlease enter the elements to be stored in the second array: ");
        for (int i = 0; i < lengthOf2nd; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        if (lengthOf1st == lengthOf2nd) { equal = true; }
        else { equal = false; }

        if (equal)
        {
            for (int i = 0; i < lengthOf2nd; i++)
            {
                if (firstArray[i] == secondArray[i]) { equal = true; }
                else { equal = false; }
            }
        }

        Console.WriteLine("Are the two arrays equal? THe answer is " + equal);
    }
}