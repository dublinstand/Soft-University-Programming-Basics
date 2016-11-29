using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter values for A and H of the triangle");
            var a = float.Parse(Console.ReadLine());
            var h = float.Parse(Console.ReadLine());
            var triangleArea = a * h / 2;
            var roundedTriangleArea = Math.Round(triangleArea, 2);
            Console.WriteLine("Triangle Area is: " + roundedTriangleArea);
        }
    }
}
