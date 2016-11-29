using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trapezeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Моля въведете страните на трапеца: ");
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine("Моля въведете височината на трапеца: ");
            var h = double.Parse(Console.ReadLine());
            var s = (a + b) * h / 2.0;
            Console.WriteLine("Лицето на трапеца е: " + s);
        }
    }
}
