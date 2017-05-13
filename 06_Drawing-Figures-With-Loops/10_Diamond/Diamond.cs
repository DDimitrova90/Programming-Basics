using System;

class Diamond
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.Write(new string('-', (n - 1) / 2));

        if (n % 2 == 0)
        {
            Console.Write("**");
        }
        else
        {
            Console.Write("*");
        }

        Console.WriteLine(new string('-', (n - 1) / 2));

        for (int i = 0; i < ((n - 1) / 2); i++)
        {      
            Console.Write(new string('-', ((n - 1) / 2) - 1 - i) + "*");

            if (n % 2 == 0)
            {
                Console.Write(new string('-', 2 + (2 * i)));
            }
            else
            {
                Console.Write(new string('-', 1 + (2 * i)));
            }

            Console.WriteLine("*" + new string('-', ((n - 1) / 2) - 1 - i));
        }

        for (int i = 0; i < ((n - 1) / 2) - 1; i++)
        {
            Console.WriteLine(
                new string('-', 1 + i) + "*" + 
                new string('-', n - 4 - (2 * i)) + "*" + 
                new string('-', 1 + i));
        }

        if (n != 1 && n != 2)
        {
            Console.Write(new string('-', (n - 1) / 2));

            if (n % 2 == 0)
            {
                Console.Write("**");
            }
            else
            {
                Console.Write("*");
            }

            Console.WriteLine(new string('-', (n - 1) / 2));
        }
    }
}

