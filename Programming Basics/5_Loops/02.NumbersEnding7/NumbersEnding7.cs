using System;


class NumbersEnding7
{
    static void Main()
    {
        int counter = 0;

        for (int i = 0; i < 1001; i++)
        {
            if (i % 10 == 7)
            {
                counter += 1;
                Console.WriteLine(i);
            }
        }
        Console.WriteLine(counter);
    }
}

