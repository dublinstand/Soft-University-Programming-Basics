using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FruitShop
{
    static void Main(string[] args)
    {
        String fruit = Console.ReadLine().ToLower();
        String dayOfWeek = Console.ReadLine().ToLower();
        double kilos = double.Parse(Console.ReadLine());
        double pricePerKg = -1;
        double totalPrice = 0;


        if (dayOfWeek == "saturday" || dayOfWeek == "sunday")
        {
            if (fruit == "banana")
            {
                pricePerKg = 2.70;
            }
            else if (fruit == "apple")
            {
                pricePerKg = 1.25;
            }
            else if (fruit == "orange")
            {
                pricePerKg = 0.90;
            }
            else if (fruit == "grapefruit")
            {
                pricePerKg = 1.60;
            }
            else if (fruit == "kiwi")
            {
                pricePerKg = 3.00;
            }
            else if (fruit == "pineapple")
            {
                pricePerKg = 5.60;
            }
            else if (fruit == "grapes")
            {
                pricePerKg = 4.20;
            }

        }
        else if (dayOfWeek == "monday" || 
                dayOfWeek == "tuesday" || 
                dayOfWeek == "wednesday" || 
                dayOfWeek == "thursday" || 
                dayOfWeek == "friday")
        {

            if (fruit == "banana")
            {
                pricePerKg = 2.50;
            }
            else if (fruit == "apple")
            {
                pricePerKg = 1.20;
            }
            else if (fruit == "orange")
            {
                pricePerKg = 0.85;
            }
            else if (fruit == "grapefruit")
            {
                pricePerKg = 1.45;
            }
            else if (fruit == "kiwi")
            {
                pricePerKg = 2.70;
            }
            else if (fruit == "pineapple")
            {
                pricePerKg = 5.50;
            }
            else if (fruit == "grapes")
            {
                pricePerKg = 3.85;
            }

        }

        if (pricePerKg != -1)
        {
            totalPrice = kilos * pricePerKg;
            Console.WriteLine("{0:f2}", totalPrice);
        }
        else
        {
            Console.WriteLine("error");            
        }

    }

}


