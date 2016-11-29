using System;

class Histogram
{
    static void Main()
    {
        double n = int.Parse(Console.ReadLine());

        double c1 = 0;
        double c2 = 0;
        double c3 = 0;
        double c4 = 0;
        double c5 = 0;

        for (int i = 1; i <= n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 200)
            {
                c1 += 1;
            }
            else if (200 <= num && num < 400)
            {
                c2 += 1;
            }
            else if (400 <= num && num < 600)
            {
                c3 += 1;
            }
            else if (600 <= num && num < 800)
            {
                c4 += 1;
            }
            else
            {
                c5 += 1;
            }
        }
        double p1 = c1 / n * 100;
        double p2 = c2 / n * 100; ;
        double p3 = c3 / n * 100; ;
        double p4 = c4 / n * 100; ;
        double p5 = c5 / n * 100; ;

        Console.WriteLine("{0:f2}%", p1);
        Console.WriteLine("{0:f2}%", p2);
        Console.WriteLine("{0:f2}%", p3);
        Console.WriteLine("{0:f2}%", p4);
        Console.WriteLine("{0:f2}%", p5);

    }
}

