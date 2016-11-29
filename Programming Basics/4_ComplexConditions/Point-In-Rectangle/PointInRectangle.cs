using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PointInRectangle
{
    static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool toLeftSide = (x >= x1);
        bool toRightSide = (x <= x2);
        bool toTopSide = (y >= y1);
        bool toBottomSide = (y <= y2);

        if(toLeftSide && toRightSide && toTopSide && toBottomSide)
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Outside");
        }

    }
}

