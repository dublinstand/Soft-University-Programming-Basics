using System;

class Factorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int total = 1;

        do
        {
            total = total * n;
            n--;

        } while (n > 0);

        Console.WriteLine(total);
    }
}

