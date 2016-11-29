using System;

class RhombusOfStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n == 1)
        {
            Console.WriteLine("*");

            return;
        }

        for (int row = 1; row <= n; row++)
        {
            Console.Write("{0}", new string(' ', n - row));
            Console.Write("*");

            for (int column = 1; column <= row - 1; column++)
            {
                Console.Write(" *");
            }

            Console.WriteLine();
        }

        for (int row = 1; row < n; row++)
        {
            Console.Write("{0}", new string(' ', row));
            Console.Write("*");

            for (int col = n - 1; col > row; col--)
            {
                Console.Write(" *");
            }

            Console.WriteLine();

        }

    }
}

