using System;

class WinningNumbers     // https://judge.softuni.bg/Contests/Practice/Index/24#3
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        int letSum = 0;
        int valueLetter = 0;
        int winningNumsCount = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] >= 97 && input[i] <= 122)
            {
                valueLetter = input[i] - 96;
                letSum += valueLetter;
            }
        }

        for (int a = 1; a <= 9; a++)
        {
            for (int b = 1; b <= 9; b++)
            {
                for (int c = 1; c <= 9; c++)
                {
                    for (int d = 1; d <= 9; d++)
                    {
                        for (int e = 1; e <= 9; e++)
                        {
                            for (int f = 1; f <= 9; f++)
                            {
                                int firstProduct = a * b * c;
                                int secondProduct = d * e * f;

                                if ((firstProduct == secondProduct) && (secondProduct == letSum))
                                {
                                    Console.WriteLine("{0}{1}{2}-{3}{4}{5}", a, b, c , d, e ,f);
                                    winningNumsCount++;
                                }
                            }
                        }
                    }
                }
            }
        }

        if (winningNumsCount == 0)
        {
            Console.WriteLine("No");
        }
    }
}

