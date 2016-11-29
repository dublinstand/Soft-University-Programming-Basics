using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPoints
{
    class BonusPoints
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double bonus = 0;

            if(num <= 100)
            {
                bonus = 5;
            }
            else if (num < 1000)
            {
                bonus = 0.2 * num;
            }
            else
            {
                bonus = 0.1 * num;
            }

            if(num % 2 == 0)
            {
                bonus = bonus + 1;
            }
            else if (num % 10 == 5)
            {
                bonus = bonus + 2;
            }

            Console.WriteLine("Bonus score: {0}", bonus);
            Console.WriteLine("Total score: {0}", num+bonus);



        }
    }
}
