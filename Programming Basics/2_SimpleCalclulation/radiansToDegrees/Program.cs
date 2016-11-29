using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value for radians you want to convert: ");
            double rad = double.Parse(Console.ReadLine());
            double degrees = rad * 180 / Math.PI;
            var roundedDegrees = Math.Round(degrees);

            Console.WriteLine(new String('*', 50));
            Console.WriteLine("This is the converted degrees: {0}", roundedDegrees);


        }
    }
}
