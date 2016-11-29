using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class SumSeconds
    {
        static void Main(string[] args)
        {
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());

            int sum = time1 + time2 + time3;

            int minutes = sum / 60;
            int seconds = sum % 60;
            String secondsToString = seconds.ToString();


            if(seconds < 10)
            {
                secondsToString = "0" + secondsToString;
            }

            Console.WriteLine("{0}:{1}", minutes, secondsToString);


        }
    }
}
