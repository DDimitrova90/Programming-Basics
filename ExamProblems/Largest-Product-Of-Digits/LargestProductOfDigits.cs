using System;   

class LargestProductOfDigits    // https://judge.softuni.bg/Contests/Practice/Index/50#5
{
    static void Main()
    {
        string num = Console.ReadLine();

        int product = 1;
        int maxProduct = 0;

        for (int i = 0; i < num.Length - 5; i++)
        {
            for (int j = i; j < i + 6; j++)
            {
                product *= Convert.ToInt32(num[j] - 48);
            }

            if (product > maxProduct)
            {
                maxProduct = product;
            }

            product = 1;
        }

        Console.WriteLine(maxProduct);
    }
}

