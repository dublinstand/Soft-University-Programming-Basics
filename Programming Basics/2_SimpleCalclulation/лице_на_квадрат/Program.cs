using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лице_на_квадрат
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Моля въведете страната на квадрата: ");
            var a = int.Parse(Console.ReadLine());
            var squareArea = a * a;

            Console.WriteLine("Лицето на квадрата е: {0}", squareArea);
        }
    }
}
