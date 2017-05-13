using System;

class Stop
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int dash = (2 * n) - 1;
        int row = n;
        int dot = 1;
        int dash1 = (4 * n) - 3;

        Console.Write(new string('.', n + 1));
        Console.Write(new string('_', (2 * n) + 1));
        Console.WriteLine(new string('.', n + 1));

        for (int i = 0; i < n; i++)
        {           
            Console.Write(new string('.', row));
            Console.Write("//");
            Console.Write(new string('_', dash));
            Console.Write(@"\\");
            Console.WriteLine(new string('.', row));
            row--;
            dash += 2;
        }

        Console.Write("//");
        Console.Write(new string('_', (2 * n) - 3));
        Console.Write("STOP!");
        Console.Write(new string('_', (2 * n) - 3));
        Console.WriteLine(@"\\");
        Console.Write(@"\\");
        Console.Write(new string('_', (4 * n) - 1));
        Console.WriteLine("//");

        for (int i = 0; i < n - 1; i++)
        {            
            Console.Write(new string('.', dot));
            Console.Write(@"\\");
            Console.Write(new string('_', dash1));
            Console.Write("//");
            Console.WriteLine(new string('.',dot));
            dot++;
            dash1 -= 2;
        }
    }
}

