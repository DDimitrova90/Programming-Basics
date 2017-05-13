using System;

class LettersSymbolsNumbers     // https://judge.softuni.bg/Contests/Practice/Index/17#1
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int lettersSum = 0;
        int numbersSum = 0;
        int symbolsSum = 0;

        for (int j = 0; j < n; j++)
        {
            string inputStr = Console.ReadLine().ToLower().Replace(" ", "");

            for (int i = 0; i < inputStr.Length; i++)
            {
                if (inputStr[i] >= 97 && inputStr[i] <= 122)
                {
                    lettersSum += (inputStr[i] - 96) * 10;
                }
                else if (inputStr[i] >= 48 && inputStr[i] <= 57)
                {
                    numbersSum += (inputStr[i] - 48) * 20;
                }
                else if (inputStr[i] != '\t' && inputStr[i] != '\r' && inputStr[i] != '\n')
                {
                    symbolsSum += 200;
                }
            }
        }
        
        Console.WriteLine(lettersSum);
        Console.WriteLine(numbersSum);
        Console.WriteLine(symbolsSum);
    }
}

