using System;

class Division
{
    static void Main()
    {
        double n = int.Parse(Console.ReadLine());

        double c1 = 0;
        double c2 = 0;
        double c3 = 0;

        for (int i = 1; i <= n; i++)
        {
            double num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                c1 += 1;
            }
            if (num % 3 == 0)
            {
                c2 += 1;
            }
            if (num % 4 == 0)
            {
                c3 += 1;
            }
        }

        double p1 = c1 / n * 100;
        double p2 = c2 / n * 100;
        double p3 = c3 / n * 100;

        Console.WriteLine("{0:f2}%", p1);
        Console.WriteLine("{0:f2}%", p2);
        Console.WriteLine("{0:f2}%", p3);
    }
}

