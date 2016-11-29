using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AnimalType
{
    static void Main(string[] args)
    {
        string mammal = Console.ReadLine().ToLower();

        switch (mammal)
        {
            case "dog":
                Console.WriteLine("mammal");
                break;
            case "crocodile":
                Console.WriteLine("reptile");
                break;
            case "tortoise":
                Console.WriteLine("reptile");
                break;
            case "snake":
                Console.WriteLine("reptile");
                break;

            default:
                Console.WriteLine("unknown");
                break;
        }
    }
}

