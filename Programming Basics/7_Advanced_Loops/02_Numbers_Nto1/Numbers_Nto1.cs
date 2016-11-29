using System;


class Numbers_Nto1
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = n; i >= 1; i -= 1)
        {
            Console.WriteLine(i);
        }
    }
}

