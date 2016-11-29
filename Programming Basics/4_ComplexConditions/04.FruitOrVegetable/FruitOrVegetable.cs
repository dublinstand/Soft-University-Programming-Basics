using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FruitOrVegetable
{
    static void Main(string[] args)
    {
        String product = Console.ReadLine().ToLower();

        if (product == "banana" || product == "apple" || product == "kiwi" || product == "cherry" || product == "lemon" || product == "grapes")
        {
            Console.WriteLine("fruit");
        }
        else if (product == "tomato" || product == "cucumber" || product == "pepper" || product == "carrot")
        {
            Console.WriteLine("vegetable");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}

