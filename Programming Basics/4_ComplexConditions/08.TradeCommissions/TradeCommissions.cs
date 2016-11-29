using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TradeCommissions
{
    static void Main(string[] args)
    {
        String city = Console.ReadLine().ToLower();
        double sales = double.Parse(Console.ReadLine());

        double commission = -1;
        double earnings = 0;

        if (city == "sofia")
        {
            if (0 <= sales && sales <= 500 )
            {
                commission = 0.05;
            }
            else if (500 < sales && sales <= 1000)
            {
                commission = 0.07;
            }
            else if (1000 < sales && sales <= 10000)
            {
                commission = 0.08;
            }
            else if(10000 < sales)
            {
                commission = 0.12;
            }
        }
        else if (city == "varna")
        {
            if (0 <= sales && sales <= 500)
            {
                commission = 0.045;
            }
            else if (500 < sales && sales <= 1000)
            {
                commission = 0.075;
            }
            else if (1000 < sales && sales <= 10000)
            {
                commission = 0.1;
            }
            else if (10000 < sales)
            {
                commission = 0.13;
            }
        }
        else if (city == "plovdiv")
        {
            if (0 <= sales && sales <= 500)
            {
                commission = 0.055;
            }
            else if (500 < sales && sales <= 1000)
            {
                commission = 0.08;
            }
            else if (1000 < sales && sales <= 10000)
            {
                commission = 0.12;
            }
            else if (10000 < sales)
            {
                commission = 0.145;
            }
        }

        if (commission > 0)
        {
            earnings = sales * commission;
            Console.WriteLine("{0:f2}",earnings);
        }
        else
        {
            Console.WriteLine("error");
        }

    }
}

