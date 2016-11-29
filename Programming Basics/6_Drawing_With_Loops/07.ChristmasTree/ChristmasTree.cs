using System;

class ChristmasTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //string spaces = new string(' ', n);
        for (int i = 0; i <= n; i++)
        {
            Console.Write("{0}{1}", new string(' ', n - i), new string('*', i));
            Console.Write(" | ");
            Console.WriteLine("{0}", new string('*', i));
        }
    }
}

