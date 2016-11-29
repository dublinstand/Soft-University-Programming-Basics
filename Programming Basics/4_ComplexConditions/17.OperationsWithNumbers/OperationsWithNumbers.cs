using System;


class OperationsWithNumbers
{
    static void Main()
    {
        double n1 = double.Parse(Console.ReadLine());
        double n2 = double.Parse(Console.ReadLine());
        string op = Console.ReadLine();
        double total = 0;
        string typeOfNumber = "";

        if (op == "/" && n2 == 0 || op == "%" && n2 == 0)
        {
            Console.WriteLine("Cannot divide {0} by zero", n1);
        }
        else if (op == "/")
        {
            total = n1 / n2;
            Console.WriteLine("{0} {1} {2} = {3:f2}", n1, op, n2, total);
        }
        else if (op == "%")
        {
            total = n1 % n2;
            Console.WriteLine("{0} {1} {2} = {3}", n1, op, n2, total);
        }

        if (op == "+")
        {
            total = n1 + n2;
            if (total % 10 == 2)
            {
                typeOfNumber = "even";
            }
            else
            {
                typeOfNumber = "odd";
            }
            Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, op, n2, total, typeOfNumber);
        }
        else if (op == "-")
        {
            total = n1 - n2;
            if (total % 10 == 2)
            {
                typeOfNumber = "even";
            }
            else
            {
                typeOfNumber = "odd";
            }
            Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, op, n2, total, typeOfNumber);
        }
        else if (op == "*")
        {
            total = n1 * n2;
            if (total % 10 == 2)
            {
                typeOfNumber = "even";
            }
            else
            {
                typeOfNumber = "odd";
            }
            Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, op, n2, total, typeOfNumber);
        }

        
    }
}

