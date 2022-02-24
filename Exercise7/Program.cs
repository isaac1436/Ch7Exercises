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
        int maxSum = 0, sum = 0, limit = n - k, inc = 0, inc2 = k;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Please enter element {0}: ", i + 1);
            myArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i<n ; i++)
        {
            int tempsum = 0;
            for (int j = inc, l = 0; l < inc2; j++, l++)
            {

                if (j == n) { break; }
                tempset[l] = myArray[j];
                tempsum += subset[l];
                sum = tempsum;
            }

            k++;
            inc++;

            if (sum > maxSum)
            {
                maxSum = sum;
                subset = tempset;
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