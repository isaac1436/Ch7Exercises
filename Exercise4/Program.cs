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

        int val = 0, count = 2;
        int[] ints2 = ints;
        int[] ints3 = new int[length];
        int rptCount=1;
        for (int i = 0; i < ints.Length; i++)
        {
            for (int j = i; j < ints.Length; j++)
            {
                if (ints[i] == ints2[j])
                {
                    int tempVal = ints[i];
                    tempCount++;
                }
                else { tempCount = 0; }

                if (count < tempCount)
                {
                    count = tempCount;
                    val = ints[i];
                    ints3[rptCount] = val;
                }

                if (count == tempCount && val != ints[i])
                {
                    ints3[++rptCount]=ints[i];
                }
            }
            if (ints[i] == ints2[i])
            {
                i++;
            }
        }

        if (rptCount == 0)
        {
            Console.WriteLine("The largest conseutive sequence is " + count + " occurences of " + val);
        }

        else if(rptCount!=0 && rptCount>=count)
        {
            Console.Write("The largest conseutive sequence is " + count + " occurences of ");

            for(int i=0; i<rptCount; i++)
            {
                Console.Write(ints3[i]+" ");
            }
        }
    }
}