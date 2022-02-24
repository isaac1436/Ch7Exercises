class Exercise4
{
    static void Main()
    {
        int tempCount = 0;
        Console.Write("Please enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter an array of integers: ");
        int[] ints = new int[length];

        for (int i = 0; i < length; i++)
        {
            ints[i] = int.Parse(Console.ReadLine());
        }

        int tempVal = 0, val = 0, count = 0;
        int[] ints2 = ints;
        for (int i = 0; i < ints.Length; i++)
        {
            for (int j = 0; j < ints.Length; j++)
            {
                if (ints[i] == ints2[j])
                {
                    tempVal = ints[i];
                    tempCount++;
                }
                else { tempCount = 0; }

                if (count < tempCount)
                {
                    count = tempCount;
                    val = ints[i];
                }
            }
        }

        Console.WriteLine("The largest conseutive sequence is " + count + " occurences of " + val);
    }
}