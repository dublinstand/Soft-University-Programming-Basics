using System;

class Diamond
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int stars = 1;
        int outerDashes = (n - 1) / 2;

        if (n == 1 || n == 2)
        {
            Console.WriteLine("{0}", new string('*', n));
            return;
        }

        if (n % 2 == 0)
        {
            stars = 2;
        }

        int innnerDashes = stars;
        Console.WriteLine("{0}{1}{0}", new string('-', outerDashes), new string('*', stars));

        for (int i = 0; i < ((n + 1) / 2) - 1; i++)
        {
            outerDashes -= 1;

            Console.WriteLine("{0}*{1}*{0}", new string('-', outerDashes), new string('-', innnerDashes));
            innnerDashes += 2;      
        }

        innnerDashes -= 4;

        for (int i = 0; i < ((n + 1) / 2) - 2 ; i++)
        {
            outerDashes += 1;

            Console.WriteLine("{0}*{1}*{0}", new string('-', outerDashes), new string('-', innnerDashes));
            innnerDashes -= 2;

            if (innnerDashes < 0)
            {
                innnerDashes = 0;
            }

        }

        outerDashes = (n - 1) / 2;
        Console.WriteLine("{0}{1}{0}", new string('-', outerDashes), new string('*', stars));

    }
}

