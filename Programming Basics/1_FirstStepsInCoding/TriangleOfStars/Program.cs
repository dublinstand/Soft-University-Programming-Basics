using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOfStars
{
    
    class TriangleOfStars
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 55; i++)
            {

                for (int u = 0; u <= i; u++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}

