using System;

class Butterfly
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string star = new string('*', n - 2);
        string dash = new string('-', n - 2);
        string middle = @"\ /";
        string middle1 = @"/ \";

        for (int i = 0; i < n - 2; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(star);
                Console.Write(middle);
                Console.WriteLine(star);
            }
            else
            {
                Console.Write(dash);
                Console.Write(middle);
                Console.WriteLine(dash);
            }                  
        }

        Console.Write(new string(' ', n - 1));
        Console.Write("@");
        Console.WriteLine(new string(' ', n - 1));

        for (int i = 0; i < n - 2; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(star);
                Console.Write(middle1);
                Console.WriteLine(star);
            }
            else
            {
                Console.Write(dash);
                Console.Write(middle1);
                Console.WriteLine(dash);
            }
        }
    }
}

