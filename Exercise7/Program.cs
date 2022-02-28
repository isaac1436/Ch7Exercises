class Exercise7
{
    static void Main()
    {
        Console.Write("Please enter the size of your array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter the size of the subset you'd like to form: ");
        int k = int.Parse(Console.ReadLine());

        int[] myArray = new int[n];
        int[] tempset = new int[k];
        int[] subset = new int[k];
        int maxSum = 0, limit = n - k, inc = 0, inc2 = k;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Please enter element {0}: ", i + 1);
            myArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0;inc <= limit; i++)
        {
            int tempsum = 0;
            for (int j = inc, l = 0; l < inc2; j++, l++)
            {
                tempset[l] = myArray[j];
                tempsum += tempset[l];
            }

            k++;
            inc++;
            
            if (tempsum > maxSum)
            {
                maxSum = tempsum;
                for (int m = 0; m < inc2; m++)
                {
                    subset[m] = tempset[m];
                }
            }

        }

        Console.WriteLine("The maximum sum is: " + maxSum);
        Console.Write("The elements involved are: ");

        for (int i = 0; i < inc2; i++)
        {
            Console.Write(subset[i] + " ");
        }
    }
}