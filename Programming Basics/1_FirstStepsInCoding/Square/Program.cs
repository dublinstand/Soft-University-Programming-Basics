using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    class Square
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сложете дължината на първата страна: ");
            String firstEntry = Console.ReadLine();
            int firstNumber;
            Int32.TryParse(firstEntry, out firstNumber);

            Console.WriteLine("Сложете дължината на втората страна: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int c = firstNumber * secondNumber;

            Console.WriteLine("Лицето на правоъгълника е: " + c);

        }
    }
}
