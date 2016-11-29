using System;

class VowelsSum
{
    static void Main()
    {
        string text = Console.ReadLine();
        int sumVowels = 0;

        for (int i = 0; i <= text.Length -1; i++)
        {
            char currentSymbol = text[i];
            switch (currentSymbol)
            {
                case 'a':
                    sumVowels += 1;
                    break;
                case 'e':
                    sumVowels += 2;
                    break;
                case 'i':
                    sumVowels += 3;
                    break;
                case 'o':
                    sumVowels += 4;
                    break;
                case 'u':
                    sumVowels += 5;
                    break;
            }
        }
        Console.WriteLine(sumVowels);
    }
}

