using System;

class Number_in_Range1_100
{
    static void Main()
    {
        Console.WriteLine("Еnter a number in the range [1...100]:");
        int num = int.Parse(Console.ReadLine());

        while (num <= 0 || num > 100)
        {
            Console.WriteLine("Invalid number!");
            Console.WriteLine("Еnter a number in the range [1...100]:");
            num = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The number is: {0}", num);

    }
}

