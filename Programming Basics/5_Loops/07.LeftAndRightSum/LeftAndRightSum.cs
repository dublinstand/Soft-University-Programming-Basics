using System;

class LeftAndRightSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int leftSum = 0;
        int rightSum = 0;
        int totalSum = 0;


        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            leftSum += number;
        }

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            rightSum += number;
        }

        if(leftSum == rightSum)
        {
            Console.WriteLine($"Yes, sum = {leftSum}");
        }
        else
        {
            totalSum = Math.Abs(leftSum - rightSum);
            Console.WriteLine("No, diff = {0}", totalSum);
        }

    }
}

