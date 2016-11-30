using System;

class StupidPasswordGenerator
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                for (char k = 'a'; k < 'a' + l; k++)
                {
                    for (char w = 'a'; w < 'a' + l; w++)
                    {
                        for (int q = Math.Max(i, j) + 1; q <= n; q++)
                        {
                            Console.Write("{0}{1}{2}{3}{4} ", i, j, k, w, q);
                        }
                    }
                }
            }
        }
    }
}

