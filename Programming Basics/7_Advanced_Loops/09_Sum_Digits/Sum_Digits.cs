using System;

class Sum_Digits
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int sum = 0;
        int newNum;

        while (num > 0)
        {
            newNum = num % 10;
            sum = sum + newNum;
            num = num / 10;
        }

        Console.WriteLine(sum);
    }
}

