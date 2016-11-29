using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchesToSantimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the amount of inches you want to convert: ");
            var inches = double.Parse(Console.ReadLine());
            var santimeters = inches * 2.54;
            Console.WriteLine("The santimeters are: " + santimeters);
        }
    }
}
