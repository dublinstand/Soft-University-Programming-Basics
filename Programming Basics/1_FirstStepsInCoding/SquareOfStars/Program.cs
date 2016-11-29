using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class SquareOfStars
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете броя на звездите: ");
            var n = int.Parse(Console.ReadLine());

            for(int row = 0; row <= n; row++)
            {
                for(int column = 0; column <= n; column++)
                {
                    if (row == 0 || row == n)
                    {
                        Console.Write("*");
                    }
                    else
                    {

                        if (column == 0 || column == n)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                }
                Console.WriteLine("");

            }
        }
    }
}
