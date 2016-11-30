using System;

class Number_Table
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int num;

        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                num = row + col + 1;

                if (num < n )
                {
                    Console.Write(num + " ");                    
                }
                else
                {
                    num = 2 * n - num;
                    Console.Write(num + " ");
                }
            }

            Console.WriteLine();

        }
    }
}

