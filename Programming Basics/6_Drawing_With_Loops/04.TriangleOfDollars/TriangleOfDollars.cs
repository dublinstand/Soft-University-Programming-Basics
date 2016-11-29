using System;

class TriangleOfDollars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int col = 1; col <= n; col++)
        {
            for (int row = 1; row <= col; row++)
            {
                Console.Write("$ ");
            }
            Console.WriteLine();
        }
    }
}

