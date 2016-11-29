using System;

class StopSign
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int dots = n + 1;
        int underScore = (n * 2) + 1;
        int middleLine = (n * 2) - 3;

        Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('_', underScore));
        underScore -= 2;

        for (int i = 1; i <= n; i++)
        {
            dots -= 1;
            Console.WriteLine(@"{0}//{1}\\{0}", new string('.', dots), new string('_', underScore));
            underScore += 2;
        }

        Console.WriteLine(@"//{0}STOP!{0}\\", new string('_', middleLine));
        Console.WriteLine(@"\\{0}//", new string('_', n * 4 - 1));
        underScore -= 2;

        for (int i = 1; i <= n - 1; i++)
        {
            Console.WriteLine(@"{0}\\{1}//{0}", new string('.', dots), new string('_', underScore));
            underScore -= 2;
            dots += 1;
        }

    }
}

