using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount, currency to convert from and currency to convert to: ");
            double amount = double.Parse(Console.ReadLine());
            String currencyFrom = Console.ReadLine();
            String currencyTo = Console.ReadLine();
            double currencyBought = 0;
            double currencySold = 0;


            switch (currencyFrom)
            {
                case "BGN":
                    currencyBought = 1;
                    break;
                case "USD":
                    currencyBought = 1.79549;
                    break;
                case "EUR":
                    currencyBought = 1.95583;
                    break;
                case "GBP":
                    currencyBought = 2.53405;
                    break;
            }

            switch(currencyTo)
            {
                case "BGN":
                    currencySold = 1;
                    break;
                case "USD":
                    currencySold = 1.79549;
                    break;
                case "EUR":
                    currencySold = 1.95583;
                    break;
                case "GBP":
                    currencySold = 2.53405;
                    break;
            }

            double convertedAmount = Math.Round(amount * currencyBought / currencySold, 2);

            Console.WriteLine("Converted amount is {0}", convertedAmount);



        }
    }
}
