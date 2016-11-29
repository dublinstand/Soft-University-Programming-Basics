using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            var time = Console.ReadLine();
            double price = 0;


            if (0 < distance && distance < 20)
            {
                if (time == "day")
                {
                    price = 0.7 + (distance * 0.79);
                }
                else if (time == "night")
                {
                    price = 0.7 + (distance * 0.9);
                }
            }
            else if (20 <= distance && distance < 100)
            {
                price = distance * 0.09;
            }
            else if(distance <= 5000)
            {
                price = distance * 0.06;
            }

            Console.WriteLine(price);
        }
        
    }
}
