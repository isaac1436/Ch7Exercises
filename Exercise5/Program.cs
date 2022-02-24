class Exercise5
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

        int tempVal = 0;
        int[] ints2 = ints;

        for (int i = 0; i < length-1; i++)
        {

            if (ints[i] + 1 == ints2[i + 1])
            {
                ints2[tempVal] = ints[i];
                tempVal++;
            }
            else { break; }

        }


        Console.Write("The largest conseutive sequence is " );
        for (int i = 0; i <= tempVal; i++) 
        { 
            Console.Write(ints2[i]); 
        }
    }
}