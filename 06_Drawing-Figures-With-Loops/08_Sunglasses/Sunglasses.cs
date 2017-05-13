using System;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));

        for (int i = 0; i < n - 2; i++)
        {
            Console.Write("*" + new string('/', (2 * n) - 2) + "*");

            if (i == ((n - 1) / 2) - 1)
            {
                Console.Write(new string('|', n));
            }
            else
            {
                Console.Write(new string(' ', n));
            }

            Console.WriteLine("*" + new string('/', (2 * n) - 2) + "*");
        }

        Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));
    }
}

