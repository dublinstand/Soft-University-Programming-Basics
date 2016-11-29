using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15Minutes
{
    class TimePlus15Minutes
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int minutes15 = minutes + 15;

            if (minutes15 > 59)
            {
                hours = hours + 1;
                minutes15 = minutes15 - 60;
            }

            if(hours == 24)
            {
                hours = 0;
            }

            String minutes15ToString = minutes15.ToString();

            if (minutes15 < 10)
            {
                minutes15ToString = "0" + minutes15.ToString();
            }

            Console.WriteLine("{0}:{1}", hours, minutes15ToString);
        }
    }
}
