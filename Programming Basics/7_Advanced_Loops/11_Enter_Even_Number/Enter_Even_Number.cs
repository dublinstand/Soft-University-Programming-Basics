using System;

class Enter_Even_Number
{
    static void Main()
    {
        int n;        

        while (true)
        {
            Console.WriteLine("Enter even number: ");

            try
            {
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("The number is not even.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
        }

        Console.WriteLine("Even number entered: {0}", n);
    }
}

