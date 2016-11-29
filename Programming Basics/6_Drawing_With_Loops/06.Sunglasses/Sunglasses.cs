using System;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string dashes = new string('/', (n * 2) - 2);
        string columns = new string('|', n);
        string lineSample = new string('*', 2 * n);
        string spaces = new string(' ', n);

        Console.Write(lineSample);
        Console.Write(spaces);
        Console.WriteLine(lineSample);

        for (int j = 1; j <= n - 2; j++)
        {
            if (j == ((n - 1) / 2) )
            {
                Console.Write("*{0}*", dashes);
                Console.Write(columns);
                Console.WriteLine("*{0}*", dashes);

            }
            else
            {
                Console.Write("*{0}*", dashes);
                Console.Write(spaces);
                Console.WriteLine("*{0}*", dashes);
            }

        }

        Console.Write(lineSample);
        Console.Write(spaces);
        Console.WriteLine(lineSample);

    }
}

