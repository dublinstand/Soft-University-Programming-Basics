using System;

class MinNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int smallestNumber = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < smallestNumber)
            {
                smallestNumber = number;
            }
        }
        Console.WriteLine(smallestNumber);
    }
}

