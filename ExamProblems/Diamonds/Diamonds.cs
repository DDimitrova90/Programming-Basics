using System;

class Diamonds     // https://judge.softuni.bg/Contests/Practice/Index/50#7
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < ((n - 1) / 2) + 1; i++)
        {
            if (i == 0)
            {
                Console.WriteLine(
                    new string('-', (n - 1) / 2) + "*" + 
                    new string('-', (n - 1) / 2));
            }
            else
            {
                Console.WriteLine(
                    new string('-', ((n - 1) / 2) - i) + 
                    "*" + 
                    new string('-',(2 * i) - 1) + 
                    "*" + 
                    new string('-', ((n - 1) / 2) - i));
            }
        }

        for (int i = 0; i < (n - 1) / 2; i++)
        {
            if (i == ((n - 1) / 2) - 1)
            {
                Console.WriteLine(
                    new string('-', (n - 1) / 2) + 
                    "*" + 
                    new string('-', (n - 1) / 2));
            }
            else
            {
                Console.WriteLine(
                    new string('-', i + 1) + 
                    "*" + 
                    new string('-', n - 4 - (2 * i)) + 
                    "*" + 
                    new string('-', i + 1));
            }
        }
    }
}

