using System;

class SquareFrame
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //string dashes = new string('-', n - 2);
        //Console.WriteLine("+{0}+", dashes);

        for (int col = 1; col <= n; col++)
        {
            if (col == 1 || col == n)
            {
                Console.Write("+ ");

                for (int i = 1; i <= n - 2; i++)
                {
                    Console.Write("- ");
                }

                Console.WriteLine("+");
            }
            else
            {
                Console.Write("| ");

                for (int i = 1; i <= n - 2; i++)
                {
                    Console.Write("- ");
                }

                Console.WriteLine("| ");

            }
        }
    }
}

