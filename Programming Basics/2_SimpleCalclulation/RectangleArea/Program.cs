using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the values for x1, x2, y1 and y2: ");
            var x1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var a = Math.Abs(x1 - x2);
            var b = Math.Abs(y1 - y2);

            var square = a * b;
            var perimeter = (a + b) * 2;

            Console.WriteLine("Square is: {0} and perimeter is: {1}", square, perimeter);
        }
    }
}
