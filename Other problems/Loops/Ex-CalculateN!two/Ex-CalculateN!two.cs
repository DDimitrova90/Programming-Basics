using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        decimal factorial = 1;

        do
        {
            factorial *= number;
            number--;
        }
        while (number > 0);

        Console.WriteLine(factorial);
    }
}

