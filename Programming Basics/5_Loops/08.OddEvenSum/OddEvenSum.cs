using System;

class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int oddSum = 0;
        int evenSum = 0;
        int diff = 0;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                oddSum += number;
            }
            else
            {
                evenSum += number;
            }
        }

        if (oddSum == evenSum)
        {
            Console.WriteLine("Yes");
            Console.WriteLine($"Sum = {oddSum}");
        }
        else
        {
            diff = Math.Abs(oddSum - evenSum);
            Console.WriteLine("No");
            Console.WriteLine("Diff = {0}", diff);
        }

    }
}

