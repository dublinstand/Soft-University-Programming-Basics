using System;

class HalfSumElement
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int biggestNum = 0;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (biggestNum < num)
            {
                biggestNum = num;
            }
            sum += num;

        }

        int sumNew = sum - biggestNum;

        if (sumNew == biggestNum)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Sum = {0}", sumNew);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("Diff = {0}", Math.Abs(sumNew - biggestNum));
        }
    }
}

