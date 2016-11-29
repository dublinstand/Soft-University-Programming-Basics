using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixingTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size of the square part:");
            double squareSize = double.Parse(Console.ReadLine());

            if (1 <= squareSize && squareSize <= 100)
            {
                Console.WriteLine("Value is fine");
            }
            else
            {
                throw new ArgumentOutOfRangeException("Value must be in range of 1 - 100");
            }
            Console.WriteLine("Please enter the size of the tile Width:");
            double tileWidth = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the size of the sqaure part: tileHeight");
            double tileHeight = double.Parse(Console.ReadLine());

            if (0.1 <= tileWidth && tileWidth <= 10.00 && 0.1 <= tileHeight && tileHeight <= 10.00)
            {
                Console.WriteLine("Value is fine");
            }
            else
            {
                throw new ArgumentOutOfRangeException("Value must be in range of 1 - 10");
            }

            Console.WriteLine("Please enter the size of the benchWidth:");
            double benchWidth = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the size of the benchHeight:");
            double benchHeight = double.Parse(Console.ReadLine());

            if (0 <= benchWidth && benchWidth <= 10.00 && 0.1 <= benchHeight && benchHeight <= 10)
            {
                Console.WriteLine("Value is fine");
            }
            else
            {
                throw new ArgumentOutOfRangeException("Value must be in range of 0 - 10");
            }
            
            double areaSize = squareSize * squareSize;
            double benchSize = benchHeight * benchWidth;
            double totalAreaToCover = areaSize - benchSize;

            double areaTile = tileWidth * tileHeight;
            double tilesNeeded = totalAreaToCover / areaTile;
            double timeNeeded = tilesNeeded * 0.2;

            Console.WriteLine("Tiles needed is: {0}", tilesNeeded);
            Console.WriteLine("Time needed: " + timeNeeded);

        }
    }
}
