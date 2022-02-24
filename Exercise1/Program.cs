class Exercise1
{
    static void Main()
    {
        int[] twenty = new int[20];

        for (int i = 0; i < twenty.Length; i++)
        {
            twenty[i] = i*5;
        }

        for (int i = 0;i < twenty.Length; i++)
        {
            Console.Write(twenty[i]+" ");
        }
    }
}