using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SameWords
{
    class SameWords
    {
        static void Main(string[] args)
        {
            String firstWord = Console.ReadLine();
            String secondWord = Console.ReadLine();


            if (firstWord.ToLower() == secondWord.ToLower())
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
