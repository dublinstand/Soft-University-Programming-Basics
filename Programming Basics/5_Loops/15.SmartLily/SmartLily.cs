using System;

class SmartLily
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double pricePeralna = double.Parse(Console.ReadLine());
        int toyPrice = int.Parse(Console.ReadLine());

        int totalToys = 0;
        int savings = 0;

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                savings += 10 * i / 2;
            }
            else
            {
                totalToys += 1;
            }
        }

        savings = savings + (totalToys * toyPrice) - (n /2);
        double diff = Math.Abs(savings - pricePeralna);

        if (savings >= pricePeralna)
        {
            Console.WriteLine("Yes! {0:f2}", diff);
        }
        else
        {
            Console.WriteLine("No! {0:f2}", diff);
        }
    }
}

