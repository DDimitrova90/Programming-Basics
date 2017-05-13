using System;

class RandomizeTheNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Random randomNums = new Random();

        for (int i = 0; i < n; i++)
        {
            Console.Write(randomNums.Next(1, n + 1) + " ");
        }

        Console.WriteLine();
    }
}

