using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Butterfly
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string asterisks = new string('*', n - 2);
        string dashes = new string('-', n - 2);

        for (int i = 0; i < n - 2; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(asterisks + "\\ /" + asterisks);
            }
            else
            {
                Console.WriteLine(dashes + "\\ /" + dashes);
            }
        }

        string spaces = new string(' ', n - 1);
        Console.WriteLine(spaces + "@");

        for (int i = 0; i < n - 2; i++)
        {
            if(i % 2 == 0)
            {
                Console.WriteLine(asterisks + "/ \\" + asterisks);
            }
            else
            {
                Console.WriteLine(dashes + "/ \\" + dashes);
            }
        }

    }
}

