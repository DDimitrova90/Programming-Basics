using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        decimal factorial = 1;

        while (number > 0)
        {
            factorial *= number;
            number--;
        }

        Console.WriteLine(factorial);
    }
}

