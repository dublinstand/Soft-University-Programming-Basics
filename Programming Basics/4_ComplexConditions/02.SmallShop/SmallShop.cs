using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SmallShop
{
    static void Main(string[] args)
    {
        String product = Console.ReadLine().ToLower();
        String city = Console.ReadLine().ToLower();
        double quantity = double.Parse(Console.ReadLine());
        double price = 0;

        if (city == "sofia")
        {
            if(product == "coffee")
            {
                price = quantity * 0.5;
            }
            else if (product == "water")
            {
                price = quantity * 0.8;
            }
            else if (product == "beer")
            {
                price = quantity * 1.2;
            }
            else if (product == "sweets")
            {
                price = quantity * 1.45;
            }
            else if (product == "peanuts")
            {
                price = quantity * 1.6;
            }
        }
        else if(city == "plovdiv")
        {
            if (product == "coffee")
            {
                price = quantity * 0.40;
            }
            else if (product == "water")
            {
                price = quantity * 0.70;
            }
            else if (product == "beer")
            {
                price = quantity * 1.15;
            }
            else if (product == "sweets")
            {
                price = quantity * 1.30;
            }
            else if (product == "peanuts")
            {
                price = quantity * 1.50;
            }
        }
        else if (city == "varna")
        {
            if (product == "coffee")
            {
                price = quantity * 0.45;
            }
            else if (product == "water")
            {
                price = quantity * 0.70;
            }
            else if (product == "beer")
            {
                price = quantity * 1.10;
            }
            else if (product == "sweets")
            {
                price = quantity * 1.35;
            }
            else if (product == "peanuts")
            {
                price = quantity * 1.55;
            }
        }
        Console.WriteLine(price);
    }
}

