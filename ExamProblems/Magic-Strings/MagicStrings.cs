using System;

class MagicStrings     // https://judge.softuni.bg/Contests/Practice/Index/4#3
{
    static void Main()     
    {
        int diff = int.Parse(Console.ReadLine());
        char[] letters = {'k', 'n', 'p', 's' };
        int weight = 0;
        int firstSum = 0;
        int secondSum = 0;
        bool noMagicStrings = true;

        for (int i = 0; i < letters.Length; i++)
        {
            for (int j = 0; j < letters.Length; j++)
            {
                for (int k = 0; k < letters.Length; k++)
                {
                    for (int l = 0; l < letters.Length; l++)
                    {
                        for (int m = 0; m < letters.Length; m++)
                        {
                            for (int n = 0; n < letters.Length; n++)
                            {
                                for (int o = 0; o < letters.Length; o++)
                                {
                                    for (int p = 0; p < letters.Length; p++)
                                    {

                                        string magicStr = 
                                            "" + letters[i] + letters[j] + letters[k]
                                               + letters[l] + letters[m] + letters[n] 
                                               + letters[o] + letters[p];

                                        for (int q = 0; q < magicStr.Length; q++)
                                        {
                                            switch (magicStr[q])
                                            {
                                                case 'k':
                                                    weight = 1;
                                                    break;
                                                case 'n':
                                                    weight = 4;
                                                    break;
                                                case 'p':
                                                    weight = 5;
                                                    break;
                                                case 's':
                                                    weight = 3;
                                                    break;
                                            }

                                            if (q < 4)
                                            {
                                                firstSum += weight;
                                            }
                                            else
                                            {
                                                secondSum += weight;
                                            }
                                        }

                                        if (Math.Abs(firstSum - secondSum) == diff)
                                        {
                                            Console.WriteLine(magicStr);
                                            noMagicStrings = false;
                                        }

                                        firstSum = 0;
                                        secondSum = 0;                                       
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        if (noMagicStrings)
        {
            Console.WriteLine("No");
        }
    }
}

