class Exercise7
{
    static void Main()
    {
        int maxSum = 0,tempSum=0;
        Console.Write("Please enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter the length of the subset you would like to form: ");
        int k = int.Parse(Console.ReadLine()); 
        Console.WriteLine("Please enter an array of integers: ");
        int[] ints = new int[n];
        int count = n/k;
        int l = 0,m=0,p=0;

        for (int i = 0; i < n; i++)
        {
            ints[i] = int.Parse(Console.ReadLine());
        }

        int[] subset = new int[k];
        int[] tempset = new int[k];

        for (int i = 0; i < count; i++)
        {
            for(int j = m; j < k; j++)
            {
                tempSum += ints[j];
                tempset[p] = ints[j];
                if(tempSum > maxSum)
                {
                   maxSum = tempSum;
                    subset = tempset;
                }
                p++;
            }
            m++;
            k++;
        }

        Console.Write("The subset with the greatest sum is ");

        for(int i=0; i<k; i++)
        {
            Console.Write(" "+subset[i]);
        }

        Console.Write(" with a sum of "+maxSum);
    }
}