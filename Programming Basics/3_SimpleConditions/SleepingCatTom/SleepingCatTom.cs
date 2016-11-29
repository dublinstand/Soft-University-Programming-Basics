using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepingCatTom
{
    class SleepingCatTom
    {
        static void Main(string[] args)
        {
            int restDays = int.Parse(Console.ReadLine());
            int workDays = 365 - restDays;
            int normPlay = 30000;

            int totalWorkPlay = 63 * workDays;
            int totalRestPlay = 127 * restDays;
            int totalPlay = totalRestPlay + totalWorkPlay;

            int playTime = Math.Abs(normPlay - totalPlay);
            int hours = playTime / 60;
            int minutes = playTime - (hours * 60);


            if (normPlay < totalPlay)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }


        }
    }
}
