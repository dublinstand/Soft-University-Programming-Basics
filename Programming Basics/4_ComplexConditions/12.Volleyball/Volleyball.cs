using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Volleyball
{
    static void Main(string[] args)
    {
        string typeOfYear = Console.ReadLine().ToLower();
        int holidays = int.Parse(Console.ReadLine());
        int weekendsAtHometown = int.Parse(Console.ReadLine());

        int weekendsInSofia = 48 - weekendsAtHometown;
        double playsInSofia = weekendsInSofia * 3.0 / 4;
        double playsAtHomeTown = weekendsAtHometown;
        double playsDuringHolidays = holidays * 2.0 / 3;

        double totalVolleyballDays = playsInSofia + playsAtHomeTown + playsDuringHolidays;

        if (typeOfYear == "leap")
        {
            totalVolleyballDays = totalVolleyballDays + (totalVolleyballDays * 0.15);
        }

        Console.WriteLine(Math.Truncate(totalVolleyballDays));
    }
}

