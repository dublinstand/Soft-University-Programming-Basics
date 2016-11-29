using System;

class Trip
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine().ToLower();

        double amountSpent = 0;
        string typeOfHoliday = "";
        string destination = "";

        if (season == "summer")
        {
            typeOfHoliday = "Camp";
        }
        else if (season == "winter")
        {
            typeOfHoliday = "Hotel";
        }

        if (budget <= 100)
        {
            destination = "Bulgaria";

            if (season == "summer")
            {
                amountSpent = 0.3 * budget;
            }
            else if (season == "winter")
            {
                amountSpent = 0.7 * budget;
            }
        }
        else if (100 < budget && budget <= 1000)
        {
            destination = "Balkans";

            if (season == "summer")
            {
                amountSpent = 0.4 * budget;
            }
            else if (season == "winter")
            {
                amountSpent = 0.8 * budget;
            }            
        }
        else
        {
            destination = "Europe";
            amountSpent = 0.9 * budget;
            typeOfHoliday = "Hotel";
        }

        Console.WriteLine("Somewhere in {0}", destination);
        Console.WriteLine("{0} - {1:f2}", typeOfHoliday, amountSpent);
    }
}

