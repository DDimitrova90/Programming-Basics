using System;

class MorseCodeNumbers      // https://judge.softuni.bg/Contests/Practice/Index/17#3
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int nSum = 0;
        int morseProduct = 0;
        string morseString = string.Empty;
        string morseEncoding = string.Empty;
        bool noMorseCodeNums = true;

        while (n > 0)
        {
            nSum += n % 10;
            n = n / 10;
        }

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                for (int k = 1; k <= 5; k++)
                {
                    for (int l = 1; l <= 5; l++)
                    {
                        for (int m = 1; m <= 5; m++)
                        {
                            for (int o = 1; o <= 5; o++)
                            {
                                morseProduct = i * j * k * l * m * o;

                                if (nSum == morseProduct)
                                {
                                    morseString = "" + i + j + k + l + m + o;
                                    noMorseCodeNums = false;

                                    for (int p = 0; p < morseString.Length; p++)
                                    {
                                        morseEncoding = morseString[p].ToString();

                                        switch (morseString[p])
                                        {
                                            case '1':
                                                morseEncoding = ".----";
                                                break;
                                            case '2':
                                                morseEncoding = "..---";
                                                break;
                                            case '3':
                                                morseEncoding = "...--";
                                                break;
                                            case '4':
                                                morseEncoding = "....-";
                                                break;
                                            case '5':
                                                morseEncoding = ".....";
                                                break;
                                        }

                                        if (p == morseString.Length - 1)
                                        {
                                            Console.WriteLine("{0}|", morseEncoding);
                                        }
                                        else
                                        {
                                            Console.Write("{0}|", morseEncoding);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        if (noMorseCodeNums)
        {
            Console.WriteLine("No");
        }
    }
}

