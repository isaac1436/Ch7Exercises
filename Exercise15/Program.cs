class Exercise15
{
    static void Main()
    {

        Console.Write("Please enter a word and end it with a full stop or period: ");
        int count = 0;
        char[] letters = new char[25];
        do
        {
            var x=Console.Read();
           letters[count] = Convert.ToChar(x);
            if(letters[count] == '.') { break; }
            count++;
        }

        while (count<25);

        LetterIndices(letters,count);
    }

    static void LetterIndices(char[] letters,int count)
    {
        char[,] alphabets = new char[,] {{'a','b','c','d','e','f','g','h','i','j','k','l','m','n',
        'o','p','q','r','s','t','u','v','w','x','y','z'},
        {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S',
        'T','U','V','W','X','Y','Z'} };

        int[] indices = new int[count];
        for (int i = 0; i < count; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                if (letters[i] == alphabets[0, j])
                {
                    indices[i] = j+1;
                    break;
                }

                else if (letters[i] == alphabets[1, j])
                {
                    indices[i] = j+1;
                    break;
                }
            }
        }

        for(int i = 0; i < count; i++)
        {
            Console.WriteLine("\nTHe Character {0} has an alphabet position of {1}",letters[i],indices[i]);
        }
    }
}