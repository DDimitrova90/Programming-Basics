using System;

class StopNumber    // https://judge.softuni.bg/Contests/Practice/Index/233#5
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int stop = int.Parse(Console.ReadLine());

        for (int i = m; i >= n; i--)
        {
            if (i % 2 == 0 && i % 3 == 0)
            {
                if (i == stop)
                {
                    break;
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}

