﻿using System;

class Fibonacci
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int f0 = 1;
        int f1 = 1;

        if (n < 2)
        {
            Console.WriteLine("1");
            return;
        }

        for (int i = 0; i < n - 1; i++)
        {
            var fNext = f0 + f1;
            f0 = f1;
            f1 = fNext;
        }
        Console.WriteLine(f1);

    }
}

