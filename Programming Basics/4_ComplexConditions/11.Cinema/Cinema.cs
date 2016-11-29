using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Cinema
{
    static void Main(string[] args)
    {
        string type = Console.ReadLine().ToLower();
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());

        double ticketPrice = -1;
        double totalEarngings = 0;


        if (type == "premiere")
        {
            ticketPrice = 12;
        }
        else if (type == "normal")
        {
            ticketPrice = 7.5;
        }
        else if (type == "discount")
        {
            ticketPrice = 5;
        }

        if (ticketPrice > 0)
        {
            totalEarngings = (row * col) * ticketPrice;
            Console.WriteLine("{0:f2} leva", totalEarngings);
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}

