using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThePassword
{
    class GuessThePassword
    {
        static void Main(string[] args)
        {
            String password = "s3cr3t!P@ssw0rd";
            String guessPassword = Console.ReadLine();

            if (guessPassword == password)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong Password!");
            }

        }
    }
}
