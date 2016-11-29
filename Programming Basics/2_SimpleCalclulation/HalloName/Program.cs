using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Моля въведете името си: ");
            var name = Console.ReadLine();
            Console.WriteLine("Здравейте {0}", name);
        }
    }
}
