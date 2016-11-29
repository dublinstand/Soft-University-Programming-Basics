using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PersonalTitles
{
    static void Main()
    {
        double age = double.Parse(Console.ReadLine());
        String gender = Console.ReadLine().ToLower();

        if (gender == "f")
        {
            if (age < 16)
            {
                Console.WriteLine("Miss");
            }
            else
            {
                Console.WriteLine("Ms.");
            }
        }

        if (gender == "m")
        {
            if (age < 16)
            {
                Console.WriteLine("Master");
            }
            else
            {
                Console.WriteLine("Mr.");
            }
        }

    }
}

