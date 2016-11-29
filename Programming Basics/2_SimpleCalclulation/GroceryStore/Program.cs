using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the price of vegetables: ");
            double vegetablesPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the price of fruits: ");
            double fruitsPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the kilos for vegetables: ");
            double vegetablesKilos = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the kilos of fruits: ");
            double fruitsKilos = double.Parse(Console.ReadLine());

            if (0.00 <= vegetablesPrice && vegetablesPrice <= 1000.00 &&  0.00 <= fruitsPrice
                && fruitsPrice <= 1000.00 && 0.00 <= vegetablesKilos && vegetablesKilos <= 1000.00
                && 0.00 <= fruitsKilos && fruitsKilos <= 1000.00)
            {
                Console.WriteLine("Correct values are entered");
            }
            else
            {
                throw new ArgumentOutOfRangeException("Value must be in ragne of 0.00 and 1000.00");
            }

            double totalPriceForVegetables = vegetablesPrice * vegetablesKilos;
            double totalPriceForFruits = fruitsPrice * fruitsKilos;
            double totalInEuros = Math.Round(((totalPriceForFruits + totalPriceForVegetables) / 1.94), 2);

            Console.WriteLine("Total Price ine Euros is: " + totalInEuros);
            
        }
    }
}
