using System;

class EvenPowersOf2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <= n; i++)    // or in the loop: i * 4
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}

