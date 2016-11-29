using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWordTo100
{
    class NumberToWordTo100
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int tens = number / 10;  //this gives the number of tens as long as you enter XX digits, otherwise it will be 
            //int tens = (number /10) % 10; if you enter number bigger than 100 
            int ones;

            if (number == 0)
            {
                Console.WriteLine("zero");
            }

            if (number == 100)
            {
                Console.WriteLine("one hundred");
            }

            if (number < 0 || number > 100)
            {
                Console.WriteLine("invalid number");               
            }

            //Console.WriteLine(tens +"  " + ones);

            if (tens == 1 && number < 100)
            {
                ones = number % 100;  
            }
            else
            {
                ones = number % 10;
            }

            if (number < 100)
            {
                switch (tens)
                {
                    case 2:
                        Console.WriteLine("twenty");
                        break;
                    case 3:
                        Console.WriteLine("thirty");
                        break;
                    case 4:
                        Console.WriteLine("fourty");
                        break;
                    case 5:
                        Console.WriteLine("fifty");
                        break;
                    case 6:
                        Console.WriteLine("sixty");
                        break;
                    case 7:
                        Console.WriteLine("seventy");
                        break;
                    case 8:
                        Console.WriteLine("eighty");
                        break;
                    case 9:
                        Console.WriteLine("ninety");
                        break;
                }
            }

            if (tens > 1 && ones != 0 && number < 100)
            {
                Console.Write(" ");
            }

            if (number < 100)
            {            
            switch (ones)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                case 10:
                    Console.WriteLine("ten");
                    break;
                case 11:
                    Console.WriteLine("eleven");
                    break;
                case 12:
                    Console.WriteLine("twelve");
                    break;
                case 13:
                    Console.WriteLine("thirteen");
                    break;
                case 14:
                    Console.WriteLine("fourteen");
                    break;
                case 15:
                    Console.WriteLine("fifteen");
                    break;
                case 16:
                    Console.WriteLine("sixteen");
                    break;
                case 17:
                    Console.WriteLine("seventeen");
                    break;
                case 18:
                    Console.WriteLine("eighteen");
                    break;
                case 19:
                    Console.WriteLine("nineteen");
                    break;
            }
            }
        }
    }
}
