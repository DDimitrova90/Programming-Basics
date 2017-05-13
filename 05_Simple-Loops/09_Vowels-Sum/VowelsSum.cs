using System;

class VowelsSum
{
    static void Main()
    {
        string str = Console.ReadLine();
        char vowel;
        int sum = 0;

        for (int i = 0; i < str.Length; i++)
        {
            vowel = str[i];

            if (vowel == 'a')
            {
                sum += 1;
            }
            else if (vowel == 'e')
            {
                sum += 2;
            }
            else if (vowel == 'i')
            {
                sum += 3;
            }
            else if (vowel == 'o')
            {
                sum += 4;
            }
            else if (vowel == 'u')
            {
                sum += 5;
            }
        }

        Console.WriteLine(sum);
    }
}

