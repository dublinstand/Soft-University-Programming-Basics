using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УчебнаЗала
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please ennter value for height: ");
            double h = double.Parse(Console.ReadLine());

            if (3 <= h && h <= 100)
            {
                Console.WriteLine("Correct value is entered");
            }
            else
            {
                throw new ArgumentOutOfBoundsException("The value must be between 3 and 100");
            }

            Console.WriteLine("Please ennter value for width: ");
            var w = double.Parse(Console.ReadLine());

            if (3 <= w && w <= 100)
            {
                Console.WriteLine("Correct value is entered");
            }
            else
            {
                throw new ArgumentOutOfBoundsException("The value must be between 3 and 100");
            }


            double rows = Math.Round( h  / 1.2);
            double beaureus = Math.Round((w-1)/0.7);

            var totalWorkPlaces = rows * beaureus - 3;

            Console.WriteLine("The total of work places is: {0}", totalWorkPlaces);
            




        }
    }
}
