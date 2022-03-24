class Exercise19
{
    static void Main()
    {
        Console.WriteLine(" A list of prime numbers between 1 and " + ulong.MaxValue + " :   ");
        prime(1000);
    }

    public static void prime(ulong val)
    {
        ulong limit =val;
        for (ulong i = 2; i < limit; i++)
        {
            for (ulong j = i-1; j > 0; j--)
            {
                if (j % i == 0)
                {
                    break;
                }
            }
            Console.Write(i + " ");
        }
    }
}