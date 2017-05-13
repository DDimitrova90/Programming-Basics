using System;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < (n - 1) / 2; i++)
        {
            Console.Write(new string('-', ((n - 1) / 2) - i));

            if (n % 2 != 0)
            {
                Console.Write(new string('*', 1 + (2 * i)));
            }
            else
            {
                Console.Write(new string('*', 2 + (2 * i)));
            }

            Console.WriteLine(new string('-', ((n - 1) / 2) - i));
        }

        Console.WriteLine(new string('*', n));

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("|" + new string('*', n - 2) + "|");
        }     
    }
}

