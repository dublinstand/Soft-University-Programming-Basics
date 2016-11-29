using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000DaysInTheFuture
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            string futureDays = today.AddDays(1000).ToString("dd-MM-yyyy");
            //string formatted = futureDays.ToString("dd-MM-yyyy");               
            Console.WriteLine("1000 days from today will be: " +futureDays);
        }
    }
}
