using System;

class Eclipse     // https://judge.softuni.bg/Contests/Practice/Index/3#2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            if (i == 0 || i == n - 1)
            {
                Console.WriteLine(" " + 
                    new string('*', (2 * n) - 2) + " " + 
                    new string(' ', n - 1) + " " + 
                    new string('*', (2 * n) - 2) + " ");
            }
            else if (i == ((n - 1) / 2))
            {
                Console.WriteLine("*" + 
                    new string('/', (2 * n) - 2) + "*" + 
                    new string('-', n - 1) + "*" + 
                    new string('/', (2 * n) - 2) + "*");
            }
            else
            {
                Console.WriteLine("*" + 
                    new string('/', (2 * n) - 2) + "*" + 
                    new string(' ', n - 1) + "*" + 
                    new string('/', (2 * n) - 2) + "*");
            }
        }
    }
}

